
namespace TesteSimulareAdmitere
{
    partial class EndStateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndStateForm));
            this.labelRezultat = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelAdminRespins = new System.Windows.Forms.Label();
            this.pictureBoxIntrebare = new System.Windows.Forms.PictureBox();
            this.buttonInapoi = new System.Windows.Forms.Button();
            this.buttonInainte = new System.Windows.Forms.Button();
            this.labelRaspunsFinal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIntrebare)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRezultat
            // 
            this.labelRezultat.AutoSize = true;
            this.labelRezultat.Font = new System.Drawing.Font("Sitka Small", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRezultat.ForeColor = System.Drawing.Color.Black;
            this.labelRezultat.Location = new System.Drawing.Point(588, 26);
            this.labelRezultat.Name = "labelRezultat";
            this.labelRezultat.Size = new System.Drawing.Size(182, 25);
            this.labelRezultat.TabIndex = 0;
            this.labelRezultat.Text = "Aici va fi rezultatul";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonBack.FlatAppearance.BorderSize = 4;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Sitka Small", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(1169, 49);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(152, 43);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Întoarcere";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelAdminRespins
            // 
            this.labelAdminRespins.AutoSize = true;
            this.labelAdminRespins.Font = new System.Drawing.Font("Sitka Small", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminRespins.ForeColor = System.Drawing.Color.Black;
            this.labelAdminRespins.Location = new System.Drawing.Point(586, 58);
            this.labelAdminRespins.Name = "labelAdminRespins";
            this.labelAdminRespins.Size = new System.Drawing.Size(171, 25);
            this.labelAdminRespins.TabIndex = 2;
            this.labelAdminRespins.Text = "Admis sau respins";
            // 
            // pictureBoxIntrebare
            // 
            this.pictureBoxIntrebare.Location = new System.Drawing.Point(36, 104);
            this.pictureBoxIntrebare.Name = "pictureBoxIntrebare";
            this.pictureBoxIntrebare.Size = new System.Drawing.Size(1285, 525);
            this.pictureBoxIntrebare.TabIndex = 3;
            this.pictureBoxIntrebare.TabStop = false;
            // 
            // buttonInapoi
            // 
            this.buttonInapoi.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonInapoi.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonInapoi.FlatAppearance.BorderSize = 4;
            this.buttonInapoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInapoi.Font = new System.Drawing.Font("Sitka Small", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInapoi.ForeColor = System.Drawing.Color.White;
            this.buttonInapoi.Location = new System.Drawing.Point(1, 104);
            this.buttonInapoi.Name = "buttonInapoi";
            this.buttonInapoi.Size = new System.Drawing.Size(33, 525);
            this.buttonInapoi.TabIndex = 4;
            this.buttonInapoi.Text = "<";
            this.buttonInapoi.UseVisualStyleBackColor = false;
            this.buttonInapoi.Click += new System.EventHandler(this.buttonInapoi_Click);
            // 
            // buttonInainte
            // 
            this.buttonInainte.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonInainte.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonInainte.FlatAppearance.BorderSize = 4;
            this.buttonInainte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInainte.Font = new System.Drawing.Font("Sitka Small", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInainte.ForeColor = System.Drawing.Color.White;
            this.buttonInainte.Location = new System.Drawing.Point(1327, 104);
            this.buttonInainte.Name = "buttonInainte";
            this.buttonInainte.Size = new System.Drawing.Size(35, 525);
            this.buttonInainte.TabIndex = 5;
            this.buttonInainte.Text = ">";
            this.buttonInainte.UseVisualStyleBackColor = false;
            this.buttonInainte.Click += new System.EventHandler(this.buttonInainte_Click);
            // 
            // labelRaspunsFinal
            // 
            this.labelRaspunsFinal.AutoSize = true;
            this.labelRaspunsFinal.Font = new System.Drawing.Font("Sitka Small", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRaspunsFinal.Location = new System.Drawing.Point(21, 673);
            this.labelRaspunsFinal.Name = "labelRaspunsFinal";
            this.labelRaspunsFinal.Size = new System.Drawing.Size(135, 25);
            this.labelRaspunsFinal.TabIndex = 7;
            this.labelRaspunsFinal.Text = "Raspuns Final";
            // 
            // EndStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1363, 733);
            this.Controls.Add(this.labelRaspunsFinal);
            this.Controls.Add(this.buttonInainte);
            this.Controls.Add(this.buttonInapoi);
            this.Controls.Add(this.pictureBoxIntrebare);
            this.Controls.Add(this.labelAdminRespins);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelRezultat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EndStateForm";
            this.Text = "EndStateForm";
            this.Load += new System.EventHandler(this.EndStateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIntrebare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRezultat;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelAdminRespins;
        private System.Windows.Forms.PictureBox pictureBoxIntrebare;
        private System.Windows.Forms.Button buttonInapoi;
        private System.Windows.Forms.Button buttonInainte;
        private System.Windows.Forms.Label labelRaspunsFinal;
    }
}