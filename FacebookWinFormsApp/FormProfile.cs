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
                    lblGender.Text = "Gender: "+m_User.Gender.ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }

                try
                {
                    lblRelationship.Text = "Relationship status: "+m_User.RelationshipStatus.ToString();
                }
                catch (Exception ex)
                {
                    lblRelationship.Text = "Relationship status not found.";
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
                        lblSignificantOther.Text = "In a relationship with:\n"+m_User.SignificantOther.Name;
                    }
                    else
                    {
                        lblSignificantOther.Enabled = false;
                        lblSignificantOther.Text = "No SO found!";
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
                        lblHometown.Text = "Home town:\n"+m_User.Hometown.ToString();
                    }
                    else
                    {
                        lblHometown.Enabled = false;
                        lblHometown.Text = "No home\ntown found!";
                    }
                }
                catch (Exception ex )
                {
                    Console.WriteLine($"{ex.Message}");
                    lblHometown.Enabled = false;
                    lblHometown.Text = "No home\ntown found!";
                }

                try
                {
                    if (m_User.Location != null)
                    {
                        lblLocation.Text = "Current location:\n"+m_User.Location.Name; 
                    }
                    else
                    {
                        lblLocation.Enabled = false;
                        lblLocation.Text = "No current\nlocation found!";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                    lblLocation.Enabled = false;
                    lblLocation.Text = "No current\nlocation found!";
                }

                try
                {
                    if (m_User.Birthday != null) { 
                        lblBday.Text = "Birthday:\n"+m_User.Birthday;
                    }
                    else
                    {
                        lblBday.Enabled = false;
                        lblBday.Text = "No birthday found!";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                    lblBday.Enabled = false;
                    lblBday.Text = "No birthday found!";
                }

                try
                {
                    tbBio.Text = m_User.About;
                }
                catch ( Exception ex )
                {
                    Console.WriteLine($"{ex.Message}");
                    tbBio.Text = "No bio found!";
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
    }
}
