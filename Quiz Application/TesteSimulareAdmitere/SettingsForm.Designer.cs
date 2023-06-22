
namespace TesteSimulareAdmitere
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.buttonAplica = new System.Windows.Forms.Button();
            this.comboBoxTimp = new System.Windows.Forms.ComboBox();
            this.labelAlegeTimp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAplica
            // 
            this.buttonAplica.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonAplica.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAplica.FlatAppearance.BorderSize = 4;
            this.buttonAplica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAplica.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAplica.ForeColor = System.Drawing.Color.White;
            this.buttonAplica.Location = new System.Drawing.Point(616, 178);
            this.buttonAplica.Name = "buttonAplica";
            this.buttonAplica.Size = new System.Drawing.Size(128, 49);
            this.buttonAplica.TabIndex = 0;
            this.buttonAplica.Text = "APLICĂ";
            this.buttonAplica.UseVisualStyleBackColor = false;
            this.buttonAplica.Click += new System.EventHandler(this.buttonAplica_Click);
            // 
            // comboBoxTimp
            // 
            this.comboBoxTimp.Font = new System.Drawing.Font("Sitka Small", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTimp.ForeColor = System.Drawing.Color.SteelBlue;
            this.comboBoxTimp.FormattingEnabled = true;
            this.comboBoxTimp.Items.AddRange(new object[] {
            "Timp nelimitat",
            "1 min",
            "2 min",
            "30 min",
            "1 h",
            "2 h",
            "3 h"});
            this.comboBoxTimp.Location = new System.Drawing.Point(177, 79);
            this.comboBoxTimp.Name = "comboBoxTimp";
            this.comboBoxTimp.Size = new System.Drawing.Size(121, 27);
            this.comboBoxTimp.TabIndex = 1;
            // 
            // labelAlegeTimp
            // 
            this.labelAlegeTimp.AutoSize = true;
            this.labelAlegeTimp.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlegeTimp.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelAlegeTimp.Location = new System.Drawing.Point(72, 35);
            this.labelAlegeTimp.Name = "labelAlegeTimp";
            this.labelAlegeTimp.Size = new System.Drawing.Size(153, 29);
            this.labelAlegeTimp.TabIndex = 2;
            this.labelAlegeTimp.Text = "Alege timpul:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 255);
            this.Controls.Add(this.labelAlegeTimp);
            this.Controls.Add(this.comboBoxTimp);
            this.Controls.Add(this.buttonAplica);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAplica;
        private System.Windows.Forms.ComboBox comboBoxTimp;
        private System.Windows.Forms.Label labelAlegeTimp;
    }
}