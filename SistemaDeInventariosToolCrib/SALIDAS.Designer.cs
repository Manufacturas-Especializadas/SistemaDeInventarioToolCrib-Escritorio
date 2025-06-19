namespace SistemaDeInventariosToolCrib
{
    partial class SALIDAS
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelTitle = new Panel();
            labelTitle = new Label();
            pictureBoxLogo = new PictureBox();
            tblPnlMain = new TableLayoutPanel();
            tblPnlControl = new TableLayoutPanel();
            btnEliminar = new Button();
            lbSalida = new Label();
            txtBxSalida = new TextBox();
            btnEntrada = new Button();
            btnNuevo = new Button();
            dtGdVwSalida = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnNavigationBack = new Button();
            btnNavigationNext = new Button();
            lbPagination = new Label();
            btnReset = new Button();
            panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            tblPnlMain.SuspendLayout();
            tblPnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGdVwSalida).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(94, 167, 189);
            panelTitle.Controls.Add(labelTitle);
            panelTitle.Controls.Add(pictureBoxLogo);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1410, 150);
            panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Arial", 24F);
            labelTitle.ForeColor = SystemColors.ControlLightLight;
            labelTitle.Location = new Point(509, 45);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(521, 55);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "TOOL CRIB - SALIDAS";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Left;
            pictureBoxLogo.Image = Properties.Resources.logomesa;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(224, 150);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // tblPnlMain
            // 
            tblPnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblPnlMain.ColumnCount = 1;
            tblPnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPnlMain.Controls.Add(tblPnlControl, 0, 0);
            tblPnlMain.Controls.Add(dtGdVwSalida, 0, 1);
            tblPnlMain.Controls.Add(tableLayoutPanel1, 0, 2);
            tblPnlMain.Location = new Point(12, 156);
            tblPnlMain.Name = "tblPnlMain";
            tblPnlMain.RowCount = 3;
            tblPnlMain.RowStyles.Add(new RowStyle());
            tblPnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tblPnlMain.Size = new Size(1386, 473);
            tblPnlMain.TabIndex = 2;
            // 
            // tblPnlControl
            // 
            tblPnlControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblPnlControl.ColumnCount = 6;
            tblPnlControl.ColumnStyles.Add(new ColumnStyle());
            tblPnlControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPnlControl.ColumnStyles.Add(new ColumnStyle());
            tblPnlControl.ColumnStyles.Add(new ColumnStyle());
            tblPnlControl.ColumnStyles.Add(new ColumnStyle());
            tblPnlControl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 144F));
            tblPnlControl.Controls.Add(btnEliminar, 5, 0);
            tblPnlControl.Controls.Add(lbSalida, 0, 0);
            tblPnlControl.Controls.Add(txtBxSalida, 1, 0);
            tblPnlControl.Controls.Add(btnEntrada, 2, 0);
            tblPnlControl.Controls.Add(btnNuevo, 4, 0);
            tblPnlControl.Location = new Point(3, 3);
            tblPnlControl.Name = "tblPnlControl";
            tblPnlControl.RowCount = 1;
            tblPnlControl.RowStyles.Add(new RowStyle());
            tblPnlControl.Size = new Size(1380, 67);
            tblPnlControl.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Left;
            btnEliminar.BackColor = Color.LightSteelBlue;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Arial", 12F);
            btnEliminar.ImeMode = ImeMode.NoControl;
            btnEliminar.Location = new Point(1239, 16);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(138, 34);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lbSalida
            // 
            lbSalida.Anchor = AnchorStyles.Left;
            lbSalida.AutoSize = true;
            lbSalida.Font = new Font("Arial", 12F);
            lbSalida.ImeMode = ImeMode.NoControl;
            lbSalida.Location = new Point(3, 20);
            lbSalida.Name = "lbSalida";
            lbSalida.Size = new Size(101, 27);
            lbSalida.TabIndex = 0;
            lbSalida.Text = "SALIDA:";
            // 
            // txtBxSalida
            // 
            txtBxSalida.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBxSalida.Font = new Font("Arial", 12F);
            txtBxSalida.Location = new Point(110, 16);
            txtBxSalida.Name = "txtBxSalida";
            txtBxSalida.Size = new Size(845, 35);
            txtBxSalida.TabIndex = 1;
            txtBxSalida.KeyPress += txtBxSalida_KeyPress;
            // 
            // btnEntrada
            // 
            btnEntrada.Anchor = AnchorStyles.Left;
            btnEntrada.BackColor = Color.LightSteelBlue;
            btnEntrada.Cursor = Cursors.Hand;
            btnEntrada.FlatStyle = FlatStyle.Flat;
            btnEntrada.Font = new Font("Arial", 12F);
            btnEntrada.ImeMode = ImeMode.NoControl;
            btnEntrada.Location = new Point(961, 16);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(140, 34);
            btnEntrada.TabIndex = 2;
            btnEntrada.Text = "ENTRADAS";
            btnEntrada.UseVisualStyleBackColor = false;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Left;
            btnNuevo.BackColor = Color.LightSteelBlue;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Arial", 12F);
            btnNuevo.ImeMode = ImeMode.NoControl;
            btnNuevo.Location = new Point(1107, 16);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(126, 34);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dtGdVwSalida
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(221, 222, 223);
            dataGridViewCellStyle1.Font = new Font("Arial", 12F);
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSteelBlue;
            dtGdVwSalida.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtGdVwSalida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtGdVwSalida.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtGdVwSalida.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial", 12F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(94, 167, 189);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtGdVwSalida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtGdVwSalida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGdVwSalida.Location = new Point(3, 76);
            dtGdVwSalida.Name = "dtGdVwSalida";
            dtGdVwSalida.RowHeadersWidth = 62;
            dtGdVwSalida.Size = new Size(1380, 343);
            dtGdVwSalida.TabIndex = 1;
            dtGdVwSalida.CellEndEdit += dtGdVwSalida_CellEndEdit;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(btnNavigationBack, 0, 0);
            tableLayoutPanel1.Controls.Add(btnNavigationNext, 1, 0);
            tableLayoutPanel1.Controls.Add(lbPagination, 2, 0);
            tableLayoutPanel1.Controls.Add(btnReset, 3, 0);
            tableLayoutPanel1.Location = new Point(3, 425);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1341, 45);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btnNavigationBack
            // 
            btnNavigationBack.Anchor = AnchorStyles.Left;
            btnNavigationBack.BackColor = Color.LightSteelBlue;
            btnNavigationBack.Cursor = Cursors.Hand;
            btnNavigationBack.FlatStyle = FlatStyle.Flat;
            btnNavigationBack.Font = new Font("Arial", 10F);
            btnNavigationBack.ForeColor = Color.Black;
            btnNavigationBack.ImeMode = ImeMode.NoControl;
            btnNavigationBack.Location = new Point(3, 5);
            btnNavigationBack.Name = "btnNavigationBack";
            btnNavigationBack.Size = new Size(104, 34);
            btnNavigationBack.TabIndex = 0;
            btnNavigationBack.Text = "<<";
            btnNavigationBack.UseVisualStyleBackColor = false;
            btnNavigationBack.Click += btnNavigationBack_Click;
            // 
            // btnNavigationNext
            // 
            btnNavigationNext.Anchor = AnchorStyles.Left;
            btnNavigationNext.BackColor = Color.LightSteelBlue;
            btnNavigationNext.Cursor = Cursors.Hand;
            btnNavigationNext.FlatStyle = FlatStyle.Flat;
            btnNavigationNext.Font = new Font("Arial", 10F);
            btnNavigationNext.ImeMode = ImeMode.NoControl;
            btnNavigationNext.Location = new Point(113, 5);
            btnNavigationNext.Name = "btnNavigationNext";
            btnNavigationNext.Size = new Size(104, 35);
            btnNavigationNext.TabIndex = 1;
            btnNavigationNext.Text = ">>";
            btnNavigationNext.UseVisualStyleBackColor = false;
            btnNavigationNext.Click += btnNavigationNext_Click;
            // 
            // lbPagination
            // 
            lbPagination.Anchor = AnchorStyles.Left;
            lbPagination.AutoSize = true;
            lbPagination.Font = new Font("Arial", 10F);
            lbPagination.ImeMode = ImeMode.NoControl;
            lbPagination.Location = new Point(223, 11);
            lbPagination.Name = "lbPagination";
            lbPagination.Size = new Size(70, 23);
            lbPagination.TabIndex = 2;
            lbPagination.Text = "Pagina";
            lbPagination.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Right;
            btnReset.BackColor = Color.LightSteelBlue;
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Arial", 10F);
            btnReset.Location = new Point(1189, 5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(149, 34);
            btnReset.TabIndex = 3;
            btnReset.Text = "RESETEAR";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // SALIDAS
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1410, 641);
            Controls.Add(tblPnlMain);
            Controls.Add(panelTitle);
            Name = "SALIDAS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SALIDAS";
            Load += SALIDAS_Load;
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            tblPnlMain.ResumeLayout(false);
            tblPnlControl.ResumeLayout(false);
            tblPnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGdVwSalida).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitle;
        private PictureBox pictureBoxLogo;
        private Label labelTitle;
        private TableLayoutPanel tblPnlMain;
        private TableLayoutPanel tblPnlControl;
        private Button btnEliminar;
        private Label lbSalida;
        private TextBox txtBxSalida;
        private Button btnEntrada;
        private Button btnNuevo;
        private DataGridView dtGdVwSalida;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnNavigationBack;
        private Button btnNavigationNext;
        private Label lbPagination;
        private Button btnReset;
    }
}