/**************************************************************************
 *                                                                        *
 *  File:        EndStateForm.cs                                          *
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
using System.Collections.Generic;
using System.Windows.Forms;
using static QuestionManager.QuestionManager;

namespace TesteSimulareAdmitere
{
    /// <summary>
    /// Clasa EndStateForm reprezintă interfața grafică de final a quiz-ului, care permite utilizatorului să vizualizeze
    /// punctajul obținut și să parcurgă testul din nou pentru a vedea răspunsurile corecte.
    /// </summary>
    public partial class EndStateForm : Form
    {
        #region Private Member Variables
        private List<Question> _allQuestions;
        private List<int> _userAnswer;
        private int index = 0;
        #endregion

        #region Constructors
        /// <summary>
        /// Inițializează o nouă instanță a clasei EndStateForm.
        /// </summary>
        /// <param name="allQuestions">Lista de întrebări.</param>
        /// <param name="userAnswer">Lista de răspunsuri ale utilizatorului.</param>
        public EndStateForm(List<Question> allQuestions, List<int> userAnswer)
        {
            InitializeComponent();
            this.CenterToScreen();
            _allQuestions = allQuestions;
            _userAnswer = userAnswer;
        }
        #endregion

        #region Callback Methods
        /// <summary>
        /// Se apelează la încărcarea form-ului și care afișează scorul și răspunsurile corecte.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void EndStateForm_Load(object sender, EventArgs e)
        {
            int score = TesteSimulareAdmitere.quizContext.GetScore();
            labelRezultat.Text =  "Rezultatul: " + score + "/10";

            if (score >= 5)
                labelAdminRespins.Text = "Admis";
            else
                labelAdminRespins.Text = "Respins";

            ShowQuestionAnswer();
        }

        /// <summary>
        /// Se apelează când utilizatorul apasă butonul "Meniu".
        /// Aceasta resetează scorul și încarcă din nou starea de început a aplicației cu posibilitatea susținerii unui nou test.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            TesteSimulareAdmitere.quizContext.SetScore();
            TesteSimulareAdmitere.quizContext.SetState(new StartState());
            TesteSimulareAdmitere.quizContext.DisplayState(this);
        }

        /// <summary>
        /// Se apelează când utilizatorul apasă butonul "Înainte".
        /// Aceasta afișează întrebarea și răspunsul următor.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonInainte_Click(object sender, EventArgs e)
        {
            if (index < 9)
            {
                index++;
                ShowQuestionAnswer();
            }
        }

        /// <summary>
        /// Se apelează când utilizatorul apasă butonul "Înapoi".
        /// Aceasta afișează întrebarea și răspunsul anterior.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                ShowQuestionAnswer();
            }
        }
        #endregion

        #region PrivateMethods
        /// <summary>
        /// Se verifică răspunsul utilizatorului și se afișează informații corespunzătoare despre răspunsul corect și răspunsul utilizatorului. 
        /// </summary>
        private void ShowQuestionAnswer()
        {
            pictureBoxIntrebare.Image = _allQuestions[index].image;
            pictureBoxIntrebare.Height = _allQuestions[index].image.Height;
            buttonInapoi.Height = _allQuestions[index].image.Height;
            buttonInainte.Height = _allQuestions[index].image.Height;

            if (_userAnswer[index] == 0)
            {
                labelRaspunsFinal.Text = "Nu ai răspuns încă la această întrebare.";
                labelRaspunsFinal.ForeColor = System.Drawing.Color.YellowGreen;
            }
            else if (_allQuestions[index].response == _userAnswer[index])
            {           
                labelRaspunsFinal.Text = "Răspuns corect: " + char.ConvertFromUtf32(64 + _allQuestions[index].response);
                labelRaspunsFinal.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                labelRaspunsFinal.Text = "Răspuns corect: " + char.ConvertFromUtf32(64 + _allQuestions[index].response) + Environment.NewLine + "Ai răspuns: " + char.ConvertFromUtf32(64 + _userAnswer[index]);
                labelRaspunsFinal.ForeColor = System.Drawing.Color.Red;
            }
        }
        #endregion
    }
}
