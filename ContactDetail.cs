using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amazing_Charts_Sample_Application
{
    public partial class ContactDetail : UserControl
    {
        bool formExpand = false;
        public bool isCheckboxSelected = false;
        App ths;
        public ContactDetail(App ths)
        {
            InitializeComponent();
             this.ths = ths;
            
        }

        #region Properies

        private ContactClass _contactInfo;


        public ContactClass ContactInfo
        {
            get { return _contactInfo; }
            set { _contactInfo = value; }
        }

        public void loadLabels(ContactClass co)
        {
            lblFirstName.Text = co.firstName;
            lblLastName.Text = co.lastName;
            lblDate.Text = co.dateOfBirth.ToString("d");
            lblNumber.Text = co.phoneNumber.ToString();
        }

        private void ListContact_Load(object sender, EventArgs e)
        {
            this.Height = this.MinimumSize.Height;
            loadLabels(_contactInfo);

        }


        #endregion

        private void editButton_Click(object sender, EventArgs e)
        {
            ths.openChildFormInPanel(new ContactForm(ths, this)) ;

        }



        private void ListContact_MouseHover_1(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSkyBlue;

        }

        private void ListContact_MouseLeave_1(object sender, EventArgs e)
        {
            this.BackColor = Color.LightCyan;
        }


        /// <summary>
        /// Method for opening more information and closing on the ContactDetails form
        /// </summary>
        private void openTimer_Tick(object sender, EventArgs e)
        {
            if (formExpand)
            {
                this.Height -= 10;
                if(this.Height == this.MinimumSize.Height)
                {
                    formExpand = false;
                    openTimer.Stop();
                }
            }
            else
            {
                this.Height += 10;
                if (this.Height == this.MaximumSize.Height)
                {
                    formExpand = true;
                    openTimer.Stop();
                }
            }
        }

        private void ListContact_MouseClick_1(object sender, MouseEventArgs e)
        {
            openTimer.Start();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isCheckboxSelected = checkBox1.Checked;
        }

    }
}
