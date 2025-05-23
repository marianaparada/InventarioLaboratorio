namespace InventarioLaboratorio
{
    partial class ListaInv
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnRLI = new Button();
            lblLisMatReac = new Label();
            dgvMatReac = new DataGridView();
            Cpriori = new DataGridViewTextBoxColumn();
            Cidmr = new DataGridViewTextBoxColumn();
            Cnommr = new DataGridViewTextBoxColumn();
            Ctipo = new DataGridViewTextBoxColumn();
            Ccant = new DataGridViewTextBoxColumn();
            txtPriori = new TextBox();
            txtIDmr = new TextBox();
            txtNommr = new TextBox();
            txtTipomr = new TextBox();
            txtCantrm = new TextBox();
            cbBaja = new ComboBox();
            btnIngreso = new Button();
            btnBaja = new Button();
            lblInBa = new Label();
            lblPrioriIn = new Label();
            lblIDIn = new Label();
            lblMRIn = new Label();
            lblTipoIn = new Label();
            lblCantIn = new Label();
            nupCB = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvMatReac).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupCB).BeginInit();
            SuspendLayout();
            // 
            // btnRLI
            // 
            btnRLI.BackColor = Color.SeaGreen;
            btnRLI.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRLI.ForeColor = SystemColors.ButtonHighlight;
            btnRLI.Location = new Point(943, 882);
            btnRLI.Name = "btnRLI";
            btnRLI.Size = new Size(130, 50);
            btnRLI.TabIndex = 0;
            btnRLI.Text = "Regresar";
            btnRLI.UseVisualStyleBackColor = false;
            btnRLI.Click += btnRLI_Click;
            // 
            // lblLisMatReac
            // 
            lblLisMatReac.AutoSize = true;
            lblLisMatReac.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLisMatReac.ForeColor = SystemColors.ButtonHighlight;
            lblLisMatReac.Location = new Point(592, 38);
            lblLisMatReac.Name = "lblLisMatReac";
            lblLisMatReac.Size = new Size(718, 65);
            lblLisMatReac.TabIndex = 2;
            lblLisMatReac.Text = "Lista de Materiales y Reactivos";
            // 
            // dgvMatReac
            // 
            dgvMatReac.AllowUserToAddRows = false;
            dgvMatReac.AllowUserToDeleteRows = false;
            dgvMatReac.AllowUserToResizeColumns = false;
            dgvMatReac.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvMatReac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMatReac.ColumnHeadersHeight = 40;
            dgvMatReac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMatReac.Columns.AddRange(new DataGridViewColumn[] { Cpriori, Cidmr, Cnommr, Ctipo, Ccant });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMatReac.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMatReac.Location = new Point(179, 125);
            dgvMatReac.Name = "dgvMatReac";
            dgvMatReac.ReadOnly = true;
            dgvMatReac.RowHeadersWidth = 62;
            dgvMatReac.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvMatReac.Size = new Size(1515, 430);
            dgvMatReac.TabIndex = 3;
            // 
            // Cpriori
            // 
            Cpriori.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Cpriori.HeaderText = "Prioridad";
            Cpriori.MinimumWidth = 151;
            Cpriori.Name = "Cpriori";
            Cpriori.ReadOnly = true;
            Cpriori.Resizable = DataGridViewTriState.False;
            Cpriori.Width = 151;
            // 
            // Cidmr
            // 
            Cidmr.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Cidmr.HeaderText = "ID";
            Cidmr.MinimumWidth = 151;
            Cidmr.Name = "Cidmr";
            Cidmr.ReadOnly = true;
            Cidmr.Resizable = DataGridViewTriState.False;
            Cidmr.Width = 151;
            // 
            // Cnommr
            // 
            Cnommr.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Cnommr.HeaderText = "Nombre del Material o Reactivo";
            Cnommr.MinimumWidth = 451;
            Cnommr.Name = "Cnommr";
            Cnommr.ReadOnly = true;
            Cnommr.Resizable = DataGridViewTriState.False;
            Cnommr.Width = 451;
            // 
            // Ctipo
            // 
            Ctipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Ctipo.HeaderText = "Tipo de Material o Reactivo";
            Ctipo.MinimumWidth = 351;
            Ctipo.Name = "Ctipo";
            Ctipo.ReadOnly = true;
            Ctipo.Resizable = DataGridViewTriState.False;
            Ctipo.Width = 351;
            // 
            // Ccant
            // 
            Ccant.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Ccant.HeaderText = "Cantidad disponible";
            Ccant.MinimumWidth = 351;
            Ccant.Name = "Ccant";
            Ccant.ReadOnly = true;
            Ccant.Resizable = DataGridViewTriState.False;
            Ccant.Width = 351;
            // 
            // txtPriori
            // 
            txtPriori.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPriori.Location = new Point(212, 665);
            txtPriori.Name = "txtPriori";
            txtPriori.Size = new Size(150, 39);
            txtPriori.TabIndex = 4;
            // 
            // txtIDmr
            // 
            txtIDmr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDmr.Location = new Point(381, 665);
            txtIDmr.Name = "txtIDmr";
            txtIDmr.Size = new Size(132, 39);
            txtIDmr.TabIndex = 5;
            // 
            // txtNommr
            // 
            txtNommr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNommr.Location = new Point(535, 665);
            txtNommr.Name = "txtNommr";
            txtNommr.Size = new Size(603, 39);
            txtNommr.TabIndex = 6;
            // 
            // txtTipomr
            // 
            txtTipomr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTipomr.Location = new Point(1162, 665);
            txtTipomr.Name = "txtTipomr";
            txtTipomr.Size = new Size(328, 39);
            txtTipomr.TabIndex = 7;
            // 
            // txtCantrm
            // 
            txtCantrm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantrm.Location = new Point(1509, 665);
            txtCantrm.Name = "txtCantrm";
            txtCantrm.Size = new Size(161, 39);
            txtCantrm.TabIndex = 8;
            // 
            // cbBaja
            // 
            cbBaja.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbBaja.FormattingEnabled = true;
            cbBaja.Location = new Point(212, 809);
            cbBaja.Name = "cbBaja";
            cbBaja.Size = new Size(1027, 40);
            cbBaja.TabIndex = 9;
            // 
            // btnIngreso
            // 
            btnIngreso.BackColor = Color.SeaGreen;
            btnIngreso.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngreso.ForeColor = SystemColors.ButtonHighlight;
            btnIngreso.Location = new Point(825, 733);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(368, 50);
            btnIngreso.TabIndex = 10;
            btnIngreso.Text = "Añadir elemento";
            btnIngreso.UseVisualStyleBackColor = false;
            btnIngreso.Click += btnIngreso_Click;
            // 
            // btnBaja
            // 
            btnBaja.BackColor = Color.SeaGreen;
            btnBaja.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBaja.ForeColor = SystemColors.ButtonHighlight;
            btnBaja.Location = new Point(1385, 803);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(285, 50);
            btnBaja.TabIndex = 11;
            btnBaja.Text = "Eliminar elemento";
            btnBaja.UseVisualStyleBackColor = false;
            btnBaja.Click += btnBaja_Click;
            // 
            // lblInBa
            // 
            lblInBa.AutoSize = true;
            lblInBa.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInBa.ForeColor = SystemColors.ButtonHighlight;
            lblInBa.Location = new Point(179, 572);
            lblInBa.Name = "lblInBa";
            lblInBa.Size = new Size(468, 45);
            lblInBa.TabIndex = 12;
            lblInBa.Text = "Ingresos y Bajas de Inventario\r\n";
            // 
            // lblPrioriIn
            // 
            lblPrioriIn.AutoSize = true;
            lblPrioriIn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrioriIn.Location = new Point(212, 627);
            lblPrioriIn.Name = "lblPrioriIn";
            lblPrioriIn.Size = new Size(88, 25);
            lblPrioriIn.TabIndex = 13;
            lblPrioriIn.Text = "Prioridad:";
            // 
            // lblIDIn
            // 
            lblIDIn.AutoSize = true;
            lblIDIn.Location = new Point(381, 630);
            lblIDIn.Name = "lblIDIn";
            lblIDIn.Size = new Size(34, 25);
            lblIDIn.TabIndex = 14;
            lblIDIn.Text = "ID:";
            // 
            // lblMRIn
            // 
            lblMRIn.AutoSize = true;
            lblMRIn.Location = new Point(535, 627);
            lblMRIn.Name = "lblMRIn";
            lblMRIn.Size = new Size(266, 25);
            lblMRIn.TabIndex = 15;
            lblMRIn.Text = "Nombre del Material o Reactivo:";
            // 
            // lblTipoIn
            // 
            lblTipoIn.AutoSize = true;
            lblTipoIn.Location = new Point(1162, 630);
            lblTipoIn.Name = "lblTipoIn";
            lblTipoIn.Size = new Size(227, 25);
            lblTipoIn.TabIndex = 16;
            lblTipoIn.Text = "Tipo de Material o Reactivo";
            // 
            // lblCantIn
            // 
            lblCantIn.AutoSize = true;
            lblCantIn.Location = new Point(1500, 627);
            lblCantIn.Name = "lblCantIn";
            lblCantIn.Size = new Size(170, 25);
            lblCantIn.TabIndex = 17;
            lblCantIn.Text = "Cantidad Ingresada:";
            // 
            // nupCB
            // 
            nupCB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nupCB.Location = new Point(1273, 809);
            nupCB.Name = "nupCB";
            nupCB.Size = new Size(82, 39);
            nupCB.TabIndex = 18;
            // 
            // ListaInv
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1878, 944);
            Controls.Add(nupCB);
            Controls.Add(lblCantIn);
            Controls.Add(lblTipoIn);
            Controls.Add(lblMRIn);
            Controls.Add(lblIDIn);
            Controls.Add(lblPrioriIn);
            Controls.Add(lblInBa);
            Controls.Add(btnBaja);
            Controls.Add(btnIngreso);
            Controls.Add(cbBaja);
            Controls.Add(txtCantrm);
            Controls.Add(txtTipomr);
            Controls.Add(txtNommr);
            Controls.Add(txtIDmr);
            Controls.Add(txtPriori);
            Controls.Add(dgvMatReac);
            Controls.Add(lblLisMatReac);
            Controls.Add(btnRLI);
            Name = "ListaInv";
            Text = "ListaInv";
            ((System.ComponentModel.ISupportInitialize)dgvMatReac).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupCB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRLI;
        private Label lblLisMatReac;
        private DataGridView dgvMatReac;
        private DataGridViewTextBoxColumn Cpriori;
        private DataGridViewTextBoxColumn Cidmr;
        private DataGridViewTextBoxColumn Cnommr;
        private DataGridViewTextBoxColumn Ctipo;
        private DataGridViewTextBoxColumn Ccant;
        private TextBox txtPriori;
        private TextBox txtIDmr;
        private TextBox txtNommr;
        private TextBox txtTipomr;
        private TextBox txtCantrm;
        private ComboBox cbBaja;
        private Button btnIngreso;
        private Button btnBaja;
        private Label lblInBa;
        private Label lblPrioriIn;
        private Label lblIDIn;
        private Label lblMRIn;
        private Label lblTipoIn;
        private Label lblCantIn;
        private NumericUpDown nupCB;
    }
}
