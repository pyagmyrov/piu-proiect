namespace InterfataUtilizator_WindowsForms
{
    partial class ToateScreen
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
            this.components = new System.ComponentModel.Container();
            this.acasaLbl = new System.Windows.Forms.Label();
            this.dataGridMedicament = new System.Windows.Forms.DataGridView();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.administrareMedicamentFisierTextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrareMedicamentFisierTextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // acasaLbl
            // 
            this.acasaLbl.AutoSize = true;
            this.acasaLbl.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acasaLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.acasaLbl.Location = new System.Drawing.Point(26, 15);
            this.acasaLbl.Name = "acasaLbl";
            this.acasaLbl.Size = new System.Drawing.Size(69, 30);
            this.acasaLbl.TabIndex = 3;
            this.acasaLbl.Text = "Acasa";
            // 
            // dataGridMedicament
            // 
            this.dataGridMedicament.AllowUserToAddRows = false;
            this.dataGridMedicament.AllowUserToDeleteRows = false;
            this.dataGridMedicament.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMedicament.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMedicament.Location = new System.Drawing.Point(31, 108);
            this.dataGridMedicament.Name = "dataGridMedicament";
            this.dataGridMedicament.ReadOnly = true;
            this.dataGridMedicament.Size = new System.Drawing.Size(667, 395);
            this.dataGridMedicament.TabIndex = 4;
            this.dataGridMedicament.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMedicament_CellContentClick);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(315, 506);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // searchText
            // 
            this.searchText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.searchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchText.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.ForeColor = System.Drawing.Color.White;
            this.searchText.Location = new System.Drawing.Point(31, 58);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(266, 35);
            this.searchText.TabIndex = 6;
            this.searchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.searchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchBtn.Image = global::InterfataUtilizator_WindowsForms.Properties.Resources.search;
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchBtn.Location = new System.Drawing.Point(303, 58);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(110, 35);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.Text = "Cauta";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // administrareMedicamentFisierTextBindingSource
            // 
            this.administrareMedicamentFisierTextBindingSource.DataSource = typeof(NivelStocareDate.AdministrareMedicament_FisierText);
            // 
            // ToateScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.dataGridMedicament);
            this.Controls.Add(this.acasaLbl);
            this.Name = "ToateScreen";
            this.Size = new System.Drawing.Size(723, 533);
            this.Load += new System.EventHandler(this.ToateScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrareMedicamentFisierTextBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label acasaLbl;
        private System.Windows.Forms.BindingSource administrareMedicamentFisierTextBindingSource;
        private System.Windows.Forms.DataGridView dataGridMedicament;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button searchBtn;
    }
}
