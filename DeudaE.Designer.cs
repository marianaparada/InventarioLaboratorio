namespace InventarioLaboratorio
{
    partial class DeudaE
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnRD = new Button();
            MSDE = new MenuStrip();
            listaDeDeudaToolStripMenuItem = new ToolStripMenuItem();
            añadirDeudaToolStripMenuItem = new ToolStripMenuItem();
            TCDE = new TabControl();
            TPDE1 = new TabPage();
            dgvMatReac = new DataGridView();
            Cf = new DataGridViewTextBoxColumn();
            Cr = new DataGridViewTextBoxColumn();
            Cn = new DataGridViewTextBoxColumn();
            Cid = new DataGridViewTextBoxColumn();
            Cnmr = new DataGridViewTextBoxColumn();
            Ccant = new DataGridViewTextBoxColumn();
            TPDE2 = new TabPage();
            btnDevolver = new Button();
            lblCantD = new Label();
            lblIDD = new Label();
            lblDev = new Label();
            lblRegD = new Label();
            txtCantD = new TextBox();
            txtIDD = new TextBox();
            txtRegD = new TextBox();
            MSDE.SuspendLayout();
            TCDE.SuspendLayout();
            TPDE1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatReac).BeginInit();
            TPDE2.SuspendLayout();
            SuspendLayout();
            // 
            // btnRD
            // 
            btnRD.BackColor = Color.SeaGreen;
            btnRD.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRD.ForeColor = SystemColors.ButtonHighlight;
            btnRD.Location = new Point(895, 850);
            btnRD.Name = "btnRD";
            btnRD.Size = new Size(164, 57);
            btnRD.TabIndex = 0;
            btnRD.Text = "Regresar";
            btnRD.UseVisualStyleBackColor = false;
            btnRD.Click += btnRD_Click;
            // 
            // MSDE
            // 
            MSDE.ImageScalingSize = new Size(24, 24);
            MSDE.Items.AddRange(new ToolStripItem[] { listaDeDeudaToolStripMenuItem, añadirDeudaToolStripMenuItem });
            MSDE.Location = new Point(0, 0);
            MSDE.Name = "MSDE";
            MSDE.Size = new Size(1878, 33);
            MSDE.TabIndex = 1;
            MSDE.Text = "menuStrip1";
            // 
            // listaDeDeudaToolStripMenuItem
            // 
            listaDeDeudaToolStripMenuItem.Name = "listaDeDeudaToolStripMenuItem";
            listaDeDeudaToolStripMenuItem.Size = new Size(145, 29);
            listaDeDeudaToolStripMenuItem.Text = "Lista de Deuda";
            listaDeDeudaToolStripMenuItem.Click += listaDeDeudaToolStripMenuItem_Click;
            // 
            // añadirDeudaToolStripMenuItem
            // 
            añadirDeudaToolStripMenuItem.Name = "añadirDeudaToolStripMenuItem";
            añadirDeudaToolStripMenuItem.Size = new Size(196, 29);
            añadirDeudaToolStripMenuItem.Text = "Registrar Devolución ";
            añadirDeudaToolStripMenuItem.Click += añadirDeudaToolStripMenuItem_Click;
            // 
            // TCDE
            // 
            TCDE.Controls.Add(TPDE1);
            TCDE.Controls.Add(TPDE2);
            TCDE.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TCDE.Location = new Point(12, 0);
            TCDE.Name = "TCDE";
            TCDE.SelectedIndex = 0;
            TCDE.Size = new Size(1854, 826);
            TCDE.TabIndex = 2;
            // 
            // TPDE1
            // 
            TPDE1.BackColor = Color.SeaGreen;
            TPDE1.Controls.Add(dgvMatReac);
            TPDE1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TPDE1.ForeColor = SystemColors.ButtonHighlight;
            TPDE1.Location = new Point(4, 34);
            TPDE1.Name = "TPDE1";
            TPDE1.Padding = new Padding(3);
            TPDE1.Size = new Size(1846, 788);
            TPDE1.TabIndex = 0;
            TPDE1.Text = "Lista de Deuda";
            // 
            // dgvMatReac
            // 
            dgvMatReac.AllowUserToAddRows = false;
            dgvMatReac.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvMatReac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMatReac.ColumnHeadersHeight = 40;
            dgvMatReac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMatReac.Columns.AddRange(new DataGridViewColumn[] { Cf, Cr, Cn, Cid, Cnmr, Ccant });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMatReac.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMatReac.GridColor = SystemColors.ActiveBorder;
            dgvMatReac.Location = new Point(3, 8);
            dgvMatReac.Name = "dgvMatReac";
            dgvMatReac.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.MenuText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMatReac.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvMatReac.RowHeadersWidth = 62;
            dgvMatReac.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvMatReac.Size = new Size(1840, 779);
            dgvMatReac.TabIndex = 0;
            // 
            // Cf
            // 
            Cf.HeaderText = "Fecha";
            Cf.MinimumWidth = 150;
            Cf.Name = "Cf";
            Cf.ReadOnly = true;
            Cf.Width = 150;
            // 
            // Cr
            // 
            Cr.HeaderText = "Nro. Registro";
            Cr.MinimumWidth = 200;
            Cr.Name = "Cr";
            Cr.ReadOnly = true;
            Cr.Width = 200;
            // 
            // Cn
            // 
            Cn.HeaderText = "Nombre Estudiante";
            Cn.MinimumWidth = 550;
            Cn.Name = "Cn";
            Cn.ReadOnly = true;
            Cn.Width = 550;
            // 
            // Cid
            // 
            Cid.HeaderText = "ID";
            Cid.MinimumWidth = 150;
            Cid.Name = "Cid";
            Cid.ReadOnly = true;
            Cid.Width = 150;
            // 
            // Cnmr
            // 
            Cnmr.HeaderText = "Materiales y Reactivos";
            Cnmr.MinimumWidth = 580;
            Cnmr.Name = "Cnmr";
            Cnmr.ReadOnly = true;
            Cnmr.Width = 580;
            // 
            // Ccant
            // 
            Ccant.HeaderText = "Cantidad";
            Ccant.MinimumWidth = 150;
            Ccant.Name = "Ccant";
            Ccant.ReadOnly = true;
            Ccant.Width = 150;
            // 
            // TPDE2
            // 
            TPDE2.BackColor = Color.SeaGreen;
            TPDE2.Controls.Add(btnDevolver);
            TPDE2.Controls.Add(lblCantD);
            TPDE2.Controls.Add(lblIDD);
            TPDE2.Controls.Add(lblDev);
            TPDE2.Controls.Add(lblRegD);
            TPDE2.Controls.Add(txtCantD);
            TPDE2.Controls.Add(txtIDD);
            TPDE2.Controls.Add(txtRegD);
            TPDE2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TPDE2.ForeColor = SystemColors.ButtonHighlight;
            TPDE2.Location = new Point(4, 34);
            TPDE2.Name = "TPDE2";
            TPDE2.Padding = new Padding(3);
            TPDE2.Size = new Size(1846, 788);
            TPDE2.TabIndex = 1;
            TPDE2.Text = "Registrar Deuda";
            // 
            // btnDevolver
            // 
            btnDevolver.BackColor = Color.SeaGreen;
            btnDevolver.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDevolver.Location = new Point(859, 634);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(200, 55);
            btnDevolver.TabIndex = 7;
            btnDevolver.Text = "Devolver";
            btnDevolver.UseVisualStyleBackColor = false;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // lblCantD
            // 
            lblCantD.AutoSize = true;
            lblCantD.BorderStyle = BorderStyle.Fixed3D;
            lblCantD.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantD.Location = new Point(709, 466);
            lblCantD.Name = "lblCantD";
            lblCantD.Size = new Size(172, 50);
            lblCantD.TabIndex = 6;
            lblCantD.Text = "Cantidad";
            // 
            // lblIDD
            // 
            lblIDD.AutoSize = true;
            lblIDD.BorderStyle = BorderStyle.Fixed3D;
            lblIDD.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIDD.Location = new Point(691, 369);
            lblIDD.Name = "lblIDD";
            lblIDD.Size = new Size(190, 50);
            lblIDD.TabIndex = 5;
            lblIDD.Text = "Código ID";
            // 
            // lblDev
            // 
            lblDev.AutoSize = true;
            lblDev.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDev.Location = new Point(750, 107);
            lblDev.Name = "lblDev";
            lblDev.Size = new Size(382, 74);
            lblDev.TabIndex = 4;
            lblDev.Text = "Devoluciones";
            // 
            // lblRegD
            // 
            lblRegD.AutoSize = true;
            lblRegD.BorderStyle = BorderStyle.Fixed3D;
            lblRegD.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegD.Location = new Point(520, 271);
            lblRegD.Name = "lblRegD";
            lblRegD.Size = new Size(361, 50);
            lblRegD.TabIndex = 3;
            lblRegD.Text = "Número de Registro";
            // 
            // txtCantD
            // 
            txtCantD.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCantD.Location = new Point(1064, 466);
            txtCantD.Name = "txtCantD";
            txtCantD.Size = new Size(190, 50);
            txtCantD.TabIndex = 2;
            // 
            // txtIDD
            // 
            txtIDD.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIDD.Location = new Point(1064, 369);
            txtIDD.Name = "txtIDD";
            txtIDD.Size = new Size(190, 50);
            txtIDD.TabIndex = 1;
            // 
            // txtRegD
            // 
            txtRegD.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRegD.Location = new Point(1064, 271);
            txtRegD.Name = "txtRegD";
            txtRegD.Size = new Size(190, 50);
            txtRegD.TabIndex = 0;
            // 
            // DeudaE
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1878, 944);
            Controls.Add(btnRD);
            Controls.Add(TCDE);
            Controls.Add(MSDE);
            MainMenuStrip = MSDE;
            Name = "DeudaE";
            Text = "Form2";
            Load += DeudaE_Load;
            MSDE.ResumeLayout(false);
            MSDE.PerformLayout();
            TCDE.ResumeLayout(false);
            TPDE1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMatReac).EndInit();
            TPDE2.ResumeLayout(false);
            TPDE2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRD;
        private MenuStrip MSDE;
        private ToolStripMenuItem listaDeDeudaToolStripMenuItem;
        private ToolStripMenuItem añadirDeudaToolStripMenuItem;
        private TabControl TCDE;
        private TabPage TPDE1;
        private TabPage TPDE2;
        private DataGridView dgvMatReac;
        private Label lblDev;
        private Label lblRegD;
        private TextBox txtCantD;
        private TextBox txtIDD;
        private TextBox txtRegD;
        private Label lblCantD;
        private Label lblIDD;
        private Button btnDevolver;
        private DataGridViewTextBoxColumn Cf;
        private DataGridViewTextBoxColumn Cr;
        private DataGridViewTextBoxColumn Cn;
        private DataGridViewTextBoxColumn Cid;
        private DataGridViewTextBoxColumn Cnmr;
        private DataGridViewTextBoxColumn Ccant;
    }
}