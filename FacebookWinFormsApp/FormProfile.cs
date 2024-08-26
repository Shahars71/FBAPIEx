using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;


namespace BasicFacebookFeatures
{
    // $G$ DSN-999 (-5) unused class.
    public partial class FormProfile : Form
    {
        private UserFacade m_User;
        public FormProfile()
        {
            InitializeComponent();
        }

        public FormProfile(UserFacade i_user)
        {
            InitializeComponent();
            m_User = i_user;

            fillProfilePage();
        }

        private void fillProfilePage()
        {
            if (m_User != null)
            {

                userFacadeBindingSource.DataSource = m_User;

                try
                {
                    picBoxProfilePic.LoadAsync(m_User.PictureNormalURL);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
                try
                {
                    var relStat = m_User.RelationshipStatus;
                    if (relStat == "InARelationship"      ||
                        relStat == "Enagaged"             ||
                        relStat == "Married"              ||
                        relStat == "InAnOpenRelationship" ||
                        relStat == "Separated"              )
                    {
                        linkLinkLabel1.Links.Add(0, linkLinkLabel1.Text.Length, linkLinkLabel1.Text);
                        linkLinkLabel1.Text = "Significant Other:\n" + m_User.SignificantOther.Name;

                    }
                    else
                    {
                        linkLinkLabel1.Enabled = false;
                        linkLinkLabel1.Text = "No SO found!";
                        linkLinkLabel1.LinkColor = Color.Black;
                    }

                }
                catch
                {
                    linkLinkLabel1.Enabled = false;
                    linkLinkLabel1.Text = "No SO found!";
                    linkLinkLabel1.LinkColor = Color.Black;
                }

                try
                {
                    if (m_User.Hometown == null)
                    {
                        hometownLabel1.Text = "No home\ntown found!";
                    }
                }
                catch (Exception ex )
                {
                    Console.WriteLine($"{ex.Message}");
                    hometownLabel1.Text = "No home\ntown found!";
                }

                try
                {
                    if (m_User.Location == null)
                    {
                        locationLabel1.Text = "No current\nlocation found!";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                    locationLabel1.Enabled = false;
                    locationLabel1.Text = "No current\nlocation found!";
                }

                try
                {
                    if (m_User.Birthday == null) {
                        birthdayLabel1.Enabled = false;
                        birthdayLabel1.Text = "No birthday found!";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                    birthdayLabel1.Enabled = false;
                    birthdayLabel1.Text = "No birthday found!";
                }

                try
                {
                    if (m_User.Link != null)
                    {
                        linkLabelFBProfile.Text = "View on Facebook";
                    }
                }
                catch
                {
                    linkLabelFBProfile.Enabled = false;
                    linkLabelFBProfile.Text = "Error getting link";
                    linkLabelFBProfile.LinkColor = Color.Black;
                }
                try
                {
                    if (m_User.Email != null)
                    {
                        lblEmail.Text = m_User.Email;
                    }
                    
                }
                catch
                {
                    lblEmail.Text = "Email not found!";
                }
            }
        }
        private void lblSignificantOther_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(m_User.SignificantOther.Link);
            }
            catch
            {
                MessageBox.Show("Data not found!");
            }
            
        }

        private void linkLabelFBProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(m_User.Link);
        }
    }
}
