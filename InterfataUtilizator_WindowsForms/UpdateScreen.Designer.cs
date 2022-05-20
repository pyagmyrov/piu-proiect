namespace InterfataUtilizator_WindowsForms
{
    partial class UpdateScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ActualizareLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ActualizareLabel
            // 
            this.ActualizareLabel.AutoSize = true;
            this.ActualizareLabel.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizareLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ActualizareLabel.Location = new System.Drawing.Point(26, 15);
            this.ActualizareLabel.Name = "ActualizareLabel";
            this.ActualizareLabel.Size = new System.Drawing.Size(122, 30);
            this.ActualizareLabel.TabIndex = 1;
            this.ActualizareLabel.Text = "Actualizare";
            // 
            // UpdateScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.ActualizareLabel);
            this.Name = "UpdateScreen";
            this.Size = new System.Drawing.Size(723, 533);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ActualizareLabel;
    }
}
