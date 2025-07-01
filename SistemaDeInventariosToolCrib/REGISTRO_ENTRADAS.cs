using Microsoft.Data.SqlClient;
using SistemaDeInventariosToolCrib.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeInventariosToolCrib
{
    public partial class REGISTRO_ENTRADAS : Form
    {
        public REGISTRO_ENTRADAS()
        {
            InitializeComponent();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = await ConnectionToDataBase.GetConnectionAsync())
                {
                    if (conn == null || conn.State != ConnectionState.Open)
                    {
                        MessageBox.Show("No se pudo conectar a la base de datos.");
                        return;
                    }

                    string query = @"
                        INSERT INTO TOOLCRIB 
                            (ramos, santa, aluminio, cobre, linea, comentarios, categoria, sku, material, ubicacion, fecha, hora, modificado, unidadDeMedida, existencia, minimo, maximo, proveedor, numeroDeSerie, costoUnitario) 
                        VALUES 
                            (@ramos, @santa, @aluminio, @cobre, @linea, @comentarios, @categoria, @sku, @material, @ubicacion, @fecha, @hora, @modificado, @unidadDeMedida, @existencia, @minimo, @maximo, @proveedor, @numeroDeSerie, @costoUnitario)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {                        
                        cmd.Parameters.AddWithValue("@ramos", txtBxRamos.Text.Trim());
                        cmd.Parameters.AddWithValue("@santa", txtBxSanta.Text.Trim());
                        cmd.Parameters.AddWithValue("@aluminio", txtBxAluminio.Text.Trim());
                        cmd.Parameters.AddWithValue("@cobre", txtBxCobre.Text.Trim());
                        cmd.Parameters.AddWithValue("@linea", txtBxLinea.Text.Trim());
                        cmd.Parameters.AddWithValue("@comentarios", txtBxComentarios.Text.Trim());
                        cmd.Parameters.AddWithValue("@categoria", txtBxCategoria.Text.Trim());
                        cmd.Parameters.AddWithValue("@sku", txtBxSku.Text.Trim());
                        cmd.Parameters.AddWithValue("@ubicacion", txtBxUbicacion.Text.Trim());
                        cmd.Parameters.AddWithValue("@fecha", txtBxFecha.Text.Trim());
                        cmd.Parameters.AddWithValue("@hora", txtBxHora.Text.Trim());
                        cmd.Parameters.AddWithValue("@modificado", txtBxModificado.Text.Trim());
                        cmd.Parameters.AddWithValue("@unidadDeMedida", txtBxUnidadDeMedida.Text.Trim());
                        cmd.Parameters.AddWithValue("@existencia", txtBxExistencia.Text.Trim());
                        cmd.Parameters.AddWithValue("@minimo", txtBxMinimo.Text.Trim());
                        cmd.Parameters.AddWithValue("@maximo", txtBxMaterial.Text.Trim());
                        cmd.Parameters.AddWithValue("proveedor", txtBxProveedor.Text.Trim());
                        cmd.Parameters.AddWithValue("@numeroDeSerie", txtBxNumeroDeSerie.Text.Trim());
                        cmd.Parameters.AddWithValue("@costoUnitario", txtBxCostoUnitario.Text.Trim());
                        cmd.Parameters.AddWithValue("@material", txtBxMaterial.Text.Trim());

                        await cmd.ExecuteNonQueryAsync();

                        MessageBox.Show("Datos guardados correctamente");
                        ENTRADAS entrada = new ENTRADAS();
                        entrada.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ENTRADAS entrada = new ENTRADAS();
            entrada.Show();
            this.Hide();
        }
    }
}
