namespace SistemaDeInventariosToolCrib
{
    partial class ENTRADAS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ENTRADAS));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelTitle = new Panel();
            lbTitle = new Label();
            pictureBoxLogo = new PictureBox();
            tblPnlMain = new TableLayoutPanel();
            tblPnlControl = new TableLayoutPanel();
            btnEliminar = new Button();
            lbEntrada = new Label();
            txtBxEntrada = new TextBox();
            btnSalida = new Button();
            btnArchivo = new Button();
            btnNuevo = new Button();
            dtGdVwEntrada = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnNavigationBack = new Button();
            btnNavigationNext = new Button();
            lbPagination = new Label();
            btnReset = new Button();
            openFileDialog1 = new OpenFileDialog();
            panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            tblPnlMain.SuspendLayout();
            tblPnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGdVwEntrada).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(94, 167, 189);
            panelTitle.Controls.Add(lbTitle);
            panelTitle.Controls.Add(pictureBoxLogo);
            resources.ApplyResources(panelTitle, "panelTitle");
            panelTitle.Name = "panelTitle";
            // 
            // lbTitle
            // 
            resources.ApplyResources(lbTitle, "lbTitle");
            lbTitle.ForeColor = SystemColors.ControlLightLight;
            lbTitle.Name = "lbTitle";
            // 
            // pictureBoxLogo
            // 
            resources.ApplyResources(pictureBoxLogo, "pictureBoxLogo");
            pictureBoxLogo.Image = Properties.Resources.logomesa;
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.TabStop = false;
            // 
            // tblPnlMain
            // 
            resources.ApplyResources(tblPnlMain, "tblPnlMain");
            tblPnlMain.Controls.Add(tblPnlControl, 0, 0);
            tblPnlMain.Controls.Add(dtGdVwEntrada, 0, 1);
            tblPnlMain.Controls.Add(tableLayoutPanel1, 0, 2);
            tblPnlMain.Name = "tblPnlMain";
            // 
            // tblPnlControl
            // 
            resources.ApplyResources(tblPnlControl, "tblPnlControl");
            tblPnlControl.Controls.Add(btnEliminar, 5, 0);
            tblPnlControl.Controls.Add(lbEntrada, 0, 0);
            tblPnlControl.Controls.Add(txtBxEntrada, 1, 0);
            tblPnlControl.Controls.Add(btnSalida, 2, 0);
            tblPnlControl.Controls.Add(btnArchivo, 3, 0);
            tblPnlControl.Controls.Add(btnNuevo, 4, 0);
            tblPnlControl.Name = "tblPnlControl";
            // 
            // btnEliminar
            // 
            resources.ApplyResources(btnEliminar, "btnEliminar");
            btnEliminar.BackColor = Color.LightSteelBlue;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lbEntrada
            // 
            resources.ApplyResources(lbEntrada, "lbEntrada");
            lbEntrada.Name = "lbEntrada";
            // 
            // txtBxEntrada
            // 
            resources.ApplyResources(txtBxEntrada, "txtBxEntrada");
            txtBxEntrada.Name = "txtBxEntrada";
            txtBxEntrada.KeyPress += txtBxEntrada_KeyPress;
            // 
            // btnSalida
            // 
            resources.ApplyResources(btnSalida, "btnSalida");
            btnSalida.BackColor = Color.LightSteelBlue;
            btnSalida.Cursor = Cursors.Hand;
            btnSalida.Name = "btnSalida";
            btnSalida.UseVisualStyleBackColor = false;
            btnSalida.Click += btnSalida_Click;
            // 
            // btnArchivo
            // 
            resources.ApplyResources(btnArchivo, "btnArchivo");
            btnArchivo.BackColor = Color.LightSteelBlue;
            btnArchivo.Cursor = Cursors.Hand;
            btnArchivo.Name = "btnArchivo";
            btnArchivo.UseVisualStyleBackColor = false;
            btnArchivo.Click += btnArchivo_Click;
            // 
            // btnNuevo
            // 
            resources.ApplyResources(btnNuevo, "btnNuevo");
            btnNuevo.BackColor = Color.LightSteelBlue;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.Name = "btnNuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dtGdVwEntrada
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(221, 222, 223);
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSteelBlue;
            dtGdVwEntrada.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(dtGdVwEntrada, "dtGdVwEntrada");
            dtGdVwEntrada.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtGdVwEntrada.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial", 12F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(94, 167, 189);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtGdVwEntrada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtGdVwEntrada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGdVwEntrada.Name = "dtGdVwEntrada";
            dtGdVwEntrada.CellEndEdit += dtGdVwEntrada_CellEndEdit;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(btnNavigationBack, 0, 0);
            tableLayoutPanel1.Controls.Add(btnNavigationNext, 1, 0);
            tableLayoutPanel1.Controls.Add(lbPagination, 2, 0);
            tableLayoutPanel1.Controls.Add(btnReset, 3, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // btnNavigationBack
            // 
            resources.ApplyResources(btnNavigationBack, "btnNavigationBack");
            btnNavigationBack.BackColor = Color.LightSteelBlue;
            btnNavigationBack.Cursor = Cursors.Hand;
            btnNavigationBack.ForeColor = Color.Black;
            btnNavigationBack.Name = "btnNavigationBack";
            btnNavigationBack.UseVisualStyleBackColor = false;
            btnNavigationBack.Click += btnNavigationBack_Click;
            // 
            // btnNavigationNext
            // 
            resources.ApplyResources(btnNavigationNext, "btnNavigationNext");
            btnNavigationNext.BackColor = Color.LightSteelBlue;
            btnNavigationNext.Cursor = Cursors.Hand;
            btnNavigationNext.Name = "btnNavigationNext";
            btnNavigationNext.UseVisualStyleBackColor = false;
            btnNavigationNext.Click += btnNavigationNext_Click;
            // 
            // lbPagination
            // 
            resources.ApplyResources(lbPagination, "lbPagination");
            lbPagination.Name = "lbPagination";
            // 
            // btnReset
            // 
            resources.ApplyResources(btnReset, "btnReset");
            btnReset.BackColor = Color.LightSteelBlue;
            btnReset.Cursor = Cursors.Hand;
            btnReset.Name = "btnReset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ENTRADAS
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(tblPnlMain);
            Controls.Add(panelTitle);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "ENTRADAS";
            Load += ENTRADAS_Load;
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            tblPnlMain.ResumeLayout(false);
            tblPnlControl.ResumeLayout(false);
            tblPnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGdVwEntrada).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitle;
        private Label lbTitle;
        private PictureBox pictureBoxLogo;
        private TableLayoutPanel tblPnlMain;
        private Label labelEntrada;
        private TableLayoutPanel tblPnlControl;
        private Label lbEntrada;
        private TextBox txtBxEntrada;
        private Button btnSalida;
        private Button btnArchivo;
        private DataGridView dtGdVwEntrada;
        private OpenFileDialog openFileDialog1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnNavigationBack;
        private Button btnNavigationNext;
        private Label lbPagination;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnReset;
    }
}
