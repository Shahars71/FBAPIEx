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
    public partial class FormProfile : Form
    {
        private User m_User;
        public FormProfile()
        {
            InitializeComponent();
        }

        public FormProfile(User user)
        {
            InitializeComponent();
            m_User = user;

            fillProfilePage();
        }

        //private System.Windows.Forms.PictureBox picBoxProfilePic;
        //private System.Windows.Forms.Label lblName;
        //private System.Windows.Forms.Label lblBday;
        //private System.Windows.Forms.Label lblGender;
        //private System.Windows.Forms.Label lblRelationship;
        //private System.Windows.Forms.LinkLabel lblSignificantOther;
        //private System.Windows.Forms.TextBox tbBio;
        //private System.Windows.Forms.Label lblHometown;
        //private System.Windows.Forms.Label lblLocation;
        private void fillProfilePage()
        {
            if (m_User != null)
            {
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
                    lblName.Text = m_User.Name;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }

                try
                {
                    lblGender.Text = m_User.Gender.ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }

                try
                {
                    lblRelationship.Text = m_User.RelationshipStatus.ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }

                try
                {
                    var relStat = m_User.RelationshipStatus;
                    if (relStat == User.eRelationshipStatus.InARelationship      ||
                        relStat == User.eRelationshipStatus.Enagaged             ||
                        relStat == User.eRelationshipStatus.Married              ||
                        relStat == User.eRelationshipStatus.InAnOpenRelationship ||
                        relStat == User.eRelationshipStatus.Separated              )
                    {
                        lblSignificantOther.Text = m_User.SignificantOther.Name;
                    }
                    else
                    {
                        lblSignificantOther.Enabled = false;
                    }

                }
                catch
                {
                    lblSignificantOther.Text = "No SO found!";
                }

                try
                {
                    if (m_User.Hometown != null)
                    {
                        lblHometown.Text = m_User.Hometown.ToString();
                    }
                    else
                    {
                        lblHometown.Enabled = false;
                    }
                }
                catch (Exception ex )
                {
                    Console.WriteLine($"{ex.Message}");
                }

                try
                {
                    if (m_User.Location != null)
                    {
                        lblLocation.Text = m_User.Location.Name; 
                    }
                    else
                    {
                        lblLocation.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }

                try
                {
                    if (m_User.Birthday != null) { 
                        lblBday.Text = m_User.Birthday;
                    }
                    else
                    {
                        lblBday.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }

        private void lblSignificantOther_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(m_User.SignificantOther.Link);
        }
    }
}
