/**************************************************************************
 *                                                                        *
 *  File:        QuestionStateForm.cs                                     *
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
    /// Clasa QuestionStateForm reprezintă interfața grafică pentru momentul în care utilizatorul parcurge quiz-ul.
    /// Se afișează întrebarile și posibilitătile de răspuns.
    /// </summary>
    public partial class QuestionStateForm : Form
    {
        #region Private Member Variables
        private int _index = 0;
        private int raspuns = 1;
        private Question _question;
        #endregion

        #region Public Member Variables
        public List<int> userAnswer;
        public List<Question> allquestions;
        #endregion

        #region Constructors
        /// <summary>
        /// Inițializează o nouă instanță a clasei QuestionStateForm.
        /// </summary>
        public QuestionStateForm()
        {
            InitializeComponent();
            userAnswer = new List<int>();
            allquestions = new List<Question>();   
            this.CenterToScreen();
        }
        #endregion

        #region Callback Methods
        /// <summary>
        /// Se apelează atunci când se încarcă form-ul pentru quiz.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void QuestionStateForm_Load(object sender, EventArgs e)
        {
            _question = TesteSimulareAdmitere.quizContext.GetQuestion(0);
            pictureBoxTest.Height = _question.image.Height;
            pictureBoxTest.Image = _question.image;
            progressBarQuiz.Maximum = 10;
            progressBarQuiz.Value = 0;
        }

        /// <summary>
        /// Se apelează atunci când utilizatorul parcurge întrebările.
        /// Verifică răspunsul utilizatorului și actualizează următoarea întrebare.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            progressBarQuiz.Value++;

            if (_index == 9)
            {
                buttonNext.Text = "Finalizează testul!";
            }

            if (radioButtonB.Checked == true)
                raspuns = 2;
            else if (radioButtonC.Checked == true)
                raspuns = 3;
            else if (radioButtonD.Checked == true)
                raspuns = 4;
            userAnswer[_index - 1] = raspuns;
            
            if (raspuns == _question.response)
                TesteSimulareAdmitere.quizContext.IncreaseScore();

            if (_index == 10)
            {
    
                TesteSimulareAdmitere.quizContext.SetState(new EndState());
                TesteSimulareAdmitere.quizContext.DisplayState(this);
                timerTest.Enabled = false;
                _index = 0;
                return;
            }

           
            _question = TesteSimulareAdmitere.quizContext.GetQuestion(_index);
            allquestions.Add(_question);
            pictureBoxTest.Height = _question.image.Height;
            pictureBoxTest.Image = _question.image;

            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;
            radioButtonD.Checked = false;
            buttonNext.Enabled = false;

            _index++;
        }

        /// <summary>
        /// Metodă care se apelează atunci când utilizatorul selectează opțiunea A.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void radioButtonA_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButtonA.Checked)
            {
                buttonNext.Enabled = true;
                raspuns = 1;
            }

            if (_index == 0)
            {
                _index++;
                radioButtonA.Checked = false;
                buttonNext.Enabled = false;
                //label1.Text = _index.ToString();
            }
        }

        /// <summary>
        /// Metodă care se apelează atunci când utilizatorul selectează opțiunea B.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void radioButtonB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonB.Checked)
            {
                buttonNext.Enabled = true;
                raspuns = 2;
            }
        }

        /// <summary>
        /// Metodă care se apelează atunci când utilizatorul selectează opțiunea C.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void radioButtonC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonC.Checked)
            {
                buttonNext.Enabled = true;
                raspuns = 3;
            }
        }

        /// <summary>
        /// Metodă care se apelează atunci când utilizatorul selectează opțiunea D.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void radioButtonD_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonD.Checked)
            {
                buttonNext.Enabled = true;
                raspuns = 4;
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Metodă care setează întrebările și adaugă răspunsul utilizatorului într-o listă.
        /// </summary>
        public void PutQuestions()
        {
            for (int i = 0; i < 10; i++)
            {
                userAnswer.Add(0);
                allquestions.Add(TesteSimulareAdmitere.quizContext.GetQuestion(i));
            }
        }
        #endregion
    }
}