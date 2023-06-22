/**************************************************************************
 *                                                                        *
 *  File:        LoginForm.cs                                             *
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

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TesteSimulareAdmitere
{
    /// <summary>
    /// Clasa LoginForm gestionează procesul de autentificare a unui utilizator în aplicație.
    /// </summary>
    public partial class LoginForm : Form
    {
        #region Private Member Variables
        private List<UserManager.UserManager.User> _users;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructorul clasei LoginForm.
        /// </summary>
        /// <param name="users">Lista utilizatorilor.</param>
        public LoginForm(List<UserManager.UserManager.User> users)
        {
            InitializeComponent();
            this.CenterToScreen();
            this._users = users;
        }
        #endregion

        #region Callback Methods
        /// <summary>
        /// Callback-ul pentru butonul de autentificare.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonAutentificare_Click(object sender, EventArgs e)
        {
            string numeUtilizator = textBoxUtilizator.Text;
            string parola = textBoxParola.Text;

            if (String.IsNullOrEmpty(numeUtilizator) || String.IsNullOrEmpty(parola))
            {
                labelMesajEroare.Text = "Toate câmpurile sunt obligatorii!";
                return;
            }

            bool userExists = false;
            foreach (UserManager.UserManager.User user in _users)
            {
                if (numeUtilizator == user.numeUtilizator && parola == user.parola)
                {
                    userExists = true;
                    break;
                }
            }

            if (userExists)
            {
                labelMesajEroare.Text = "";
                TesteSimulareAdmitere.quizContext.DisplayState(this);
            }
            else
            {
                labelMesajEroare.Text = "Nume utilizator sau parolă incorecte!";
            }
        }

        /// <summary>
        /// Callback-ul pentru butonul de revenire la meniul principal.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonBackToMenu_Click_1(object sender, EventArgs e)
        {
            TesteSimulareAdmitere nextForm = new TesteSimulareAdmitere();
            nextForm.Show(this);
            this.Hide();
        }

        /// <summary>
        /// Callback pentru evenimentul textChanged al textBox-ului pentru numele de utilizator.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void textBoxUtilizator_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        /// <summary>
        /// Callback pentru evenimentul textChanged al textBox-ului pentru parolă.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void textBoxParola_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Este utilizată pentru a valida input-urile introduse de utilizator în câmpurile de nume de utilizator și parolă. 
        /// Dacă unul dintre aceste câmpuri este gol sau necompletat, butonul de autentificare este dezactivat.
        /// În caz contrar, butonul este activat și utilizatorul poate încerca să se autentifice în aplicație.
        /// </summary>
        private void ValidateInputs()
        {
            if (string.IsNullOrEmpty(textBoxUtilizator.Text) || string.IsNullOrEmpty(textBoxParola.Text))
            {

                buttonIntraInCont.Enabled = false;
            }
            else
            {
                buttonIntraInCont.Enabled = true;
            }
        }
        #endregion
    }
}