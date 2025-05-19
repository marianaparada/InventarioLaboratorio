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
            // DeudaE
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRD);
            Name = "DeudaE";
            Text = "Form2";
            Load += DeudaE_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRD;
    }
}