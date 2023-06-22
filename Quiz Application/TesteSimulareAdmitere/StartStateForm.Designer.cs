
namespace TesteSimulareAdmitere
{
    partial class StartStateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartStateForm));
            this.buttonMate = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonSetari = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeconectare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMate
            // 
            this.buttonMate.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonMate.Enabled = false;
            this.buttonMate.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonMate.FlatAppearance.BorderSize = 4;
            this.buttonMate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMate.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMate.ForeColor = System.Drawing.Color.White;
            this.buttonMate.Location = new System.Drawing.Point(374, 273);
            this.buttonMate.Name = "buttonMate";
            this.buttonMate.Size = new System.Drawing.Size(202, 69);
            this.buttonMate.TabIndex = 0;
            this.buttonMate.Text = "MATEMATICĂ";
            this.buttonMate.UseMnemonic = false;
            this.buttonMate.UseVisualStyleBackColor = false;
            this.buttonMate.Click += new System.EventHandler(this.buttonMate_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonInfo.Enabled = false;
            this.buttonInfo.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonInfo.FlatAppearance.BorderSize = 4;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.ForeColor = System.Drawing.Color.White;
            this.buttonInfo.Location = new System.Drawing.Point(764, 273);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(201, 69);
            this.buttonInfo.TabIndex = 1;
            this.buttonInfo.Text = "INFORMATICĂ";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonSetari
            // 
            this.buttonSetari.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSetari.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSetari.FlatAppearance.BorderSize = 4;
            this.buttonSetari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetari.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetari.ForeColor = System.Drawing.Color.White;
            this.buttonSetari.Location = new System.Drawing.Point(593, 412);
            this.buttonSetari.Name = "buttonSetari";
            this.buttonSetari.Size = new System.Drawing.Size(160, 84);
            this.buttonSetari.TabIndex = 2;
            this.buttonSetari.Text = "SETĂRI";
            this.buttonSetari.UseVisualStyleBackColor = false;
            this.buttonSetari.Click += new System.EventHandler(this.buttonSetari_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(221, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(850, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Înainte de a începe, alege timpul pe care îl dorești pentru parcurgerea simulării" +
    ".";
            // 
            // buttonDeconectare
            // 
            this.buttonDeconectare.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonDeconectare.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonDeconectare.FlatAppearance.BorderSize = 4;
            this.buttonDeconectare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeconectare.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeconectare.ForeColor = System.Drawing.Color.White;
            this.buttonDeconectare.Location = new System.Drawing.Point(876, 560);
            this.buttonDeconectare.Name = "buttonDeconectare";
            this.buttonDeconectare.Size = new System.Drawing.Size(175, 64);
            this.buttonDeconectare.TabIndex = 4;
            this.buttonDeconectare.Text = "Deconectare";
            this.buttonDeconectare.UseVisualStyleBackColor = false;
            this.buttonDeconectare.Click += new System.EventHandler(this.buttonDeconectare_Click);
            // 
            // StartStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1349, 733);
            this.Controls.Add(this.buttonDeconectare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSetari);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonMate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartStateForm";
            this.Text = "OptionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMate;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonSetari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeconectare;
    }
}