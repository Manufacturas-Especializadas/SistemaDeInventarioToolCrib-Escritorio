namespace SistemaDeInventariosToolCrib
{
    partial class REGISTRO_ENTRADAS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTitle = new Panel();
            lbTitle = new Label();
            pictureBoxLogo = new PictureBox();
            tblPnlMain = new TableLayoutPanel();
            lbLinea = new Label();
            txtBxLinea = new TextBox();
            txtBxDescripcion = new TextBox();
            lbDescripcion = new Label();
            lbFecha = new Label();
            txtBxFecha = new TextBox();
            lbHora = new Label();
            lbModificado = new Label();
            txtBxHora = new TextBox();
            txtBxModificado = new TextBox();
            txtBxUnidadDeMedida = new TextBox();
            txtBxExistencia = new TextBox();
            lbUnidadDeMedida = new Label();
            lbExistencia = new Label();
            lbMinimo = new Label();
            lbMaximo = new Label();
            txtBxMinimo = new TextBox();
            txtBxMaximo = new TextBox();
            txtBxProveedor = new TextBox();
            lbProveedor = new Label();
            txtBxNoSerial = new TextBox();
            txtBxPrecio = new TextBox();
            lbNoSerial = new Label();
            lbPrecio = new Label();
            tblPnlButtons = new TableLayoutPanel();
            btnGuardar = new Button();
            btnCancelar = new Button();
            lbUbicacion = new Label();
            txtBxUbicacion = new TextBox();
            lbNumeroDeParte = new Label();
            txtBxNumeroDeParte = new TextBox();
            panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            tblPnlMain.SuspendLayout();
            tblPnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(94, 167, 189);
            panelTitle.Controls.Add(lbTitle);
            panelTitle.Controls.Add(pictureBoxLogo);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Margin = new Padding(4, 3, 4, 3);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1363, 102);
            panelTitle.TabIndex = 1;
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.None;
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Arial", 25F);
            lbTitle.ForeColor = SystemColors.ControlLightLight;
            lbTitle.ImeMode = ImeMode.NoControl;
            lbTitle.Location = new Point(442, 18);
            lbTitle.Margin = new Padding(4, 0, 4, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(608, 57);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "TOOL CRIB - ENTRADAS";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Left;
            pictureBoxLogo.Image = Properties.Resources.logomesa;
            pictureBoxLogo.ImeMode = ImeMode.NoControl;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Margin = new Padding(4, 3, 4, 3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(181, 102);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // tblPnlMain
            // 
            tblPnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblPnlMain.ColumnCount = 4;
            tblPnlMain.ColumnStyles.Add(new ColumnStyle());
            tblPnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPnlMain.ColumnStyles.Add(new ColumnStyle());
            tblPnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPnlMain.Controls.Add(lbLinea, 0, 0);
            tblPnlMain.Controls.Add(txtBxLinea, 1, 0);
            tblPnlMain.Controls.Add(txtBxDescripcion, 3, 0);
            tblPnlMain.Controls.Add(lbDescripcion, 2, 0);
            tblPnlMain.Controls.Add(lbFecha, 2, 1);
            tblPnlMain.Controls.Add(txtBxFecha, 3, 1);
            tblPnlMain.Controls.Add(lbHora, 0, 2);
            tblPnlMain.Controls.Add(lbModificado, 2, 2);
            tblPnlMain.Controls.Add(txtBxHora, 1, 2);
            tblPnlMain.Controls.Add(txtBxModificado, 3, 2);
            tblPnlMain.Controls.Add(txtBxUnidadDeMedida, 1, 3);
            tblPnlMain.Controls.Add(txtBxExistencia, 3, 3);
            tblPnlMain.Controls.Add(lbUnidadDeMedida, 0, 3);
            tblPnlMain.Controls.Add(lbExistencia, 2, 3);
            tblPnlMain.Controls.Add(lbMinimo, 0, 4);
            tblPnlMain.Controls.Add(lbMaximo, 2, 4);
            tblPnlMain.Controls.Add(txtBxMinimo, 1, 4);
            tblPnlMain.Controls.Add(txtBxMaximo, 3, 4);
            tblPnlMain.Controls.Add(txtBxProveedor, 3, 5);
            tblPnlMain.Controls.Add(lbProveedor, 2, 5);
            tblPnlMain.Controls.Add(txtBxNoSerial, 1, 6);
            tblPnlMain.Controls.Add(txtBxPrecio, 3, 6);
            tblPnlMain.Controls.Add(lbNoSerial, 0, 6);
            tblPnlMain.Controls.Add(lbPrecio, 2, 6);
            tblPnlMain.Controls.Add(lbNumeroDeParte, 0, 1);
            tblPnlMain.Controls.Add(txtBxNumeroDeParte, 1, 1);
            tblPnlMain.Controls.Add(lbUbicacion, 0, 5);
            tblPnlMain.Controls.Add(txtBxUbicacion, 1, 5);
            tblPnlMain.Controls.Add(tblPnlButtons, 3, 7);
            tblPnlMain.Location = new Point(13, 120);
            tblPnlMain.Name = "tblPnlMain";
            tblPnlMain.Padding = new Padding(2);
            tblPnlMain.RowCount = 8;
            tblPnlMain.RowStyles.Add(new RowStyle());
            tblPnlMain.RowStyles.Add(new RowStyle());
            tblPnlMain.RowStyles.Add(new RowStyle());
            tblPnlMain.RowStyles.Add(new RowStyle());
            tblPnlMain.RowStyles.Add(new RowStyle());
            tblPnlMain.RowStyles.Add(new RowStyle());
            tblPnlMain.RowStyles.Add(new RowStyle());
            tblPnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPnlMain.Size = new Size(1339, 344);
            tblPnlMain.TabIndex = 2;
            // 
            // lbLinea
            // 
            lbLinea.Anchor = AnchorStyles.Left;
            lbLinea.AutoSize = true;
            lbLinea.Font = new Font("Arial", 12F);
            lbLinea.Location = new Point(5, 9);
            lbLinea.Name = "lbLinea";
            lbLinea.Size = new Size(77, 27);
            lbLinea.TabIndex = 0;
            lbLinea.Text = "Linea:";
            // 
            // txtBxLinea
            // 
            txtBxLinea.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBxLinea.Font = new Font("Arial", 12F);
            txtBxLinea.Location = new Point(227, 5);
            txtBxLinea.Name = "txtBxLinea";
            txtBxLinea.Size = new Size(475, 35);
            txtBxLinea.TabIndex = 1;
            // 
            // txtBxDescripcion
            // 
            txtBxDescripcion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBxDescripcion.Font = new Font("Arial", 12F);
            txtBxDescripcion.Location = new Point(858, 5);
            txtBxDescripcion.Name = "txtBxDescripcion";
            txtBxDescripcion.Size = new Size(476, 35);
            txtBxDescripcion.TabIndex = 2;
            // 
            // lbDescripcion
            // 
            lbDescripcion.Anchor = AnchorStyles.Left;
            lbDescripcion.AutoSize = true;
            lbDescripcion.Font = new Font("Arial", 12F);
            lbDescripcion.Location = new Point(708, 9);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(144, 27);
            lbDescripcion.TabIndex = 3;
            lbDescripcion.Text = "Descripción:";
            // 
            // lbFecha
            // 
            lbFecha.Anchor = AnchorStyles.Left;
            lbFecha.AutoSize = true;
            lbFecha.Font = new Font("Arial", 12F);
            lbFecha.Location = new Point(708, 50);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(86, 27);
            lbFecha.TabIndex = 6;
            lbFecha.Text = "Fecha:";
            // 
            // txtBxFecha
            // 
            txtBxFecha.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBxFecha.Font = new Font("Arial", 12F);
            txtBxFecha.Location = new Point(858, 46);
            txtBxFecha.Name = "txtBxFecha";
            txtBxFecha.Size = new Size(476, 35);
            txtBxFecha.TabIndex = 7;
            // 
            // lbHora
            // 
            lbHora.Anchor = AnchorStyles.Left;
            lbHora.AutoSize = true;
            lbHora.Font = new Font("Arial", 12F);
            lbHora.Location = new Point(5, 91);
            lbHora.Name = "lbHora";
            lbHora.Size = new Size(70, 27);
            lbHora.TabIndex = 8;
            lbHora.Text = "Hora:";
            // 
            // lbModificado
            // 
            lbModificado.Anchor = AnchorStyles.Left;
            lbModificado.AutoSize = true;
            lbModificado.Font = new Font("Arial", 12F);
            lbModificado.Location = new Point(708, 91);
            lbModificado.Name = "lbModificado";
            lbModificado.Size = new Size(134, 27);
            lbModificado.TabIndex = 9;
            lbModificado.Text = "Modificado:";
            // 
            // txtBxHora
            // 
            txtBxHora.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBxHora.Font = new Font("Arial", 12F);
            txtBxHora.Location = new Point(227, 87);
            txtBxHora.Name = "txtBxHora";
            txtBxHora.Size = new Size(475, 35);
            txtBxHora.TabIndex = 10;
            // 
            // txtBxModificado
            // 
            txtBxModificado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBxModificado.Font = new Font("Arial", 12F);
            txtBxModificado.Location = new Point(858, 87);
            txtBxModificado.Name = "txtBxModificado";
            txtBxModificado.Size = new Size(476, 35);
            txtBxModificado.TabIndex = 11;
            // 
            // txtBxUnidadDeMedida
            // 
            txtBxUnidadDeMedida.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBxUnidadDeMedida.Font = new Font("Arial", 12F);
            txtBxUnidadDeMedida.Location = new Point(227, 128);
            txtBxUnidadDeMedida.Name = "txtBxUnidadDeMedida";
            txtBxUnidadDeMedida.Size = new Size(475, 35);
            txtBxUnidadDeMedida.TabIndex = 12;
            // 
            // txtBxExistencia
            // 
            txtBxExistencia.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBxExistencia.Font = new Font("Arial", 12F);
            txtBxExistencia.Location = new Point(858, 128);
            txtBxExistencia.Name = "txtBxExistencia";
            txtBxExistencia.Size = new Size(476, 35);
            txtBxExistencia.TabIndex = 13;
            // 
            // lbUnidadDeMedida
            // 
            lbUnidadDeMedida.Anchor = AnchorStyles.Left;
            lbUnidadDeMedida.AutoSize = true;
            lbUnidadDeMedida.Font = new Font("Arial", 12F);
            lbUnidadDeMedida.Location = new Point(5, 132);
            lbUnidadDeMedida.Name = "lbUnidadDeMedida";
            lbUnidadDeMedida.Size = new Size(216, 27);
            lbUnidadDeMedida.TabIndex = 14;
            lbUnidadDeMedida.Text = "Unidad de medida:";
            // 
            // lbExistencia
            // 
            lbExistencia.Anchor = AnchorStyles.Left;
            lbExistencia.AutoSize = true;
            lbExistencia.Font = new Font("Arial", 12F);
            lbExistencia.Location = new Point(708, 132);
            lbExistencia.Name = "lbExistencia";
            lbExistencia.Size = new Size(127, 27);
            lbExistencia.TabIndex = 15;
            lbExistencia.Text = "Existencia:";
            // 
            // lbMinimo
            // 
            lbMinimo.Anchor = AnchorStyles.Left;
            lbMinimo.AutoSize = true;
            lbMinimo.Font = new Font("Arial", 12F);
            lbMinimo.Location = new Point(5, 173);
            lbMinimo.Name = "lbMinimo";
            lbMinimo.Size = new Size(95, 27);
            lbMinimo.TabIndex = 16;
            lbMinimo.Text = "Minimo:";
            // 
            // lbMaximo
            // 
            lbMaximo.Anchor = AnchorStyles.Left;
            lbMaximo.AutoSize = true;
            lbMaximo.Font = new Font("Arial", 12F);
            lbMaximo.Location = new Point(708, 173);
            lbMaximo.Name = "lbMaximo";
            lbMaximo.Size = new Size(100, 27);
            lbMaximo.TabIndex = 17;
            lbMaximo.Text = "Maximo:";
            // 
            // txtBxMinimo
            // 
            txtBxMinimo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBxMinimo.Font = new Font("Arial", 12F);
            txtBxMinimo.Location = new Point(227, 169);
            txtBxMinimo.Name = "txtBxMinimo";
            txtBxMinimo.Size = new Size(475, 35);
            txtBxMinimo.TabIndex = 18;
            // 
            // txtBxMaximo
            // 
            txtBxMaximo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBxMaximo.Font = new Font("Arial", 12F);
            txtBxMaximo.Location = new Point(858, 169);
            txtBxMaximo.Name = "txtBxMaximo";
            txtBxMaximo.Size = new Size(476, 35);
            txtBxMaximo.TabIndex = 19;
            // 
            // txtBxProveedor
            // 
            txtBxProveedor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBxProveedor.Font = new Font("Arial", 12F);
            txtBxProveedor.Location = new Point(858, 210);
            txtBxProveedor.Name = "txtBxProveedor";
            txtBxProveedor.Size = new Size(476, 35);
            txtBxProveedor.TabIndex = 21;
            // 
            // lbProveedor
            // 
            lbProveedor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbProveedor.AutoSize = true;
            lbProveedor.Font = new Font("Arial", 12F);
            lbProveedor.Location = new Point(708, 214);
            lbProveedor.Name = "lbProveedor";
            lbProveedor.Size = new Size(144, 27);
            lbProveedor.TabIndex = 23;
            lbProveedor.Text = "Proveedor:";
            // 
            // txtBxNoSerial
            // 
            txtBxNoSerial.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBxNoSerial.Font = new Font("Arial", 12F);
            txtBxNoSerial.Location = new Point(227, 251);
            txtBxNoSerial.Name = "txtBxNoSerial";
            txtBxNoSerial.Size = new Size(475, 35);
            txtBxNoSerial.TabIndex = 24;
            // 
            // txtBxPrecio
            // 
            txtBxPrecio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBxPrecio.Font = new Font("Arial", 12F);
            txtBxPrecio.Location = new Point(858, 251);
            txtBxPrecio.Name = "txtBxPrecio";
            txtBxPrecio.Size = new Size(476, 35);
            txtBxPrecio.TabIndex = 25;
            // 
            // lbNoSerial
            // 
            lbNoSerial.Anchor = AnchorStyles.Left;
            lbNoSerial.AutoSize = true;
            lbNoSerial.Font = new Font("Arial", 12F);
            lbNoSerial.Location = new Point(5, 255);
            lbNoSerial.Name = "lbNoSerial";
            lbNoSerial.Size = new Size(117, 27);
            lbNoSerial.TabIndex = 26;
            lbNoSerial.Text = "No.Serial:";
            // 
            // lbPrecio
            // 
            lbPrecio.Anchor = AnchorStyles.Left;
            lbPrecio.AutoSize = true;
            lbPrecio.Font = new Font("Arial", 12F);
            lbPrecio.Location = new Point(708, 255);
            lbPrecio.Name = "lbPrecio";
            lbPrecio.Size = new Size(86, 27);
            lbPrecio.TabIndex = 27;
            lbPrecio.Text = "Precio:";
            // 
            // tblPnlButtons
            // 
            tblPnlButtons.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tblPnlButtons.ColumnCount = 2;
            tblPnlButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPnlButtons.ColumnStyles.Add(new ColumnStyle());
            tblPnlButtons.Controls.Add(btnGuardar, 0, 0);
            tblPnlButtons.Controls.Add(btnCancelar, 1, 0);
            tblPnlButtons.Location = new Point(858, 292);
            tblPnlButtons.Name = "tblPnlButtons";
            tblPnlButtons.RowCount = 1;
            tblPnlButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPnlButtons.Size = new Size(476, 47);
            tblPnlButtons.TabIndex = 28;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Right;
            btnGuardar.BackColor = Color.LightSteelBlue;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Arial", 12F);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(173, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(147, 41);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Right;
            btnCancelar.BackColor = Color.LightSteelBlue;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 12F);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(326, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(147, 41);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lbUbicacion
            // 
            lbUbicacion.Anchor = AnchorStyles.Left;
            lbUbicacion.AutoSize = true;
            lbUbicacion.Font = new Font("Arial", 12F);
            lbUbicacion.Location = new Point(5, 214);
            lbUbicacion.Name = "lbUbicacion";
            lbUbicacion.Size = new Size(124, 27);
            lbUbicacion.TabIndex = 4;
            lbUbicacion.Text = "Ubicación:";
            // 
            // txtBxUbicacion
            // 
            txtBxUbicacion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBxUbicacion.Font = new Font("Arial", 12F);
            txtBxUbicacion.Location = new Point(227, 210);
            txtBxUbicacion.Name = "txtBxUbicacion";
            txtBxUbicacion.Size = new Size(475, 35);
            txtBxUbicacion.TabIndex = 5;
            // 
            // lbNumeroDeParte
            // 
            lbNumeroDeParte.Anchor = AnchorStyles.Left;
            lbNumeroDeParte.AutoSize = true;
            lbNumeroDeParte.Font = new Font("Arial", 12F);
            lbNumeroDeParte.Location = new Point(5, 50);
            lbNumeroDeParte.Name = "lbNumeroDeParte";
            lbNumeroDeParte.Size = new Size(200, 27);
            lbNumeroDeParte.TabIndex = 29;
            lbNumeroDeParte.Text = "Número de parte:";
            // 
            // txtBxNumeroDeParte
            // 
            txtBxNumeroDeParte.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBxNumeroDeParte.Font = new Font("Arial", 12F);
            txtBxNumeroDeParte.Location = new Point(227, 46);
            txtBxNumeroDeParte.Name = "txtBxNumeroDeParte";
            txtBxNumeroDeParte.Size = new Size(475, 35);
            txtBxNumeroDeParte.TabIndex = 30;
            // 
            // REGISTRO_ENTRADAS
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1363, 669);
            Controls.Add(tblPnlMain);
            Controls.Add(panelTitle);
            Name = "REGISTRO_ENTRADAS";
            Text = "REGISTRO_ENTRADAS";
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            tblPnlMain.ResumeLayout(false);
            tblPnlMain.PerformLayout();
            tblPnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitle;
        private Label lbTitle;
        private PictureBox pictureBoxLogo;
        private TableLayoutPanel tblPnlMain;
        private Label lbLinea;
        private TextBox txtBxLinea;
        private TextBox txtBxDescripcion;
        private Label lbDescripcion;
        private Label lbUbicacion;
        private TextBox txtBxUbicacion;
        private Label lbFecha;
        private TextBox txtBxFecha;
        private Label lbHora;
        private Label lbModificado;
        private TextBox txtBxHora;
        private TextBox txtBxModificado;
        private TextBox txtBxUnidadDeMedida;
        private TextBox txtBxExistencia;
        private Label lbExistencia;
        private Label lbUnidadDeMedida;
        private Label lbMinimo;
        private Label lbMaximo;
        private TextBox txtBxMinimo;
        private TextBox txtBxMaximo;
        private TextBox txtBxProveedor;
        private Label lbProveedor;
        private TextBox txtBxNoSerial;
        private TextBox txtBxPrecio;
        private Label lbNoSerial;
        private Label lbPrecio;
        private TableLayoutPanel tblPnlButtons;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label lbNumeroDeParte;
        private TextBox txtBxNumeroDeParte;
    }
}