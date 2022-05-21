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
            this.dataGridViewUpdScren = new System.Windows.Forms.DataGridView();
            this.idLblUpdScren = new System.Windows.Forms.Label();
            this.idTextUpdScren = new System.Windows.Forms.TextBox();
            this.numeLblUpdScren = new System.Windows.Forms.Label();
            this.numeTextUpdScren = new System.Windows.Forms.TextBox();
            this.pretLblUpdScren = new System.Windows.Forms.Label();
            this.pretTextUpdScren = new System.Windows.Forms.TextBox();
            this.CantLblUpdScren = new System.Windows.Forms.Label();
            this.CantTextUpdScren = new System.Windows.Forms.TextBox();
            this.currencyUpdScren = new System.Windows.Forms.ComboBox();
            this.updateButtonUpdScren = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdScren)).BeginInit();
            this.SuspendLayout();
            // 
            // ActualizareLabel
            // 
            this.ActualizareLabel.AutoSize = true;
            this.ActualizareLabel.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizareLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ActualizareLabel.Location = new System.Drawing.Point(52, 29);
            this.ActualizareLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ActualizareLabel.Name = "ActualizareLabel";
            this.ActualizareLabel.Size = new System.Drawing.Size(245, 57);
            this.ActualizareLabel.TabIndex = 1;
            this.ActualizareLabel.Text = "Actualizare";
            // 
            // dataGridViewUpdScren
            // 
            this.dataGridViewUpdScren.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUpdScren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpdScren.Location = new System.Drawing.Point(62, 113);
            this.dataGridViewUpdScren.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridViewUpdScren.Name = "dataGridViewUpdScren";
            this.dataGridViewUpdScren.Size = new System.Drawing.Size(1332, 579);
            this.dataGridViewUpdScren.TabIndex = 2;
            this.dataGridViewUpdScren.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUpdScren_CellContentClick);
            // 
            // idLblUpdScren
            // 
            this.idLblUpdScren.AutoSize = true;
            this.idLblUpdScren.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLblUpdScren.ForeColor = System.Drawing.Color.White;
            this.idLblUpdScren.Location = new System.Drawing.Point(344, 742);
            this.idLblUpdScren.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.idLblUpdScren.Name = "idLblUpdScren";
            this.idLblUpdScren.Size = new System.Drawing.Size(42, 36);
            this.idLblUpdScren.TabIndex = 3;
            this.idLblUpdScren.Text = "ID";
            // 
            // idTextUpdScren
            // 
            this.idTextUpdScren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.idTextUpdScren.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextUpdScren.ForeColor = System.Drawing.Color.White;
            this.idTextUpdScren.Location = new System.Drawing.Point(344, 787);
            this.idTextUpdScren.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.idTextUpdScren.Name = "idTextUpdScren";
            this.idTextUpdScren.Size = new System.Drawing.Size(82, 31);
            this.idTextUpdScren.TabIndex = 4;
            this.idTextUpdScren.TextChanged += new System.EventHandler(this.idTextUpdScren_TextChanged);
            // 
            // numeLblUpdScren
            // 
            this.numeLblUpdScren.AutoSize = true;
            this.numeLblUpdScren.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeLblUpdScren.ForeColor = System.Drawing.Color.White;
            this.numeLblUpdScren.Location = new System.Drawing.Point(440, 742);
            this.numeLblUpdScren.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.numeLblUpdScren.Name = "numeLblUpdScren";
            this.numeLblUpdScren.Size = new System.Drawing.Size(90, 36);
            this.numeLblUpdScren.TabIndex = 3;
            this.numeLblUpdScren.Text = "Nume";
            this.numeLblUpdScren.Click += new System.EventHandler(this.label1_Click);
            // 
            // numeTextUpdScren
            // 
            this.numeTextUpdScren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.numeTextUpdScren.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeTextUpdScren.ForeColor = System.Drawing.Color.White;
            this.numeTextUpdScren.Location = new System.Drawing.Point(446, 787);
            this.numeTextUpdScren.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numeTextUpdScren.Name = "numeTextUpdScren";
            this.numeTextUpdScren.Size = new System.Drawing.Size(158, 31);
            this.numeTextUpdScren.TabIndex = 4;
            // 
            // pretLblUpdScren
            // 
            this.pretLblUpdScren.AutoSize = true;
            this.pretLblUpdScren.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretLblUpdScren.ForeColor = System.Drawing.Color.White;
            this.pretLblUpdScren.Location = new System.Drawing.Point(618, 742);
            this.pretLblUpdScren.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.pretLblUpdScren.Name = "pretLblUpdScren";
            this.pretLblUpdScren.Size = new System.Drawing.Size(65, 36);
            this.pretLblUpdScren.TabIndex = 3;
            this.pretLblUpdScren.Text = "Pret";
            // 
            // pretTextUpdScren
            // 
            this.pretTextUpdScren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.pretTextUpdScren.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pretTextUpdScren.ForeColor = System.Drawing.Color.White;
            this.pretTextUpdScren.Location = new System.Drawing.Point(618, 787);
            this.pretTextUpdScren.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pretTextUpdScren.Name = "pretTextUpdScren";
            this.pretTextUpdScren.Size = new System.Drawing.Size(106, 31);
            this.pretTextUpdScren.TabIndex = 4;
            // 
            // CantLblUpdScren
            // 
            this.CantLblUpdScren.AutoSize = true;
            this.CantLblUpdScren.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantLblUpdScren.ForeColor = System.Drawing.Color.White;
            this.CantLblUpdScren.Location = new System.Drawing.Point(874, 742);
            this.CantLblUpdScren.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CantLblUpdScren.Name = "CantLblUpdScren";
            this.CantLblUpdScren.Size = new System.Drawing.Size(126, 36);
            this.CantLblUpdScren.TabIndex = 3;
            this.CantLblUpdScren.Text = "Cantitate";
            // 
            // CantTextUpdScren
            // 
            this.CantTextUpdScren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.CantTextUpdScren.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantTextUpdScren.ForeColor = System.Drawing.Color.White;
            this.CantTextUpdScren.Location = new System.Drawing.Point(874, 787);
            this.CantTextUpdScren.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CantTextUpdScren.Name = "CantTextUpdScren";
            this.CantTextUpdScren.Size = new System.Drawing.Size(144, 31);
            this.CantTextUpdScren.TabIndex = 4;
            // 
            // currencyUpdScren
            // 
            this.currencyUpdScren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.currencyUpdScren.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyUpdScren.ForeColor = System.Drawing.Color.White;
            this.currencyUpdScren.FormattingEnabled = true;
            this.currencyUpdScren.Items.AddRange(new object[] {
            "RON",
            "EUR",
            "USD"});
            this.currencyUpdScren.Location = new System.Drawing.Point(738, 781);
            this.currencyUpdScren.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.currencyUpdScren.Name = "currencyUpdScren";
            this.currencyUpdScren.Size = new System.Drawing.Size(120, 40);
            this.currencyUpdScren.TabIndex = 11;
            this.currencyUpdScren.SelectedIndexChanged += new System.EventHandler(this.currencyUpdScren_SelectedIndexChanged);
            // 
            // updateButtonUpdScren
            // 
            this.updateButtonUpdScren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.updateButtonUpdScren.FlatAppearance.BorderSize = 0;
            this.updateButtonUpdScren.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.updateButtonUpdScren.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.updateButtonUpdScren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButtonUpdScren.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButtonUpdScren.ForeColor = System.Drawing.Color.Transparent;
            this.updateButtonUpdScren.Image = global::InterfataUtilizator_WindowsForms.Properties.Resources.update;
            this.updateButtonUpdScren.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateButtonUpdScren.Location = new System.Drawing.Point(508, 869);
            this.updateButtonUpdScren.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.updateButtonUpdScren.Name = "updateButtonUpdScren";
            this.updateButtonUpdScren.Size = new System.Drawing.Size(272, 87);
            this.updateButtonUpdScren.TabIndex = 12;
            this.updateButtonUpdScren.Text = "Actualizare";
            this.updateButtonUpdScren.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateButtonUpdScren.UseVisualStyleBackColor = false;
            this.updateButtonUpdScren.Click += new System.EventHandler(this.updateButtonUpdScren_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1244, 704);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateButtonUpdScren);
            this.Controls.Add(this.currencyUpdScren);
            this.Controls.Add(this.CantTextUpdScren);
            this.Controls.Add(this.CantLblUpdScren);
            this.Controls.Add(this.pretTextUpdScren);
            this.Controls.Add(this.pretLblUpdScren);
            this.Controls.Add(this.numeTextUpdScren);
            this.Controls.Add(this.numeLblUpdScren);
            this.Controls.Add(this.idTextUpdScren);
            this.Controls.Add(this.idLblUpdScren);
            this.Controls.Add(this.dataGridViewUpdScren);
            this.Controls.Add(this.ActualizareLabel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UpdateScreen";
            this.Size = new System.Drawing.Size(1446, 1025);
            this.Load += new System.EventHandler(this.UpdateScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdScren)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ActualizareLabel;
        private System.Windows.Forms.DataGridView dataGridViewUpdScren;
        private System.Windows.Forms.Label idLblUpdScren;
        private System.Windows.Forms.TextBox idTextUpdScren;
        private System.Windows.Forms.Label numeLblUpdScren;
        private System.Windows.Forms.TextBox numeTextUpdScren;
        private System.Windows.Forms.Label pretLblUpdScren;
        private System.Windows.Forms.TextBox pretTextUpdScren;
        private System.Windows.Forms.Label CantLblUpdScren;
        private System.Windows.Forms.TextBox CantTextUpdScren;
        private System.Windows.Forms.ComboBox currencyUpdScren;
        private System.Windows.Forms.Button updateButtonUpdScren;
        private System.Windows.Forms.Button button1;
    }
}
