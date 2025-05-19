namespace InventarioLaboratorio
{
    partial class PrestamoE
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
            btnRP = new Button();
            SuspendLayout();
            // 
            // btnRP
            // 
            btnRP.BackColor = Color.SeaGreen;
            btnRP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRP.ForeColor = SystemColors.ButtonHighlight;
            btnRP.Location = new Point(342, 379);
            btnRP.Name = "btnRP";
            btnRP.Size = new Size(128, 47);
            btnRP.TabIndex = 0;
            btnRP.Text = "Regresar";
            btnRP.UseVisualStyleBackColor = false;
            btnRP.Click += btnRP_Click;
            // 
            // PrestamoE
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRP);
            Name = "PrestamoE";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRP;
    }
}