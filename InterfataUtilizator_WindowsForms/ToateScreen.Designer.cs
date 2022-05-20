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
            this.administrareMedicamentFisierTextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refreshBtn = new System.Windows.Forms.Button();
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
            this.dataGridMedicament.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMedicament.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMedicament.Location = new System.Drawing.Point(31, 76);
            this.dataGridMedicament.Name = "dataGridMedicament";
            this.dataGridMedicament.Size = new System.Drawing.Size(673, 427);
            this.dataGridMedicament.TabIndex = 4;
            this.dataGridMedicament.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMedicament_CellContentClick);
            // 
            // administrareMedicamentFisierTextBindingSource
            // 
            this.administrareMedicamentFisierTextBindingSource.DataSource = typeof(NivelStocareDate.AdministrareMedicament_FisierText);
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
            // ToateScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
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
    }
}
