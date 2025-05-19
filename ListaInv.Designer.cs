namespace InventarioLaboratorio
{
    partial class ListaInv
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
            btnRLI = new Button();
            listBoxMatReac = new ListBox();
            lblLisMatReac = new Label();
            SuspendLayout();
            // 
            // btnRLI
            // 
            btnRLI.BackColor = Color.SeaGreen;
            btnRLI.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRLI.ForeColor = SystemColors.ButtonHighlight;
            btnRLI.Location = new Point(339, 391);
            btnRLI.Name = "btnRLI";
            btnRLI.Size = new Size(134, 47);
            btnRLI.TabIndex = 0;
            btnRLI.Text = "Regresar";
            btnRLI.UseVisualStyleBackColor = false;
            btnRLI.Click += btnRLI_Click;
            // 
            // listBoxMatReac
            // 
            listBoxMatReac.FormattingEnabled = true;
            listBoxMatReac.ItemHeight = 25;
            listBoxMatReac.Location = new Point(84, 164);
            listBoxMatReac.Name = "listBoxMatReac";
            listBoxMatReac.Size = new Size(637, 204);
            listBoxMatReac.TabIndex = 1;
            // 
            // lblLisMatReac
            // 
            lblLisMatReac.AutoSize = true;
            lblLisMatReac.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLisMatReac.ForeColor = SystemColors.ButtonHighlight;
            lblLisMatReac.Location = new Point(104, 72);
            lblLisMatReac.Name = "lblLisMatReac";
            lblLisMatReac.Size = new Size(600, 54);
            lblLisMatReac.TabIndex = 2;
            lblLisMatReac.Text = "Lista de Materiales y Reactivos";
            // 
            // ListaInv
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLisMatReac);
            Controls.Add(listBoxMatReac);
            Controls.Add(btnRLI);
            Name = "ListaInv";
            Text = "ListaInv";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRLI;
        private ListBox listBoxMatReac;
        private Label lblLisMatReac;
    }
}