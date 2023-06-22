
namespace TesteSimulareAdmitere
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.textBoxUtilizator = new System.Windows.Forms.TextBox();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.labelMesajEroare = new System.Windows.Forms.Label();
            this.buttonCreazaCont = new System.Windows.Forms.Button();
            this.buttonBackToMenu = new System.Windows.Forms.Button();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelPrenume = new System.Windows.Forms.Label();
            this.labelNumeUtilizator = new System.Windows.Forms.Label();
            this.labelParola = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(434, 194);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(172, 22);
            this.textBoxNume.TabIndex = 0;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(822, 277);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(172, 22);
            this.textBoxParola.TabIndex = 1;
            this.textBoxParola.UseSystemPasswordChar = true;
            // 
            // textBoxUtilizator
            // 
            this.textBoxUtilizator.Location = new System.Drawing.Point(434, 277);
            this.textBoxUtilizator.Name = "textBoxUtilizator";
            this.textBoxUtilizator.Size = new System.Drawing.Size(172, 22);
            this.textBoxUtilizator.TabIndex = 2;
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.Location = new System.Drawing.Point(822, 194);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(172, 22);
            this.textBoxPrenume.TabIndex = 3;
            // 
            // labelMesajEroare
            // 
            this.labelMesajEroare.AutoSize = true;
            this.labelMesajEroare.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMesajEroare.ForeColor = System.Drawing.Color.Red;
            this.labelMesajEroare.Location = new System.Drawing.Point(323, 588);
            this.labelMesajEroare.Name = "labelMesajEroare";
            this.labelMesajEroare.Size = new System.Drawing.Size(0, 29);
            this.labelMesajEroare.TabIndex = 4;
            // 
            // buttonCreazaCont
            // 
            this.buttonCreazaCont.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonCreazaCont.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonCreazaCont.FlatAppearance.BorderSize = 4;
            this.buttonCreazaCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreazaCont.Font = new System.Drawing.Font("Sitka Small", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreazaCont.ForeColor = System.Drawing.Color.White;
            this.buttonCreazaCont.Location = new System.Drawing.Point(856, 410);
            this.buttonCreazaCont.Name = "buttonCreazaCont";
            this.buttonCreazaCont.Size = new System.Drawing.Size(212, 70);
            this.buttonCreazaCont.TabIndex = 5;
            this.buttonCreazaCont.Text = "CREAZĂ CONT";
            this.buttonCreazaCont.UseVisualStyleBackColor = false;
            this.buttonCreazaCont.Click += new System.EventHandler(this.buttonInregistrare_Click);
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonBackToMenu.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonBackToMenu.FlatAppearance.BorderSize = 4;
            this.buttonBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMenu.Font = new System.Drawing.Font("Sitka Small", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToMenu.ForeColor = System.Drawing.Color.White;
            this.buttonBackToMenu.Location = new System.Drawing.Point(887, 516);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(159, 55);
            this.buttonBackToMenu.TabIndex = 6;
            this.buttonBackToMenu.Text = "ÎNAPOI";
            this.buttonBackToMenu.UseVisualStyleBackColor = false;
            this.buttonBackToMenu.Click += new System.EventHandler(this.buttonBackToMenu_Click);
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelNume.Location = new System.Drawing.Point(367, 144);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(74, 29);
            this.labelNume.TabIndex = 7;
            this.labelNume.Text = "Nume";
            // 
            // labelPrenume
            // 
            this.labelPrenume.AutoSize = true;
            this.labelPrenume.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenume.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelPrenume.Location = new System.Drawing.Point(782, 144);
            this.labelPrenume.Name = "labelPrenume";
            this.labelPrenume.Size = new System.Drawing.Size(105, 29);
            this.labelPrenume.TabIndex = 8;
            this.labelPrenume.Text = "Prenume";
            // 
            // labelNumeUtilizator
            // 
            this.labelNumeUtilizator.AutoSize = true;
            this.labelNumeUtilizator.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeUtilizator.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelNumeUtilizator.Location = new System.Drawing.Point(367, 236);
            this.labelNumeUtilizator.Name = "labelNumeUtilizator";
            this.labelNumeUtilizator.Size = new System.Drawing.Size(176, 29);
            this.labelNumeUtilizator.TabIndex = 9;
            this.labelNumeUtilizator.Text = "NumeUtilizator";
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParola.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelParola.Location = new System.Drawing.Point(798, 236);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(80, 29);
            this.labelParola.TabIndex = 10;
            this.labelParola.Text = "Parolă";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1349, 733);
            this.Controls.Add(this.labelParola);
            this.Controls.Add(this.labelNumeUtilizator);
            this.Controls.Add(this.labelPrenume);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.buttonBackToMenu);
            this.Controls.Add(this.buttonCreazaCont);
            this.Controls.Add(this.labelMesajEroare);
            this.Controls.Add(this.textBoxPrenume);
            this.Controls.Add(this.textBoxUtilizator);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxNume);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.TextBox textBoxUtilizator;
        private System.Windows.Forms.TextBox textBoxPrenume;
        private System.Windows.Forms.Label labelMesajEroare;
        private System.Windows.Forms.Button buttonCreazaCont;
        private System.Windows.Forms.Button buttonBackToMenu;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelPrenume;
        private System.Windows.Forms.Label labelNumeUtilizator;
        private System.Windows.Forms.Label labelParola;
    }
}