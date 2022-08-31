using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amazing_Charts_Sample_Application
{
    public partial class ContactForm : Form
    {
        App ths;
        ContactDetail contactDetailThs;
        ContactClass contactInfo;

        private dataFunctions dbFunctions = new dataFunctions();
        public ContactForm(App ths, [System.Runtime.InteropServices.Optional] ContactDetail contactDetailThs)
        {
            InitializeComponent();
            if (contactDetailThs != null)
            {               
                this.contactInfo = contactDetailThs.ContactInfo;
                this.contactDetailThs = contactDetailThs;
            }
            this.ths = ths;
        }


        /// <summary>
        /// If an existing contact enit button is pushed ContactForm infromation is preloaded
        /// </summary>
        private void ContactForm_Load(object sender, EventArgs e)
        {
            if (contactDetailThs != null)
            {
                tbFirstName.Text = contactInfo.firstName;
                tbLastName.Text = contactInfo.lastName;
                tbPhoneNumber.Text = contactInfo.phoneNumber;
                dateTimePicker1.Text = contactInfo.dateOfBirth.ToString("d");
            }
        }


        #region Validation
        private bool ValidateName(string name)
        {
            
            bool valid = Regex.IsMatch(name, @"^[\p{L}\p{M}' \.\-]+$");
            if (!valid)
            {
                string errorMessage = valid ? string.Empty : "Please enter valid name";

                MessageBox.Show(name, errorMessage);
            }


            return valid;
        }

        private bool ValidatePhoneN(string phoneNumber)
        {
            
            bool valid = Regex.IsMatch(phoneNumber, @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            if (!valid)
            {
                string errorMessage = valid ? string.Empty : "Please enter valid phone number";

                MessageBox.Show(phoneNumber, errorMessage);
            }


            return valid;
        }

        private bool ValidateDateOfBirh(DateTime dateOfBirth)
        {

            bool valid = dateOfBirth.Date <= DateTime.Now.Date;
            if (!valid)
            {
                string errorMessage =  "Please enter valid date of birth";

                MessageBox.Show(errorMessage);
            }


            return valid;
        }
        #endregion
        /// <summary>
        /// reformats phone number into 000-000-0000 format
        /// </summary>
        private string formatPhoneNuber(string number)
        {
            number = new String(number.Where(Char.IsDigit).ToArray());
            number = String.Format("{0}-{1}-{2}", number.Substring(0, 3), number.Substring(3, 3), number.Substring(6, 4));
            return number;
        }

        #region Buttons
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {

            if(ValidateName(tbFirstName.Text) && ValidateName(tbLastName.Text) && ValidatePhoneN(tbPhoneNumber.Text) && ValidateDateOfBirh(dateTimePicker1.Value))
            {
                string phoneFormat = new String(tbPhoneNumber.Text.Where(Char.IsDigit).ToArray());
                ContactClass cc = new ContactClass();
                cc.firstName = tbFirstName.Text;
                cc.lastName = tbLastName.Text;
                cc.phoneNumber = formatPhoneNuber(tbPhoneNumber.Text);
                cc.dateOfBirth = dateTimePicker1.Value;
               
                if (contactInfo != null)
                {
                    cc.id = contactInfo.id;
                    dbFunctions.Edit(cc);
                    contactDetailThs.ContactInfo = cc;
                    contactDetailThs.loadLabels(cc);
                }
                else
                {
                    cc.id = dbFunctions.Add(cc);
                    ths.publishContact(cc);
                }

                this.Close();
            }



            
        }
        #endregion
    }
}
