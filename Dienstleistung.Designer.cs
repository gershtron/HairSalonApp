namespace Hairdressers
{
    partial class Terrmin
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
            this.cbHaarstil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.WeiterBTN = new System.Windows.Forms.Button();
            this.cbLocations = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnENTER = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbHaarstil
            // 
            this.cbHaarstil.FormattingEnabled = true;
            this.cbHaarstil.Location = new System.Drawing.Point(12, 403);
            this.cbHaarstil.Name = "cbHaarstil";
            this.cbHaarstil.Size = new System.Drawing.Size(312, 28);
            this.cbHaarstil.TabIndex = 11;
            this.cbHaarstil.Visible = false;
            this.cbHaarstil.SelectedIndexChanged += new System.EventHandler(this.cbHaarstil_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "DIENSTLEISTUNG AUSWÄHLEN";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "Mitarbeiter Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WeiterBTN
            // 
            this.WeiterBTN.Location = new System.Drawing.Point(12, 437);
            this.WeiterBTN.Name = "WeiterBTN";
            this.WeiterBTN.Size = new System.Drawing.Size(312, 40);
            this.WeiterBTN.TabIndex = 14;
            this.WeiterBTN.Text = "WEITER";
            this.WeiterBTN.UseVisualStyleBackColor = true;
            this.WeiterBTN.Visible = false;
            this.WeiterBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbLocations
            // 
            this.cbLocations.DisplayMember = "Location_name1";
            this.cbLocations.FormattingEnabled = true;
            this.cbLocations.Location = new System.Drawing.Point(11, 118);
            this.cbLocations.Name = "cbLocations";
            this.cbLocations.Size = new System.Drawing.Size(312, 28);
            this.cbLocations.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(94, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "HAAR SALON";
            // 
            // btnENTER
            // 
            this.btnENTER.Location = new System.Drawing.Point(26, 162);
            this.btnENTER.Name = "btnENTER";
            this.btnENTER.Size = new System.Drawing.Size(280, 34);
            this.btnENTER.TabIndex = 17;
            this.btnENTER.Text = "ENTER";
            this.btnENTER.UseVisualStyleBackColor = true;
            this.btnENTER.Click += new System.EventHandler(this.btnENTER_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "LOCATION-ORT AUSWÄHLEN";
            // 
            // Terrmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 293);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnENTER);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLocations);
            this.Controls.Add(this.WeiterBTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHaarstil);
            this.Name = "Terrmin";
            this.Text = "Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cbHaarstil;
        private Label label1;
        private Button button1;
        private Button WeiterBTN;
        private ComboBox cbLocations;
        private Label label2;
        private Button btnENTER;
        private Label label3;
    }
}