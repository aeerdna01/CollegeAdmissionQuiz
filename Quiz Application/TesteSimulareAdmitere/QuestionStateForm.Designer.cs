
namespace TesteSimulareAdmitere
{
    partial class QuestionStateForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionStateForm));
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.labelMaterie = new System.Windows.Forms.Label();
            this.pictureBoxTest = new System.Windows.Forms.PictureBox();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.buttonNext = new System.Windows.Forms.Button();
            this.progressBarQuiz = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTest)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMaterie
            // 
            this.labelMaterie.AutoSize = true;
            this.labelMaterie.Font = new System.Drawing.Font("Sitka Small", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaterie.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelMaterie.Location = new System.Drawing.Point(12, 9);
            this.labelMaterie.Name = "labelMaterie";
            this.labelMaterie.Size = new System.Drawing.Size(196, 28);
            this.labelMaterie.TabIndex = 0;
            this.labelMaterie.Text = "Denumire Materie";
            // 
            // pictureBoxTest
            // 
            this.pictureBoxTest.Location = new System.Drawing.Point(0, 62);
            this.pictureBoxTest.Name = "pictureBoxTest";
            this.pictureBoxTest.Size = new System.Drawing.Size(1348, 499);
            this.pictureBoxTest.TabIndex = 1;
            this.pictureBoxTest.TabStop = false;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Font = new System.Drawing.Font("Sitka Small", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonA.Location = new System.Drawing.Point(160, 592);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(45, 29);
            this.radioButtonA.TabIndex = 2;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "A";
            this.radioButtonA.UseVisualStyleBackColor = true;
            this.radioButtonA.CheckedChanged += new System.EventHandler(this.radioButtonA_CheckedChanged);
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Font = new System.Drawing.Font("Sitka Small", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonB.Location = new System.Drawing.Point(473, 592);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(45, 29);
            this.radioButtonB.TabIndex = 3;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "B";
            this.radioButtonB.UseVisualStyleBackColor = true;
            this.radioButtonB.CheckedChanged += new System.EventHandler(this.radioButtonB_CheckedChanged);
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Font = new System.Drawing.Font("Sitka Small", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonC.Location = new System.Drawing.Point(847, 592);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(44, 29);
            this.radioButtonC.TabIndex = 4;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "C";
            this.radioButtonC.UseVisualStyleBackColor = true;
            this.radioButtonC.CheckedChanged += new System.EventHandler(this.radioButtonC_CheckedChanged);
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Font = new System.Drawing.Font("Sitka Small", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonD.Location = new System.Drawing.Point(1104, 592);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(46, 29);
            this.radioButtonD.TabIndex = 5;
            this.radioButtonD.Text = "D";
            this.radioButtonD.UseVisualStyleBackColor = true;
            this.radioButtonD.CheckedChanged += new System.EventHandler(this.radioButtonD_CheckedChanged);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonNext.Enabled = false;
            this.buttonNext.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.buttonNext.FlatAppearance.BorderSize = 4;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Sitka Small", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(1086, 655);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(232, 48);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Următoarea întrebare";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // progressBarQuiz
            // 
            this.progressBarQuiz.BackColor = System.Drawing.Color.SteelBlue;
            this.progressBarQuiz.ForeColor = System.Drawing.Color.SteelBlue;
            this.progressBarQuiz.Location = new System.Drawing.Point(449, 660);
            this.progressBarQuiz.Name = "progressBarQuiz";
            this.progressBarQuiz.Size = new System.Drawing.Size(447, 43);
            this.progressBarQuiz.TabIndex = 12;
            // 
            // QuestionStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1349, 733);
            this.Controls.Add(this.progressBarQuiz);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.radioButtonD);
            this.Controls.Add(this.radioButtonC);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.radioButtonA);
            this.Controls.Add(this.pictureBoxTest);
            this.Controls.Add(this.labelMaterie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuestionStateForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.QuestionStateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer timerTest;
        public System.Windows.Forms.Label labelMaterie;
        private System.Windows.Forms.PictureBox pictureBoxTest;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.ProgressBar progressBarQuiz;
    }
}