namespace InventarioLaboratorio
{
    partial class Menu
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
            btnDeuda = new Button();
            btnPrestamo = new Button();
            btnListaInv = new Button();
            lbl1 = new Label();
            pbLogo1 = new PictureBox();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo1).BeginInit();
            SuspendLayout();
            // 
            // btnDeuda
            // 
            btnDeuda.BackColor = Color.SeaGreen;
            btnDeuda.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeuda.ForeColor = SystemColors.ButtonHighlight;
            btnDeuda.Location = new Point(633, 441);
            btnDeuda.Name = "btnDeuda";
            btnDeuda.Size = new Size(580, 74);
            btnDeuda.TabIndex = 0;
            btnDeuda.Text = "Deuda Estudiantil";
            btnDeuda.UseVisualStyleBackColor = false;
            btnDeuda.Click += btnDeuda_Click_1;
            // 
            // btnPrestamo
            // 
            btnPrestamo.BackColor = Color.SeaGreen;
            btnPrestamo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrestamo.ForeColor = SystemColors.ButtonHighlight;
            btnPrestamo.Location = new Point(633, 312);
            btnPrestamo.Name = "btnPrestamo";
            btnPrestamo.Size = new Size(580, 74);
            btnPrestamo.TabIndex = 1;
            btnPrestamo.Text = "Prestamo Estudiantil";
            btnPrestamo.UseVisualStyleBackColor = false;
            // 
            // btnListaInv
            // 
            btnListaInv.BackColor = Color.SeaGreen;
            btnListaInv.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListaInv.ForeColor = SystemColors.ButtonHighlight;
            btnListaInv.Location = new Point(633, 573);
            btnListaInv.Name = "btnListaInv";
            btnListaInv.Size = new Size(580, 74);
            btnListaInv.TabIndex = 2;
            btnListaInv.Text = "Materiales y Reactivos";
            btnListaInv.UseVisualStyleBackColor = false;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.ForeColor = SystemColors.ButtonHighlight;
            lbl1.Location = new Point(797, 166);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(256, 96);
            lbl1.TabIndex = 3;
            lbl1.Text = "MENU";
            // 
            // pbLogo1
            // 
            pbLogo1.Image = Properties.Resources.Imagen_de_WhatsApp_2025_05_14_a_las_21_59_10_4170be7c;
            pbLogo1.Location = new Point(-14, -16);
            pbLogo1.Name = "pbLogo1";
            pbLogo1.Size = new Size(485, 278);
            pbLogo1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo1.TabIndex = 4;
            pbLogo1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.SeaGreen;
            btnSalir.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(863, 720);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(142, 72);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1878, 944);
            Controls.Add(btnSalir);
            Controls.Add(pbLogo1);
            Controls.Add(lbl1);
            Controls.Add(btnListaInv);
            Controls.Add(btnPrestamo);
            Controls.Add(btnDeuda);
            Name = "Menu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pbLogo1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnDeuda;
        private System.Windows.Forms.Button btnPrestamo;
        private System.Windows.Forms.Button btnListaInv;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox pbLogo1;
        private Button btnSalir;
    }
}