namespace InterfataUtilizator_WindowsForms
{
    partial class AddScreen
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
            this.AddLabel = new System.Windows.Forms.Label();
            this.NumeText = new System.Windows.Forms.TextBox();
            this.numeLbl = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.pretTxtBox = new System.Windows.Forms.TextBox();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.cantitateTxtBox = new System.Windows.Forms.TextBox();
            this.adaugareMedicamentBtn = new System.Windows.Forms.Button();
            this.currencyDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddLabel.Location = new System.Drawing.Point(26, 15);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(108, 30);
            this.AddLabel.TabIndex = 2;
            this.AddLabel.Text = "Adaugare";
            // 
            // NumeText
            // 
            this.NumeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.NumeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumeText.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeText.ForeColor = System.Drawing.Color.White;
            this.NumeText.Location = new System.Drawing.Point(223, 125);
            this.NumeText.Name = "NumeText";
            this.NumeText.Size = new System.Drawing.Size(229, 35);
            this.NumeText.TabIndex = 3;
            this.NumeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumeText.TextChanged += new System.EventHandler(this.NumeText_TextChanged);
            // 
            // numeLbl
            // 
            this.numeLbl.AutoSize = true;
            this.numeLbl.BackColor = System.Drawing.Color.Transparent;
            this.numeLbl.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeLbl.ForeColor = System.Drawing.Color.White;
            this.numeLbl.Location = new System.Drawing.Point(311, 97);
            this.numeLbl.Name = "numeLbl";
            this.numeLbl.Size = new System.Drawing.Size(63, 25);
            this.numeLbl.TabIndex = 4;
            this.numeLbl.Text = "Nume";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.BackColor = System.Drawing.Color.Transparent;
            this.lblPret.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPret.ForeColor = System.Drawing.Color.White;
            this.lblPret.Location = new System.Drawing.Point(319, 183);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(46, 25);
            this.lblPret.TabIndex = 6;
            this.lblPret.Text = "Pret";
            // 
            // pretTxtBox
            // 
            this.pretTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.pretTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pretTxtBox.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretTxtBox.ForeColor = System.Drawing.Color.White;
            this.pretTxtBox.Location = new System.Drawing.Point(223, 211);
            this.pretTxtBox.Name = "pretTxtBox";
            this.pretTxtBox.Size = new System.Drawing.Size(153, 35);
            this.pretTxtBox.TabIndex = 5;
            this.pretTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pretTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.BackColor = System.Drawing.Color.Transparent;
            this.lblCantitate.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantitate.ForeColor = System.Drawing.Color.White;
            this.lblCantitate.Location = new System.Drawing.Point(298, 265);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(88, 25);
            this.lblCantitate.TabIndex = 8;
            this.lblCantitate.Text = "Cantitate";
            // 
            // cantitateTxtBox
            // 
            this.cantitateTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.cantitateTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cantitateTxtBox.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantitateTxtBox.ForeColor = System.Drawing.Color.White;
            this.cantitateTxtBox.Location = new System.Drawing.Point(223, 296);
            this.cantitateTxtBox.Name = "cantitateTxtBox";
            this.cantitateTxtBox.Size = new System.Drawing.Size(229, 35);
            this.cantitateTxtBox.TabIndex = 7;
            this.cantitateTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cantitateTxtBox.TextChanged += new System.EventHandler(this.cantitateTxtBox_TextChanged);
            // 
            // adaugareMedicamentBtn
            // 
            this.adaugareMedicamentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.adaugareMedicamentBtn.FlatAppearance.BorderSize = 0;
            this.adaugareMedicamentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.adaugareMedicamentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.adaugareMedicamentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adaugareMedicamentBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugareMedicamentBtn.ForeColor = System.Drawing.Color.Transparent;
            this.adaugareMedicamentBtn.Image = global::InterfataUtilizator_WindowsForms.Properties.Resources.add1;
            this.adaugareMedicamentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.adaugareMedicamentBtn.Location = new System.Drawing.Point(287, 356);
            this.adaugareMedicamentBtn.Name = "adaugareMedicamentBtn";
            this.adaugareMedicamentBtn.Size = new System.Drawing.Size(110, 37);
            this.adaugareMedicamentBtn.TabIndex = 9;
            this.adaugareMedicamentBtn.Text = "Adaugare";
            this.adaugareMedicamentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adaugareMedicamentBtn.UseVisualStyleBackColor = false;
            this.adaugareMedicamentBtn.Click += new System.EventHandler(this.adaugareMedicamentBtn_Click);
            // 
            // currencyDropDown
            // 
            this.currencyDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.currencyDropDown.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyDropDown.ForeColor = System.Drawing.Color.White;
            this.currencyDropDown.FormattingEnabled = true;
            this.currencyDropDown.Items.AddRange(new object[] {
            "RON",
            "EUR",
            "USD"});
            this.currencyDropDown.Location = new System.Drawing.Point(382, 211);
            this.currencyDropDown.Name = "currencyDropDown";
            this.currencyDropDown.Size = new System.Drawing.Size(70, 33);
            this.currencyDropDown.TabIndex = 10;
            this.currencyDropDown.SelectedIndexChanged += new System.EventHandler(this.currencyDropDown_SelectedIndexChanged);
            // 
            // AddScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.currencyDropDown);
            this.Controls.Add(this.adaugareMedicamentBtn);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.cantitateTxtBox);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.pretTxtBox);
            this.Controls.Add(this.numeLbl);
            this.Controls.Add(this.NumeText);
            this.Controls.Add(this.AddLabel);
            this.Name = "AddScreen";
            this.Size = new System.Drawing.Size(723, 533);
            this.Load += new System.EventHandler(this.AddScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.TextBox NumeText;
        private System.Windows.Forms.Label numeLbl;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.TextBox pretTxtBox;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.TextBox cantitateTxtBox;
        private System.Windows.Forms.Button adaugareMedicamentBtn;
        private System.Windows.Forms.ComboBox currencyDropDown;
    }
}
