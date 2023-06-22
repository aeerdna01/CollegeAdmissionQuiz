
namespace TesteSimulareAdmitere
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.textBoxUtilizator = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.buttonIntraInCont = new System.Windows.Forms.Button();
            this.labelMesajEroare = new System.Windows.Forms.Label();
            this.buttonBackToMenu = new System.Windows.Forms.Button();
            this.labelNumeUtilizator = new System.Windows.Forms.Label();
            this.labelParola = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUtilizator
            // 
            this.textBoxUtilizator.Location = new System.Drawing.Point(573, 193);
            this.textBoxUtilizator.Name = "textBoxUtilizator";
            this.textBoxUtilizator.Size = new System.Drawing.Size(162, 22);
            this.textBoxUtilizator.TabIndex = 0;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(573, 317);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(162, 22);
            this.textBoxParola.TabIndex = 1;
            this.textBoxParola.UseSystemPasswordChar = true;
            // 
            // buttonIntraInCont
            // 
            this.buttonIntraInCont.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonIntraInCont.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonIntraInCont.FlatAppearance.BorderSize = 4;
            this.buttonIntraInCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIntraInCont.Font = new System.Drawing.Font("Sitka Small", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIntraInCont.ForeColor = System.Drawing.Color.White;
            this.buttonIntraInCont.Location = new System.Drawing.Point(713, 378);
            this.buttonIntraInCont.Name = "buttonIntraInCont";
            this.buttonIntraInCont.Size = new System.Drawing.Size(210, 53);
            this.buttonIntraInCont.TabIndex = 2;
            this.buttonIntraInCont.Text = "INTRĂ ÎN CONT ";
            this.buttonIntraInCont.UseVisualStyleBackColor = false;
            this.buttonIntraInCont.Click += new System.EventHandler(this.buttonAutentificare_Click);
            // 
            // labelMesajEroare
            // 
            this.labelMesajEroare.AutoSize = true;
            this.labelMesajEroare.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMesajEroare.ForeColor = System.Drawing.Color.Red;
            this.labelMesajEroare.Location = new System.Drawing.Point(301, 531);
            this.labelMesajEroare.Name = "labelMesajEroare";
            this.labelMesajEroare.Size = new System.Drawing.Size(0, 29);
            this.labelMesajEroare.TabIndex = 3;
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonBackToMenu.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonBackToMenu.FlatAppearance.BorderSize = 4;
            this.buttonBackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMenu.Font = new System.Drawing.Font("Sitka Small", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToMenu.ForeColor = System.Drawing.Color.White;
            this.buttonBackToMenu.Location = new System.Drawing.Point(781, 453);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(121, 50);
            this.buttonBackToMenu.TabIndex = 4;
            this.buttonBackToMenu.Text = "ÎNAPOI";
            this.buttonBackToMenu.UseVisualStyleBackColor = false;
            this.buttonBackToMenu.Click += new System.EventHandler(this.buttonBackToMenu_Click_1);
            // 
            // labelNumeUtilizator
            // 
            this.labelNumeUtilizator.AutoSize = true;
            this.labelNumeUtilizator.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeUtilizator.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelNumeUtilizator.Location = new System.Drawing.Point(440, 149);
            this.labelNumeUtilizator.Name = "labelNumeUtilizator";
            this.labelNumeUtilizator.Size = new System.Drawing.Size(179, 29);
            this.labelNumeUtilizator.TabIndex = 5;
            this.labelNumeUtilizator.Text = "Nume utilizator";
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParola.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelParola.Location = new System.Drawing.Point(539, 274);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(80, 29);
            this.labelParola.TabIndex = 6;
            this.labelParola.Text = "Parolă";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1349, 733);
            this.Controls.Add(this.labelParola);
            this.Controls.Add(this.labelNumeUtilizator);
            this.Controls.Add(this.buttonBackToMenu);
            this.Controls.Add(this.labelMesajEroare);
            this.Controls.Add(this.buttonIntraInCont);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxUtilizator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUtilizator;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Button buttonIntraInCont;
        private System.Windows.Forms.Label labelMesajEroare;
        private System.Windows.Forms.Button buttonBackToMenu;
        private System.Windows.Forms.Label labelNumeUtilizator;
        private System.Windows.Forms.Label labelParola;
    }
}