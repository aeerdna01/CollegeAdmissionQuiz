/**************************************************************************
 *                                                                        *
 *  File:        StartStateForm.cs                                        *
 *  Copyright:   (c) 2023, Hușman Carla-Gabriela                          *
 *  E-mail:      carla-gabriela.husman@student.tuiasi.ro                  *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

using QuizState;
using System;
using System.Windows.Forms;

namespace TesteSimulareAdmitere
{
    /// <summary>
    /// Clasa StartStateForm reprezintă interfața grafică de start a quiz-ului, care permite utilizatorului să selecteze
    /// materia pentru test și să acceseze setările.
    /// </summary>
    public partial class StartStateForm : Form
    {
        #region Public Member Variables
        public QuestionStateForm questionStateForm;
        #endregion

        #region Constructors
        /// <summary>
        /// Inițializează o nouă instanță a clasei StartStateForm.
        /// </summary>
        public StartStateForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.questionStateForm = new QuestionStateForm();
        }
        #endregion

        #region Callback Methods
        /// <summary>
        /// Este apelată atunci când utilizatorul selectează materia de test "Matematică".
        /// Această metodă setează contextul quizContext cu întrebările de matematică generate,
        /// apoi setează starea quizContext pe QuestionState și afișează starea curentă.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonMate_Click(object sender, EventArgs e)
        {
            questionStateForm.labelMaterie.Text = "Matematică";
            questionStateForm.timerTest.Enabled = true;
            TesteSimulareAdmitere.quizContext.SetQuestion(QuestionManager.QuestionManager.GenerateMathQuestions());
            questionStateForm.PutQuestions();
            TesteSimulareAdmitere.quizContext.SetState(new QuestionState());
            TesteSimulareAdmitere.quizContext.DisplayState(this);
        }

        /// <summary>
        /// Este apelată atunci când utilizatorul selectează materia de test "Informatică".
        /// Această metodă setează contextul quizContext cu întrebările de informatică generate,
        /// apoi setează starea quizContext pe QuestionState și afișează starea curentă.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            questionStateForm.labelMaterie.Text = "Informatică";
            questionStateForm.timerTest.Enabled = true;
            TesteSimulareAdmitere.quizContext.SetQuestion(QuestionManager.QuestionManager.GenerateInfoQuestions());
            questionStateForm.PutQuestions();
            TesteSimulareAdmitere.quizContext.SetState(new QuestionState());
            TesteSimulareAdmitere.quizContext.DisplayState(this);
        }

        /// <summary>
        /// Este apelată atunci când utilizatorul dorește să acceseze setările.
        /// Această metodă deschide fereastra SeettingForm.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonSetari_Click(object sender, EventArgs e)
        {
            buttonInfo.Enabled = true;
            buttonMate.Enabled = true;
            SettingsForm settingsForm = new SettingsForm(questionStateForm);
            settingsForm.Show(this);
        }

        /// <summary>
        /// Este apelată atunci utilizatorul dorește deconectarea din aplicație.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonDeconectare_Click(object sender, EventArgs e)
        {
            TesteSimulareAdmitere testeSimulareAdmitere = new TesteSimulareAdmitere();
            testeSimulareAdmitere.Show(this);
            this.Hide();
        }
        #endregion
    }
}