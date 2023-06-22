/**************************************************************************
 *                                                                        *
 *  File:        RegisterForm.cs                                          *
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
using System.Windows.Forms;

namespace TesteSimulareAdmitere
{
    /// <summary>
    /// Clasa RegisterForm gestionează procesul de înregistrare a unui nou utilizator în aplicație.
    /// </summary>
    public partial class RegisterForm : Form
    {
        #region Private Member Variables
        private UserManager.UserManager _userManager;
        #endregion

        #region Constructors
        /// <summary>
        /// Inițializează o nouă instanță a clasei RegisterForm.
        /// </summary>
        /// <param name="userManager">Managerul de utilizatori.</param>
        public RegisterForm(UserManager.UserManager userManager)
        {
            InitializeComponent();
            this._userManager = userManager;
            this.CenterToScreen();
        }
        #endregion

        #region Callback Methods
        /// <summary>
        /// Înregistrarea unui nou utilizator.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonInregistrare_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs())
                {
                    labelMesajEroare.Text = "Toate câmpurile sunt obligatorii!";
                    return;
                }

                if (IsDuplicateUser(textBoxUtilizator.Text))
                {
                    labelMesajEroare.Text = "Nume utilizator deja existent!";
                    return;
                }

                _userManager.AddUser(textBoxNume.Text, textBoxPrenume.Text, textBoxUtilizator.Text, textBoxParola.Text);
                LoginForm loginForm = new LoginForm(_userManager.GetUsers());
                loginForm.Show(this);
                this.Hide();
            }
            catch (Exception ex)
            {
                labelMesajEroare.Text = ex.Message;
            }
        }

        /// <summary>
        /// Deschide fereastra principală a aplicației.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            TesteSimulareAdmitere nextForm = new TesteSimulareAdmitere();
            nextForm.Show(this);
            this.Hide();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Verifică dacă toate campurile de input sunt completate.
        /// </summary>
        /// <returns></returns>
        private bool ValidateInputs()
        {
            return !string.IsNullOrEmpty(textBoxNume.Text) &&
                   !string.IsNullOrEmpty(textBoxPrenume.Text) &&
                   !string.IsNullOrEmpty(textBoxUtilizator.Text) &&
                   !string.IsNullOrEmpty(textBoxParola.Text);
        }

        /// <summary>
        /// Verifică dacă există deja un utilizator cu numele dat ca parametru.
        /// </summary>
        /// <param name="numeUtilizator">Numele de utilizator de verificat.</param>
        /// <returns>Returnează true dacă există deja un utilizator cu acest nume, false altfel.</returns>
        private bool IsDuplicateUser(string numeUtilizator)
        {
            foreach (UserManager.UserManager.User user in _userManager.GetUsers())
            {
                if (numeUtilizator == user.numeUtilizator)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

    }
}