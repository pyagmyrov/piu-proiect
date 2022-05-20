using System.Collections.Generic;
namespace InterfataUtilizator_WindowsForms
{
    partial class Farmacia
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
            this.menu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.despreButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.AcasaBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toateScreen2 = new InterfataUtilizator_WindowsForms.ToateScreen();
            this.despreScreen1 = new InterfataUtilizator_WindowsForms.DespreScreen();
            this.updateScreen1 = new InterfataUtilizator_WindowsForms.UpdateScreen();
            this.addScreen1 = new InterfataUtilizator_WindowsForms.AddScreen();
            this.menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.menu.Controls.Add(this.panel2);
            this.menu.Controls.Add(this.panel1);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(1, 1);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(200, 536);
            this.menu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel2.Controls.Add(this.despreButton);
            this.panel2.Controls.Add(this.updateButton);
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Controls.Add(this.AcasaBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 430);
            this.panel2.TabIndex = 1;
            // 
            // despreButton
            // 
            this.despreButton.BackColor = System.Drawing.Color.Transparent;
            this.despreButton.FlatAppearance.BorderSize = 0;
            this.despreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.despreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.despreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.despreButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.despreButton.ForeColor = System.Drawing.Color.Transparent;
            this.despreButton.Image = global::InterfataUtilizator_WindowsForms.Properties.Resources.aboutMe;
            this.despreButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.despreButton.Location = new System.Drawing.Point(12, 137);
            this.despreButton.Name = "despreButton";
            this.despreButton.Size = new System.Drawing.Size(175, 37);
            this.despreButton.TabIndex = 0;
            this.despreButton.Text = "Despre";
            this.despreButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.despreButton.UseVisualStyleBackColor = false;
            this.despreButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Transparent;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.updateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.Transparent;
            this.updateButton.Image = global::InterfataUtilizator_WindowsForms.Properties.Resources.update;
            this.updateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateButton.Location = new System.Drawing.Point(12, 94);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(175, 37);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "Actualizare";
            this.updateButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Transparent;
            this.addButton.Image = global::InterfataUtilizator_WindowsForms.Properties.Resources.add1;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.Location = new System.Drawing.Point(12, 51);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(175, 37);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Adaugare";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AcasaBtn
            // 
            this.AcasaBtn.BackColor = System.Drawing.Color.Transparent;
            this.AcasaBtn.FlatAppearance.BorderSize = 0;
            this.AcasaBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.AcasaBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.AcasaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcasaBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcasaBtn.ForeColor = System.Drawing.Color.Transparent;
            this.AcasaBtn.Image = global::InterfataUtilizator_WindowsForms.Properties.Resources.home1;
            this.AcasaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AcasaBtn.Location = new System.Drawing.Point(12, 8);
            this.AcasaBtn.Name = "AcasaBtn";
            this.AcasaBtn.Size = new System.Drawing.Size(175, 37);
            this.AcasaBtn.TabIndex = 0;
            this.AcasaBtn.Text = "Toate";
            this.AcasaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AcasaBtn.UseVisualStyleBackColor = false;
            this.AcasaBtn.Click += new System.EventHandler(this.Acasa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.BackColor = System.Drawing.Color.Transparent;
            this.logoLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logoLabel.Location = new System.Drawing.Point(58, 69);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(90, 25);
            this.logoLabel.TabIndex = 1;
            this.logoLabel.Text = "Farmacia";
            this.logoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfataUtilizator_WindowsForms.Properties.Resources.logo1;
            this.pictureBox1.InitialImage = global::InterfataUtilizator_WindowsForms.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(71, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toateScreen2
            // 
            this.toateScreen2.AutoSize = true;
            this.toateScreen2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.toateScreen2.Location = new System.Drawing.Point(207, 5);
            this.toateScreen2.Name = "toateScreen2";
            this.toateScreen2.Size = new System.Drawing.Size(724, 532);
            this.toateScreen2.TabIndex = 5;
            this.toateScreen2.Load += new System.EventHandler(this.toateScreen2_Load);
            // 
            // despreScreen1
            // 
            this.despreScreen1.AutoSize = true;
            this.despreScreen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.despreScreen1.Location = new System.Drawing.Point(208, 5);
            this.despreScreen1.Name = "despreScreen1";
            this.despreScreen1.Size = new System.Drawing.Size(723, 533);
            this.despreScreen1.TabIndex = 4;
            // 
            // updateScreen1
            // 
            this.updateScreen1.AutoSize = true;
            this.updateScreen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.updateScreen1.Location = new System.Drawing.Point(208, 5);
            this.updateScreen1.Name = "updateScreen1";
            this.updateScreen1.Size = new System.Drawing.Size(723, 533);
            this.updateScreen1.TabIndex = 3;
            // 
            // addScreen1
            // 
            this.addScreen1.AutoSize = true;
            this.addScreen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.addScreen1.Location = new System.Drawing.Point(208, 5);
            this.addScreen1.Name = "addScreen1";
            this.addScreen1.Size = new System.Drawing.Size(723, 533);
            this.addScreen1.TabIndex = 2;
            // 
            // Farmacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(935, 538);
            this.Controls.Add(this.toateScreen2);
            this.Controls.Add(this.despreScreen1);
            this.Controls.Add(this.updateScreen1);
            this.Controls.Add(this.addScreen1);
            this.Controls.Add(this.menu);
            this.Name = "Farmacia";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacia";
            this.Load += new System.EventHandler(this.Farmacia_Load);
            this.menu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AcasaBtn;
        private System.Windows.Forms.Button despreButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private AddScreen addScreen1;
        private UpdateScreen updateScreen1;
        private DespreScreen despreScreen1;
        private ToateScreen toateScreen2;
    }
}

