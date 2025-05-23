namespace InventarioLaboratorio
{
    partial class PrestamoE
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
            btnRP = new Button();
            dgvCarrito = new DataGridView();
            Cpriorip = new DataGridViewTextBoxColumn();
            Cidp = new DataGridViewTextBoxColumn();
            Cnomp = new DataGridViewTextBoxColumn();
            Ctipop = new DataGridViewTextBoxColumn();
            Ccantp = new DataGridViewTextBoxColumn();
            cbMat = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            txtNroReg = new TextBox();
            txtNomE = new TextBox();
            lblNroReg = new Label();
            lblNomE = new Label();
            btnQuitar = new Button();
            btnConfirmar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnRP
            // 
            btnRP.BackColor = Color.SeaGreen;
            btnRP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRP.ForeColor = SystemColors.ButtonHighlight;
            btnRP.Location = new Point(1670, 850);
            btnRP.Name = "btnRP";
            btnRP.Size = new Size(130, 50);
            btnRP.TabIndex = 0;
            btnRP.Text = "Regresar";
            btnRP.UseVisualStyleBackColor = false;
            btnRP.Click += btnRP_Click;
            // 
            // dgvCarrito
            // 
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.AllowUserToDeleteRows = false;
            dgvCarrito.AllowUserToResizeColumns = false;
            dgvCarrito.AllowUserToResizeRows = false;
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCarrito.ColumnHeadersHeight = 40;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { Cpriorip, Cidp, Cnomp, Ctipop, Ccantp });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCarrito.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCarrito.Location = new Point(59, 80);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowHeadersWidth = 62;
            dgvCarrito.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCarrito.Size = new Size(1716, 523);
            dgvCarrito.TabIndex = 1;
            // 
            // Cpriorip
            // 
            Cpriorip.HeaderText = "Prioridad";
            Cpriorip.MinimumWidth = 150;
            Cpriorip.Name = "Cpriorip";
            Cpriorip.ReadOnly = true;
            Cpriorip.Resizable = DataGridViewTriState.False;
            Cpriorip.Width = 157;
            // 
            // Cidp
            // 
            Cidp.HeaderText = "ID";
            Cidp.MinimumWidth = 150;
            Cidp.Name = "Cidp";
            Cidp.ReadOnly = true;
            Cidp.Resizable = DataGridViewTriState.False;
            Cidp.Width = 150;
            // 
            // Cnomp
            // 
            Cnomp.HeaderText = "Nombre del Material o Reactivo";
            Cnomp.MinimumWidth = 600;
            Cnomp.Name = "Cnomp";
            Cnomp.ReadOnly = true;
            Cnomp.Resizable = DataGridViewTriState.False;
            Cnomp.Width = 600;
            // 
            // Ctipop
            // 
            Ctipop.HeaderText = "Tipo de Material o Reactivo";
            Ctipop.MinimumWidth = 500;
            Ctipop.Name = "Ctipop";
            Ctipop.ReadOnly = true;
            Ctipop.Resizable = DataGridViewTriState.False;
            Ctipop.Width = 500;
            // 
            // Ccantp
            // 
            Ccantp.HeaderText = "Cantidad Prestada";
            Ccantp.MinimumWidth = 250;
            Ccantp.Name = "Ccantp";
            Ccantp.ReadOnly = true;
            Ccantp.Resizable = DataGridViewTriState.False;
            Ccantp.Width = 258;
            // 
            // cbMat
            // 
            cbMat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMat.FormattingEnabled = true;
            cbMat.Location = new Point(105, 675);
            cbMat.Name = "cbMat";
            cbMat.Size = new Size(747, 40);
            cbMat.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(888, 675);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(59, 39);
            numericUpDown1.TabIndex = 3;
            // 
            // txtNroReg
            // 
            txtNroReg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNroReg.Location = new Point(1371, 671);
            txtNroReg.Name = "txtNroReg";
            txtNroReg.Size = new Size(404, 39);
            txtNroReg.TabIndex = 4;
            // 
            // txtNomE
            // 
            txtNomE.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomE.Location = new Point(1371, 752);
            txtNomE.Name = "txtNomE";
            txtNomE.Size = new Size(404, 39);
            txtNomE.TabIndex = 5;
            // 
            // lblNroReg
            // 
            lblNroReg.AutoSize = true;
            lblNroReg.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNroReg.ForeColor = SystemColors.ButtonHighlight;
            lblNroReg.Location = new Point(995, 678);
            lblNroReg.Name = "lblNroReg";
            lblNroReg.Size = new Size(245, 32);
            lblNroReg.TabIndex = 6;
            lblNroReg.Text = "Número de Registro";
            // 
            // lblNomE
            // 
            lblNomE.AutoSize = true;
            lblNomE.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomE.ForeColor = SystemColors.ButtonHighlight;
            lblNomE.Location = new Point(995, 761);
            lblNomE.Name = "lblNomE";
            lblNomE.Size = new Size(277, 32);
            lblNomE.TabIndex = 7;
            lblNomE.Text = "Nombre del Estudiante";
            // 
            // btnQuitar
            // 
            btnQuitar.BackColor = Color.SeaGreen;
            btnQuitar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuitar.ForeColor = SystemColors.ButtonHighlight;
            btnQuitar.Location = new Point(564, 752);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(288, 50);
            btnQuitar.TabIndex = 9;
            btnQuitar.Text = "Eliminar del Prestamo";
            btnQuitar.UseVisualStyleBackColor = false;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.SeaGreen;
            btnConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = SystemColors.ButtonHighlight;
            btnConfirmar.Location = new Point(780, 850);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(309, 50);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "Confirmar Prestamo";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ButtonHighlight;
            btnAgregar.Location = new Point(216, 752);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(288, 50);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar al Prestamo";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // PrestamoE
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1878, 944);
            Controls.Add(btnAgregar);
            Controls.Add(btnConfirmar);
            Controls.Add(btnQuitar);
            Controls.Add(lblNomE);
            Controls.Add(lblNroReg);
            Controls.Add(txtNomE);
            Controls.Add(txtNroReg);
            Controls.Add(numericUpDown1);
            Controls.Add(cbMat);
            Controls.Add(dgvCarrito);
            Controls.Add(btnRP);
            Name = "PrestamoE";
            Text = "Prestamo Estudiantil";
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRP;
        private DataGridView dgvCarrito;
        private ComboBox cbMat;
        private NumericUpDown numericUpDown1;
        private TextBox txtNroReg;
        private TextBox txtNomE;
        private Label lblNroReg;
        private Label lblNomE;
        private Button btnQuitar;
        private Button btnConfirmar;
        private Button btnAgregar;
        private DataGridViewTextBoxColumn Cpriorip;
        private DataGridViewTextBoxColumn Cidp;
        private DataGridViewTextBoxColumn Cnomp;
        private DataGridViewTextBoxColumn Ctipop;
        private DataGridViewTextBoxColumn Ccantp;
    }
}