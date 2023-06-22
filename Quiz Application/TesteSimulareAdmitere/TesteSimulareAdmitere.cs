/**************************************************************************
 *                                                                        *
 *  File:        TesteSimulareAdmitere.cs                                 *
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
using System.IO;
using System.Windows.Forms;
using DataBaseConnection;

namespace TesteSimulareAdmitere
{
    /// <summary>
    /// Clasa TesteSimulareAdmitere reprezintă interfața grafică principală a aplicației și gestionarea interacțiunii cu utilizatorul.    
    /// </summary>
    public partial class TesteSimulareAdmitere : Form
    {
        #region Private Member Variables
        private DataBaseManager _db;
        private UserManager.UserManager _userManager;
        #endregion

        #region Public Member Variables
        public static QuizContext.QuizContext quizContext;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructorul clasei TesteSimulareAdmitere. 
        /// </summary>
        public TesteSimulareAdmitere()
        {

            InitializeComponent();
            _db = DataBaseManager.GetInstance();
            _userManager = new UserManager.UserManager();
            quizContext = new QuizContext.QuizContext();
            this.CenterToScreen();
        }
        #endregion

        #region Callback Methods
        /// <summary>
        /// Metoda apelată la apăsarea butonului de Autentificare. Deschide fereastra de autentificare.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonAutentificare_Click(object sender, EventArgs e)
        {
            _db = DataBaseManager.GetInstance();
            LoginForm loginForm = new LoginForm(_userManager.GetUsers());
            loginForm.Show(this);
            this.Hide();
        }

        /// <summary>
        /// Metoda apelată la apăsarea butonului de Înregistrare. Deschide fereastra de înregistrare.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonInregistrare_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(_userManager);
            registerForm.Show(this);
            this.Hide();
        }

        /// <summary>
        /// Metoda apelată la apăsarea butonului de Ieșire. Închide aplicația.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseManager.GetInstance().CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            Application.Exit();
        }

        /// <summary>
        /// Metoda apelată la apăsarea butonului de Help.
        /// Oferă informații utilizatorului despre cum se folosește aplicația.
        /// </summary>
        /// <param name="sender">Obiectul care a declanșat evenimentul.</param>
        /// <param name="e">Argumentele evenimentului.</param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Teste simulare admitere.chm");
            Help.ShowHelp(this, filePath);
        }

        #endregion
    }
}