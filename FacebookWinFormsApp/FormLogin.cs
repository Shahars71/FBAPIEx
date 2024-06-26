﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        LoginResult m_LoginResult;
        

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_LoginResult == null)
            {
                if (login())
                {
                    FormMain form1 = new FormMain(m_LoginResult.LoggedInUser);
                    form1.ShowDialog();
                }
                else
                {
                    m_LoginResult = null;
                }
            }

        }

        private bool login()
        {
            try
            {
                m_LoginResult = FacebookService.Login(
               /// (This is Desig Patter's App ID. replace it with your own)
               textBoxAppID.Text,
               /// requested permissions:
               "email",
               "public_profile",
               "user_posts",
               "user_hometown",
               "user_birthday",
               "user_age_range",
               "user_gender",
               "user_link",
               "user_friends",  
               "user_location",
               "user_likes",
               "public_profile",
               "user_photos",
               "user_videos"
               /// add any relevant permissions
               );

                if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
                {
                    if (m_LoginResult.LoggedInUser != null)
                    {
                        buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                        buttonLogin.BackColor = Color.LightGreen;
                        pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
                        buttonLogin.Enabled = false;
                        buttonLogout.Enabled = true;
                    }
                    else
                    {
                        return false;
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
           
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }

        private void textBoxAppID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
