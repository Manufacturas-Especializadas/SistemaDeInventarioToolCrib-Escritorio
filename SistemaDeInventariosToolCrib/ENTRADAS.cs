using ExcelDataReader;
using Microsoft.Data.SqlClient;
using SistemaDeInventariosToolCrib.Connection;
using System.Data;
using System.Runtime.CompilerServices;
using Timer = System.Windows.Forms.Timer;

namespace SistemaDeInventariosToolCrib
{
    public partial class ENTRADAS : Form
    {
        private int paginaActual = 1;
        private int filasPorPagina = 20;
        private DataTable tablaCompleta = new DataTable();
        private int? currentMaterialId = null;
        private string currentSku = string.Empty;

        public ENTRADAS()
        {
            InitializeComponent();
        }

        private async void ENTRADAS_Load(object sender, EventArgs e)
        {
            ConfigurarEstiloDataGridView();
            await LoadData();
        }

        private void ConfigurarEstiloDataGridView()
        {
            dtGdVwEntrada.Font = new Font("Arial", 12);
            dtGdVwEntrada.DefaultCellStyle.Font = new Font("Arial", 12);
            dtGdVwEntrada.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dtGdVwEntrada.RowHeadersVisible = false;

            dtGdVwEntrada.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtGdVwEntrada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGdVwEntrada.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private async void txtBxEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                string barcode = txtBxEntrada.Text.Trim();
                txtBxEntrada.SelectAll();

                if (string.IsNullOrEmpty(barcode))
                {
                    return;
                }

                if (!string.IsNullOrEmpty(currentSku) && barcode == currentSku)
                {
                    await UpdateStockAsync(currentMaterialId!.Value);
                }
                else
                {
                    bool found = await SearchMaterialByPartNumberAsync(barcode);

                    if (found)
                    {
                        await ShowOnlyRegister(currentMaterialId!.Value);
                    }
                    else
                    {
                        MessageBox.Show("Sku no encontrado");
                        txtBxEntrada.Clear();
                    }
                }
            }
        }

        private async Task<bool> SearchMaterialByPartNumberAsync(string sku)
        {
            try
            {
                using (SqlConnection conn = await ConnectionToDataBase.GetConnectionAsync())
                {
                    if (conn == null || conn.State != ConnectionState.Open)
                    {
                        return false;
                    }

                    string query = "SELECT Id FROM TOOLCRIB WHERE sku = @sku";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@sku", sku);

                        var result = await cmd.ExecuteScalarAsync();

                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            currentMaterialId = id;
                            currentSku = sku;
                            return true;
                        }

                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar el número de parte: {ex.Message}");
                return false;
            }
        }

        private async Task LoadData()
        {
            string query = @"
                            SELECT
                                Id, sku, existencia,
                                minimo, maximo,
                                linea, comentarios, categoria, fecha, hora,
                                ubicacion, material, unidadDeMedida,
                                proveedor, numeroDeSerie, costoUnitario,
                                ramos, santa, aluminio, cobre, modificado
                            FROM TOOLCRIB
                            ORDER BY Id DESC";

            tablaCompleta.Clear();

            using (SqlConnection conn = await ConnectionToDataBase.GetConnectionAsync())
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    MessageBox.Show("No se pudo conectar a la base de datos");

                    return;
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        tablaCompleta.Load(reader);
                    }
                }
            }
            tablaCompleta.PrimaryKey = new DataColumn[] { tablaCompleta.Columns["Id"]! };

            ShowPage(paginaActual);
        }

        private void ShowPage(int pagina)
        {
            if (tablaCompleta.Rows.Count == 0)
            {
                dtGdVwEntrada.DataSource = null;
                lbPagination.Text = "Página 0 de 0";
                return;
            }

            int totalFila = tablaCompleta.Rows.Count;
            int totalPages = (int)Math.Ceiling((double)totalFila / filasPorPagina);

            if (pagina < 1) pagina = 1;
            if (pagina > totalPages) pagina = totalPages;

            paginaActual = pagina;

            int filaInicio = (pagina - 1) * filasPorPagina;

            DataTable paginaTabla = tablaCompleta.Clone();
            int count = 0;

            for (int i = filaInicio; i < tablaCompleta.Rows.Count && count < filasPorPagina; i++, count++)
            {
                paginaTabla.ImportRow(tablaCompleta.Rows[i]);
            }

            paginaTabla.Columns["sku"]!.ColumnName = "Sku";
            paginaTabla.Columns["existencia"]!.ColumnName = "Existencia";
            paginaTabla.Columns["minimo"]!.ColumnName = "Minimo";
            paginaTabla.Columns["maximo"]!.ColumnName = "Maximo";
            paginaTabla.Columns["linea"]!.ColumnName = "Linea";
            paginaTabla.Columns["comentarios"]!.ColumnName = "Comentarios";
            paginaTabla.Columns["categoria"]!.ColumnName = "Categoria";
            paginaTabla.Columns["ubicacion"]!.ColumnName = "Ubicacion";
            paginaTabla.Columns["fecha"]!.ColumnName = "Fecha";
            paginaTabla.Columns["hora"]!.ColumnName = "Hora";
            paginaTabla.Columns["material"]!.ColumnName = "Material";
            paginaTabla.Columns["modificado"]!.ColumnName = "Modificado";
            paginaTabla.Columns["unidadDeMedida"]!.ColumnName = "Unidad de medida";
            paginaTabla.Columns["proveedor"]!.ColumnName = "Proveedor";
            paginaTabla.Columns["numeroDeSerie"]!.ColumnName = "Numero de serie";
            paginaTabla.Columns["costoUnitario"]!.ColumnName = "Costo unitario";
            paginaTabla.Columns["ramos"]!.ColumnName = "Ramos";
            paginaTabla.Columns["santa"]!.ColumnName = "Santa";
            paginaTabla.Columns["aluminio"]!.ColumnName = "Aluminio";
            paginaTabla.Columns["cobre"]!.ColumnName = "Cobre";

            dtGdVwEntrada.DataSource = paginaTabla;

            //dtGdVwEntrada.RowHeadersVisible = false;

            dtGdVwEntrada.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dtGdVwEntrada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dtGdVwEntrada.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            lbPagination.Text = $"Página {paginaActual} de {totalPages}";
        }

        private async Task ShowOnlyRegister(int id)
        {
            try
            {
                using(SqlConnection conn = await ConnectionToDataBase.GetConnectionAsync())
                {
                    if(conn == null || conn.State != ConnectionState.Open)
                    {
                        MessageBox.Show("No se pudo conectar a la base de datos");
                        return;
                    }

                    string query = @"
                                SELECT 
                                    Id, sku, existencia, minimo, maximo,
                                    linea, comentarios, categoria, fecha, hora,
                                    ubicacion, material, unidadDeMedida,
                                    proveedor, numeroDeSerie, costoUnitario,
                                    ramos, santa, aluminio, cobre, modificado
                                FROM TOOLCRIB
                                WHERE Id = @id;
                            ";

                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using(SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            DataTable filteredTable = new DataTable();
                            filteredTable.Load(reader);

                            if(filteredTable.Rows.Count > 0)
                            {
                                RenameColumns(filteredTable);
                                dtGdVwEntrada.DataSource = filteredTable;
                                lbPagination.Text = "Página 1 de 1";
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el registro");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el registro actualizado: {ex.Message}");               
            }
        }

        private void RenameColumns(DataTable dt)
        {
            dt.Columns["sku"]!.ColumnName = "Sku";
            dt.Columns["existencia"]!.ColumnName = "Existencia";
            dt.Columns["minimo"]!.ColumnName = "Minimo";
            dt.Columns["maximo"]!.ColumnName = "Maximo";
            dt.Columns["linea"]!.ColumnName = "Linea";
            dt.Columns["comentarios"]!.ColumnName = "Comentarios";
            dt.Columns["categoria"]!.ColumnName = "Categoria";
            dt.Columns["ubicacion"]!.ColumnName = "Ubicacion";
            dt.Columns["fecha"]!.ColumnName = "Fecha";
            dt.Columns["hora"]!.ColumnName = "Hora";
            dt.Columns["material"]!.ColumnName = "Material";
            dt.Columns["modificado"]!.ColumnName = "Modificado";
            dt.Columns["unidadDeMedida"]!.ColumnName = "Unidad de medida";
            dt.Columns["proveedor"]!.ColumnName = "Proveedor";
            dt.Columns["numeroDeSerie"]!.ColumnName = "Numero de serie";
            dt.Columns["costoUnitario"]!.ColumnName = "Costo unitario";
            dt.Columns["ramos"]!.ColumnName = "Ramos";
            dt.Columns["santa"]!.ColumnName = "Santa";
            dt.Columns["aluminio"]!.ColumnName = "Aluminio";
            dt.Columns["cobre"]!.ColumnName = "Cobre";
        }

        private DataTable ReadExcel(string filePath)
        {
            try
            {
                using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = true
                            }
                        });

                        if (result == null || result.Tables.Count == 0)
                        {
                            MessageBox.Show("El archivo no contiene hojas con datos.");
                            return null!;
                        }

                        var dataTable = result.Tables[0].Copy();

                        foreach (DataRow row in dataTable.Rows)
                        {
                            if (!string.IsNullOrEmpty(row["existencia"].ToString()))
                            {
                                if (!int.TryParse(row["existencia"].ToString(), out int existencias))
                                {
                                    row["existencia"] = 0;
                                }
                            }
                            else
                            {
                                row["existencia"] = 0;
                            }
                        }

                        ValidateDataTable(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo Excel: {ex.Message}");
                return null!;
            }
        }

        private void ValidateDataTable(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    switch (col.ColumnName.ToLower())
                    {
                        case "ramos":
                            ValidateAndCleanStringColumn(row, "RAMOS", 30);
                            break;
                        case "santa":
                            ValidateAndCleanStringColumn(row, "SANTA", 30);
                            break;
                        case "aluminio":
                            ValidateAndCleanStringColumn(row, "ALUMINIO", 30);
                            break;
                        case "cobre":
                            ValidateAndCleanStringColumn(row, "COBRE", 30);
                            break;
                        case "linea":
                            ValidateAndCleanStringColumn(row, "LINEA", 100);
                            break;
                        case "comentarios":
                            ValidateAndCleanStringColumn(row, "COMENTARIOS", 200);
                            break;
                        case "categoria":
                            ValidateAndCleanStringColumn(row, "CATEGORIA", 20);
                            break;
                        case "sku":
                            ValidateAndCleanStringColumn(row, "SKU", 120);
                            break;
                        case "material":
                            ValidateAndCleanStringColumn(row, "MATERIAL TOOL CRIB", 200);
                            break;
                        case "ubicacion":
                            ValidateAndCleanStringColumn(row, "UBICACION", 20);
                            break;
                        case "fecha":
                            ValidateAndCleanStringColumn(row, "FECHA", 40);
                            break;
                        case "hora":
                            ValidateAndCleanStringColumn(row, "HORA", 40);
                            break;
                        case "modificado":
                            ValidateAndCleanStringColumn(row, "UBICACION", 20);
                            break;
                        case "unidadDeMedida":
                            ValidateAndCleanStringColumn(row, "UNIDAD DE MEDIDA", 30);
                            break;
                        case "proveedor":
                            ValidateAndCleanStringColumn(row, "PROVEEDOR", 70);
                            break;
                        case "numeroDeSerie":
                            ValidateAndCleanStringColumn(row, "NUMERO DE SERIE", 80);
                            break;
                        case "costoUnitario":
                            ValidateAndCleanStringColumn(row, "COSTO UNITARIO", 80);
                            break;
                        default:

                            break;
                    }
                }
            }
        }

        private void ValidateAndCleanStringColumn(DataRow row, string columnName, int maxLength)
        {
            if (!string.IsNullOrEmpty(row[columnName]?.ToString()))
            {
                string value = row[columnName].ToString()!;

                value = value.Trim();

                if (value.Length > maxLength)
                {
                    MessageBox.Show($"Valor demasiado largo en la columna '{columnName}' en la fila {row.Table.Rows.IndexOf(row)}: {value}");
                    row[columnName] = value.Substring(0, maxLength);
                }
                else
                {
                    row[columnName] = value;
                }
            }
            else
            {
                row[columnName] = DBNull.Value;
            }
        }

        private async Task<bool> SaveToDatabase(DataTable dt, string nameTable)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para guardar");
                return false;
            }

            using (SqlConnection conn = await ConnectionToDataBase.GetConnectionAsync())
            {
                if (conn == null || conn.State != ConnectionState.Open)
                {
                    return false;
                }

                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                {
                    bulkCopy.DestinationTableName = nameTable;

                    bulkCopy.ColumnMappings.Add("RAMOS", "ramos");
                    bulkCopy.ColumnMappings.Add("SANTA", "santa");
                    bulkCopy.ColumnMappings.Add("ALUMINIO", "aluminio");
                    bulkCopy.ColumnMappings.Add("LINEA", "linea");
                    bulkCopy.ColumnMappings.Add("COMENTARIOS", "comentarios");
                    bulkCopy.ColumnMappings.Add("CATEGORIA", "categoria");
                    bulkCopy.ColumnMappings.Add("SKU", "sku");
                    bulkCopy.ColumnMappings.Add("MATERIAL TOOLCRIB", "material");
                    bulkCopy.ColumnMappings.Add("UBICACION", "ubicacion");
                    bulkCopy.ColumnMappings.Add("FECHA", "fecha");
                    bulkCopy.ColumnMappings.Add("HORA", "hora");
                    bulkCopy.ColumnMappings.Add("MODIFICADO POR", "modificado");
                    bulkCopy.ColumnMappings.Add("UNIDAD DE MEDIDA", "unidadDeMedida");
                    bulkCopy.ColumnMappings.Add("EXISTENCIA", "existencia");
                    bulkCopy.ColumnMappings.Add("MINIMO", "minimo");
                    bulkCopy.ColumnMappings.Add("MAXIMO", "maximo");
                    bulkCopy.ColumnMappings.Add("PROVEEDOR", "proveedor");
                    bulkCopy.ColumnMappings.Add("NUMERO DE SERIE", "numeroDeSerie");
                    bulkCopy.ColumnMappings.Add("COSTO UNITARIO", "costoUnitario");

                    try
                    {
                        await bulkCopy.WriteToServerAsync(dt);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar los datos: {ex.Message}");
                        return false;
                    }
                }

            }
        }

        private async void dtGdVwEntrada_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var row = dtGdVwEntrada.Rows[e.RowIndex];
            string columName = dtGdVwEntrada.Columns[e.ColumnIndex].Name;

            object newValue = row.Cells[e.ColumnIndex].Value;

            if (!int.TryParse(row.Cells["Id"].Value?.ToString(), out int id))
            {
                MessageBox.Show("No se puedo obtener un ID válido");

                return;
            }

            await UpdateDatabaseAsync(id, columName, newValue);
        }

        private async Task UpdateDatabaseAsync(int id, string columnName, object newValue)
        {
            try
            {
                using (SqlConnection conn = await ConnectionToDataBase.GetConnectionAsync())
                {
                    if (conn == null || conn.State != ConnectionState.Open)
                    {
                        MessageBox.Show("No se pudo conectar a la base de datos");

                        return;
                    }

                    string query = $"UPDATE TOOLCRIB SET [{columnName}] = @value WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@value", newValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Id", id);

                        int rowAffected = await cmd.ExecuteNonQueryAsync();

                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Campo actualizado");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el registro para actualizar");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task UpdateStockAsync(int id)
        {
            try
            {
                using (SqlConnection conn = await ConnectionToDataBase.GetConnectionAsync())
                {
                    if (conn == null || conn.State != ConnectionState.Open)
                    {
                        return;
                    }

                    string query = "UPDATE TOOLCRIB SET existencia = existencia + 1 WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        int rowAffected = await cmd.ExecuteNonQueryAsync();

                        if (rowAffected > 0)
                        {
                            DataRow row = tablaCompleta.Rows.Find(id)!;

                            if (row != null)
                            {
                                row["existencia"] = Convert.ToInt32(row["existencia"]) + 1;

                                await ShowOnlyRegister(id);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar existencias: {ex.Message}");
            }
        }

        private async Task<bool> DeleteFromDataBaseAsync(int id)
        {
            try
            {
                using (SqlConnection conn = await ConnectionToDataBase.GetConnectionAsync())
                {
                    if (conn == null || conn.State != ConnectionState.Open)
                    {
                        MessageBox.Show("No se pudo conectar a la base de datos");
                        return false;
                    }

                    string query = "DELETE FROM TOOLCRIB WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int rowsAffected = await cmd.ExecuteNonQueryAsync();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el registro: {ex.Message}");

                return false;
            }
        }

        private async void btnArchivo_Click(object sender, EventArgs e)
        {
            using (openFileDialog1 = new OpenFileDialog() { Filter = "Excel Files|*.xls;*.xlsx" })
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog1.FileName;

                    var dataTable = ReadExcel(filePath);

                    if (dataTable != null && dataTable.Rows.Count > 0)
                    {
                        dtGdVwEntrada.DataSource = dataTable;

                        bool guardado = await SaveToDatabase(dataTable, "TOOLCRIB");

                        if (guardado)
                        {
                            MessageBox.Show("Datos guardados correctamente");
                        }
                        else
                        {
                            MessageBox.Show("El archivo no contiene datos validos");
                        }
                    }
                }
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtGdVwEntrada.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar");
                return;
            }

            DataGridViewRow selectedRow = dtGdVwEntrada.SelectedRows[0];

            if (!int.TryParse(selectedRow.Cells["Id"].Value?.ToString(), out int id))
            {
                MessageBox.Show("No se pudo obtener un ID valido");
                return;
            }

            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este registro?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool eliminando = await DeleteFromDataBaseAsync(id);

                if (eliminando)
                {
                    await LoadData();
                    MessageBox.Show("Registro eliminando correctamente");
                }
                else
                {
                    MessageBox.Show("Hubo un error al eliminar el registro");
                }
            }
        }

        private void btnNavigationNext_Click(object sender, EventArgs e)
        {
            int totalFilas = tablaCompleta.Rows.Count;
            int totalPages = (int)Math.Ceiling((double)totalFilas / filasPorPagina);

            if (paginaActual < totalPages)
            {
                ShowPage(paginaActual + 1);
            }
        }


        private void btnNavigationBack_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                ShowPage(paginaActual - 1);
            }
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            SALIDAS salidas = new SALIDAS();
            salidas.Show();
            this.Hide();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            REGISTRO_ENTRADAS registro = new REGISTRO_ENTRADAS();
            registro.Show();
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            currentMaterialId = null;
            currentSku = string.Empty;

            ShowPage(1);
        }
    }
}