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
            btnRD = new Button();
            MSDE = new MenuStrip();
            listaDeDeudaToolStripMenuItem = new ToolStripMenuItem();
            añadirDeudaToolStripMenuItem = new ToolStripMenuItem();
            TCDE = new TabControl();
            TPDE1 = new TabPage();
            dataGridView1 = new DataGridView();
            Cf = new DataGridViewTextBoxColumn();
            Cr = new DataGridViewTextBoxColumn();
            Cn = new DataGridViewTextBoxColumn();
            Cid = new DataGridViewTextBoxColumn();
            Cnmr = new DataGridViewTextBoxColumn();
            Ccant = new DataGridViewTextBoxColumn();
            TPDE2 = new TabPage();
            lblCantD = new Label();
            lblIDD = new Label();
            lblDev = new Label();
            lblRegD = new Label();
            txtCantD = new TextBox();
            txtIDD = new TextBox();
            txtRegD = new TextBox();
            btnDevolver = new Button();
            MSDE.SuspendLayout();
            TCDE.SuspendLayout();
            TPDE1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            TPDE2.SuspendLayout();
            SuspendLayout();
            // 
            // btnRD
            // 
            btnRD.BackColor = Color.SeaGreen;
            btnRD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRD.ForeColor = SystemColors.ButtonHighlight;
            btnRD.Location = new Point(321, 393);
            btnRD.Name = "btnRD";
            btnRD.Size = new Size(134, 45);
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
            MSDE.Size = new Size(800, 33);
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
            TCDE.Size = new Size(776, 387);
            TCDE.TabIndex = 2;
            // 
            // TPDE1
            // 
            TPDE1.BackColor = Color.SeaGreen;
            TPDE1.Controls.Add(dataGridView1);
            TPDE1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TPDE1.ForeColor = SystemColors.ButtonHighlight;
            TPDE1.Location = new Point(4, 34);
            TPDE1.Name = "TPDE1";
            TPDE1.Padding = new Padding(3);
            TPDE1.Size = new Size(768, 349);
            TPDE1.TabIndex = 0;
            TPDE1.Text = "Lista de Deuda";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Cf, Cr, Cn, Cid, Cnmr, Ccant });
            dataGridView1.Location = new Point(0, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(768, 343);
            dataGridView1.TabIndex = 0;
            // 
            // Cf
            // 
            Cf.HeaderText = "Fecha";
            Cf.MinimumWidth = 8;
            Cf.Name = "Cf";
            Cf.ReadOnly = true;
            Cf.Width = 150;
            // 
            // Cr
            // 
            Cr.HeaderText = "Nro. Registro";
            Cr.MinimumWidth = 8;
            Cr.Name = "Cr";
            Cr.ReadOnly = true;
            Cr.Width = 150;
            // 
            // Cn
            // 
            Cn.HeaderText = "Nombre Estudiante";
            Cn.MinimumWidth = 8;
            Cn.Name = "Cn";
            Cn.ReadOnly = true;
            Cn.Width = 150;
            // 
            // Cid
            // 
            Cid.HeaderText = "ID";
            Cid.MinimumWidth = 8;
            Cid.Name = "Cid";
            Cid.ReadOnly = true;
            Cid.Width = 150;
            // 
            // Cnmr
            // 
            Cnmr.HeaderText = "Materiales y Reactivos";
            Cnmr.MinimumWidth = 8;
            Cnmr.Name = "Cnmr";
            Cnmr.ReadOnly = true;
            Cnmr.Width = 150;
            // 
            // Ccant
            // 
            Ccant.HeaderText = "Cantidad";
            Ccant.MinimumWidth = 8;
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
            TPDE2.Size = new Size(768, 349);
            TPDE2.TabIndex = 1;
            TPDE2.Text = "Registrar Deuda";
            // 
            // lblCantD
            // 
            lblCantD.AutoSize = true;
            lblCantD.BorderStyle = BorderStyle.Fixed3D;
            lblCantD.Location = new Point(235, 230);
            lblCantD.Name = "lblCantD";
            lblCantD.Size = new Size(118, 34);
            lblCantD.TabIndex = 6;
            lblCantD.Text = "Cantidad";
            // 
            // lblIDD
            // 
            lblIDD.AutoSize = true;
            lblIDD.BorderStyle = BorderStyle.Fixed3D;
            lblIDD.Location = new Point(222, 167);
            lblIDD.Name = "lblIDD";
            lblIDD.Size = new Size(131, 34);
            lblIDD.TabIndex = 5;
            lblIDD.Text = "Código ID";
            // 
            // lblDev
            // 
            lblDev.AutoSize = true;
            lblDev.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDev.Location = new Point(247, 21);
            lblDev.Name = "lblDev";
            lblDev.Size = new Size(274, 54);
            lblDev.TabIndex = 4;
            lblDev.Text = "Devoluciones";
            // 
            // lblRegD
            // 
            lblRegD.AutoSize = true;
            lblRegD.BorderStyle = BorderStyle.Fixed3D;
            lblRegD.Location = new Point(106, 104);
            lblRegD.Name = "lblRegD";
            lblRegD.Size = new Size(247, 34);
            lblRegD.TabIndex = 3;
            lblRegD.Text = "Número de Registro";
            // 
            // txtCantD
            // 
            txtCantD.Location = new Point(444, 225);
            txtCantD.Name = "txtCantD";
            txtCantD.Size = new Size(190, 39);
            txtCantD.TabIndex = 2;
            // 
            // txtIDD
            // 
            txtIDD.Location = new Point(444, 162);
            txtIDD.Name = "txtIDD";
            txtIDD.Size = new Size(190, 39);
            txtIDD.TabIndex = 1;
            // 
            // txtRegD
            // 
            txtRegD.Location = new Point(444, 99);
            txtRegD.Name = "txtRegD";
            txtRegD.Size = new Size(190, 39);
            txtRegD.TabIndex = 0;
            // 
            // btnDevolver
            // 
            btnDevolver.BackColor = Color.SeaGreen;
            btnDevolver.Location = new Point(305, 290);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(134, 43);
            btnDevolver.TabIndex = 7;
            btnDevolver.Text = "Devolver";
            btnDevolver.UseVisualStyleBackColor = false;
            // 
            // DeudaE
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(TCDE);
            Controls.Add(btnRD);
            Controls.Add(MSDE);
            MainMenuStrip = MSDE;
            Name = "DeudaE";
            Text = "Form2";
            Load += DeudaE_Load;
            MSDE.ResumeLayout(false);
            MSDE.PerformLayout();
            TCDE.ResumeLayout(false);
            TPDE1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Cf;
        private DataGridViewTextBoxColumn Cr;
        private DataGridViewTextBoxColumn Cn;
        private DataGridViewTextBoxColumn Cid;
        private DataGridViewTextBoxColumn Cnmr;
        private DataGridViewTextBoxColumn Ccant;
        private Label lblDev;
        private Label lblRegD;
        private TextBox txtCantD;
        private TextBox txtIDD;
        private TextBox txtRegD;
        private Label lblCantD;
        private Label lblIDD;
        private Button btnDevolver;
    }
}