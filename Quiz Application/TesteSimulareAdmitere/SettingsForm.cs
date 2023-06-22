/**************************************************************************
 *                                                                        *
 *  File:        SettingsForm.cs                                          *
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

using SettingsStrategy;
using System;
using System.Windows.Forms;

namespace TesteSimulareAdmitere
{
    /// <summary>
    /// Clasa SettingsForm reprezintă o fereastră pentru setările quiz-ului și contextul folosit pentru implementarea șablonului Strategy.
    /// Este folosită pentru a alege modul de timp limitat sau nelimitat înainte de începerea testului.
    /// </summary>
    public partial class SettingsForm : Form
    {
        #region Private Member Variables
        private QuestionStateForm _questionStateForm;
        private Strategy _settingsStrategy;
        #endregion

        #region Constructors
        /// <summary>
        /// Inițializează o nouă instanță a clasei SettingsForm.
        /// </summary>
        /// <param name="_questionStateForm">Form-ul care conține întrebările pentru quiz.</param>
        public SettingsForm(QuestionStateForm _questionStateForm)
        {
            InitializeComponent();
            this._questionStateForm = _questionStateForm;
            this.CenterToScreen();
        }
        #endregion

        #region Callback Methods
        /// <summary>
        /// Se apelează atunci când se apasă butonul de "Aplică" pentru a seta timpul de examinare.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonAplica_Click(object sender, EventArgs e)
        {
            string time = comboBoxTimp.Text;
            if(time == "Timp nelimitat")
            {
                _settingsStrategy = new UnlimitedTimeStrategy();
                _settingsStrategy.SetTimer(_questionStateForm, time);
                this.Close();
            }
            else if (time == "")
            {
                MessageBox.Show("Vă rugăm să selectați o opțiune!");
            }
            else
            {
                _settingsStrategy = new LimitedTimeStrategy();
                _settingsStrategy.SetTimer(_questionStateForm, time);
                this.Close();
            }
        }
        #endregion
    }
}
