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
        private string currentPartNumber = string.Empty;

        public ENTRADAS()
        {
            InitializeComponent();
        }

        private async void ENTRADAS_Load(object sender, EventArgs e)
        {
            await CargarDatos();
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

                if (!string.IsNullOrEmpty(currentPartNumber) && barcode == currentPartNumber)
                {
                    await UpdateStockAsync(currentMaterialId!.Value);
                }
                else
                {
                    bool found = await SearchMaterialByPartNumberAsync(barcode);

                    if (found)
                    {
                        MostrarSoloRegistro(currentMaterialId!.Value);
                    }
                    else
                    {
                        MessageBox.Show("Número de parte no encontrado");
                        txtBxEntrada.Clear();
                    }
                }
            }
        }

        private async Task<bool> SearchMaterialByPartNumberAsync(string partNumber)
        {
            try
            {
                using (SqlConnection conn = await ConnectionToDataBase.GetConnectionAsync())
                {
                    if (conn == null || conn.State != ConnectionState.Open)
                    {
                        return false;
                    }

                    string query = "SELECT Id FROM TOOLCRIB WHERE numeroDeParte = @partNumber";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@partNumber", partNumber);

                        var result = await cmd.ExecuteScalarAsync();

                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            currentMaterialId = id;
                            currentPartNumber = partNumber;
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

        private async Task CargarDatos()
        {
            string query = @"
                            SELECT
                                Id, numeroDeParte, existencias, minimo, maximo, 
                                linea, descripcion, ubicacion,
                                fecha, hora, modificado,
                                unidadDeMedida, proveedor,
                                noSerial, precio
                            FROM TOOLCRIB";

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

            MostrarPagina(paginaActual);
        }

        private void MostrarPagina(int pagina)
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

            paginaTabla.Columns["linea"]!.ColumnName = "Linea";
            paginaTabla.Columns["numeroDeParte"]!.ColumnName = "Numero de parte";
            paginaTabla.Columns["descripcion"]!.ColumnName = "Descripcion";
            paginaTabla.Columns["ubicacion"]!.ColumnName = "Ubicacion";
            paginaTabla.Columns["fecha"]!.ColumnName = "Fecha";
            paginaTabla.Columns["hora"]!.ColumnName = "Hora";
            paginaTabla.Columns["modificado"]!.ColumnName = "Modificado";
            paginaTabla.Columns["unidadDeMedida"]!.ColumnName = "Unidad de medida";
            paginaTabla.Columns["existencias"]!.ColumnName = "Existencias";
            paginaTabla.Columns["minimo"]!.ColumnName = "Minimo";
            paginaTabla.Columns["maximo"]!.ColumnName = "Máximo";
            paginaTabla.Columns["proveedor"]!.ColumnName = "Proveedor";
            paginaTabla.Columns["noSerial"]!.ColumnName = "No.Serial";
            paginaTabla.Columns["precio"]!.ColumnName = "Precio";

            dtGdVwEntrada.DataSource = paginaTabla;

            //dtGdVwEntrada.RowHeadersVisible = false;

            dtGdVwEntrada.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dtGdVwEntrada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dtGdVwEntrada.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            lbPagination.Text = $"Página {paginaActual} de {totalPages}";
        }

        private void MostrarSoloRegistro(int id)
        {
            if (tablaCompleta.Rows.Count == 0)
            {
                dtGdVwEntrada.DataSource = null;
                lbPagination.Text = "Página 1 de 1";
                return;
            }

            DataTable filteredTable = tablaCompleta.Clone();
            DataRow[] rows = tablaCompleta.Select($"Id = {id}");

            if (rows.Length > 0)
            {
                foreach (DataRow row in rows)
                {
                    filteredTable.ImportRow(row);
                }
            }

            filteredTable.Columns["linea"]!.ColumnName = "Linea";
            filteredTable.Columns["numeroDeParte"]!.ColumnName = "Numero de parte";
            filteredTable.Columns["descripcion"]!.ColumnName = "Descripcion";
            filteredTable.Columns["ubicacion"]!.ColumnName = "Ubicacion";
            filteredTable.Columns["fecha"]!.ColumnName = "Fecha";
            filteredTable.Columns["hora"]!.ColumnName = "Hora";
            filteredTable.Columns["modificado"]!.ColumnName = "Modificado";
            filteredTable.Columns["unidadDeMedida"]!.ColumnName = "Unidad de medida";
            filteredTable.Columns["existencias"]!.ColumnName = "Existencias";
            filteredTable.Columns["minimo"]!.ColumnName = "Minimo";
            filteredTable.Columns["maximo"]!.ColumnName = "Maximo";
            filteredTable.Columns["proveedor"]!.ColumnName = "Proveedor";
            filteredTable.Columns["noSerial"]!.ColumnName = "No.Serial";
            filteredTable.Columns["precio"]!.ColumnName = "Precio";

            dtGdVwEntrada.DataSource = filteredTable;
            lbPagination.Text = "Página 1 de 1";
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
                        case "descripcion":
                            ValidateAndCleanStringColumn(row, "Descripcion", 255);
                            break;
                        case "linea":
                            ValidateAndCleanStringColumn(row, "Linea", 100);
                            break;
                        case "ubicacion":
                            ValidateAndCleanStringColumn(row, "Ubicacion", 100);
                            break;
                        case "modificado":
                            ValidateAndCleanStringColumn(row, "Modificado", 50);
                            break;
                        case "unidaddemedida":
                            ValidateAndCleanStringColumn(row, "UnidadDeMedida", 255);
                            break;
                        case "proveedor":
                            ValidateAndCleanStringColumn(row, "Proveedor", 100);
                            break;
                        case "noserial":
                            ValidateAndCleanStringColumn(row, "NoSerial", 50);
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

                    bulkCopy.ColumnMappings.Add("LiNEA", "linea");
                    bulkCopy.ColumnMappings.Add("NUMERO DE PARTE", "numeroDeParte");
                    bulkCopy.ColumnMappings.Add("Descripcion", "descripcion");
                    bulkCopy.ColumnMappings.Add("Ubicacion", "ubicacion");
                    bulkCopy.ColumnMappings.Add("FECHA", "fecha");
                    bulkCopy.ColumnMappings.Add("HORA", "hora");
                    bulkCopy.ColumnMappings.Add("MODIFICADO", "modificado");
                    bulkCopy.ColumnMappings.Add("UNIDADDEMEDIDA", "unidadDeMedida");
                    bulkCopy.ColumnMappings.Add("existencia", "existencias");
                    bulkCopy.ColumnMappings.Add("MINIMO", "minimo");
                    bulkCopy.ColumnMappings.Add("MAXIMO", "maximo");
                    bulkCopy.ColumnMappings.Add("PROVEEDOR", "proveedor");
                    bulkCopy.ColumnMappings.Add("NOSERIAL", "noSerial");
                    bulkCopy.ColumnMappings.Add("PRECIOS", "precio");

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

                    string query = "UPDATE TOOLCRIB SET existencias = existencias + 1 WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        int rowAffected = await cmd.ExecuteNonQueryAsync();

                        if (rowAffected > 0)
                        {
                            DataRow row = tablaCompleta.Rows.Find(id)!;

                            if (row != null)
                            {
                                row["existencias"] = Convert.ToInt32(row["existencias"]) + 1;

                                MostrarSoloRegistro(id);
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
                    await CargarDatos();
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
                MostrarPagina(paginaActual + 1);
            }
        }


        private void btnNavigationBack_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                MostrarPagina(paginaActual - 1);
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
            currentPartNumber = string.Empty;

            MostrarPagina(1);
        }
    }
}