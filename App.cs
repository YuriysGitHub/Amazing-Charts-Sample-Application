using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Collections;
using System.Data.SqlTypes;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata;


namespace Amazing_Charts_Sample_Application
{
    public partial class App : Form
    {
        private dataFunctions dbFunctions = new dataFunctions();
        public List<ContactDetail> listofContactForms = new List<ContactDetail>();
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public App()
        {

            InitializeComponent();

        }

        private void Contacts_Load(object sender, EventArgs e)
        {
            //populating list of contacts to panelLayoutContacts in App Form
            populateContacts();
        }

        /// <summary>
        /// Method to show/open other forms on the App form
        /// </summary>
        private Form activeForm = null;
        public void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelGeneral.Controls.Add(childForm);
            panelGeneral.Tag = childForm;
            btnAdd.Enabled = false;
            btnExport.Enabled = false;
            btnImport.Enabled = false;
            btnDeleete.Enabled = false;
            childForm.BringToFront();
            childForm.Show();

            childForm.FormClosing += (s, e) =>
            {
                btnAdd.Enabled = true;
                btnExport.Enabled = true;
                btnImport.Enabled = true;
                btnDeleete.Enabled = true;

            };
        }
        //Check if contact list is empty and show label -"0 Contacts have been added"
        private void isContactListEmpty()
        {
            emptyLabel.Visible = panelLayoutContacts.Controls.Count <= 0 ? true : false;
        }

        #region Contacts List Population

        /// <summary>
        /// Creates a single instace of ContactDetails Form and adds to ListofContactForms
        /// </summary>
        public ContactDetail populateContact(ContactClass contact)
        {
            ContactDetail contactDetailsForm = new ContactDetail(this);
            contactDetailsForm.ContactInfo = contact;
            listofContactForms.Add(contactDetailsForm);
            isContactListEmpty();
            return contactDetailsForm;
        }

        /// <summary>
        /// Adds a single contact to panelLayoutContacts List in App Form
        /// </summary>
        public void publishContact(ContactClass contact)
        {
           ContactDetail pc = populateContact(contact);
            panelLayoutContacts.Controls.Add(pc);
            
        }

        /// <summary>
        /// On start retreaves list of contacts from sql database and adds them to Forms panel
        /// </summary>
        public void populateContacts()
        {
            List<ContactClass> contacts = dbFunctions.GetContacts();

            emptyLabel.Visible = true;
            for (int i = 0; i < contacts.Count(); i++)
            {
                ContactDetail contact = populateContact(contacts.ElementAt(i));
                if (panelLayoutContacts.Controls.Count < 0)
                {
                    panelLayoutContacts.Controls.Clear();
                }
                else
                {
                    panelLayoutContacts.Controls.Add(contact);
                }
            }
        }

        #endregion





        #region Buttons
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Exporting Contacts in XML file
        /// </summary>
        private void exportButton_Click(object sender, EventArgs e)
        {

                try
                {   
                    SaveFileDialog saveContactFile = new SaveFileDialog();
                    saveContactFile.Title = "Save Contacts XML File";
                    saveContactFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);// @"C:\Users\Public\Desktop";
                    saveContactFile.Filter = "|*.*|XML File (*.xml)|*.xml";
                    saveContactFile.FilterIndex = 2;
                    saveContactFile.ShowDialog();
                    if (saveContactFile.FileName != "")
                    {
                        XmlWriterSettings settings = new XmlWriterSettings();
                        settings.Indent = true;
                    using (XmlWriter writer = XmlWriter.Create(saveContactFile.FileName, settings))
                        {
                            writer.WriteStartDocument();
                            writer.WriteStartElement("contacts");
                            foreach (ContactDetail contact in listofContactForms.ToList())
                            {
                                if (contact.isCheckboxSelected)
                                    {
                                        writer.WriteStartElement("contact");

                                        writer.WriteElementString("first", contact.ContactInfo.firstName);
                                        writer.WriteElementString("last", contact.ContactInfo.lastName);
                                        writer.WriteElementString("dob", contact.ContactInfo.dateOfBirth.ToString("yyyy-MM-dd"));
                                        writer.WriteElementString("phone", contact.ContactInfo.phoneNumber);

                                        writer.WriteEndElement();
                                        writer.Flush();
                                    }else
                                        {
                                         MessageBox.Show("Select Contacts to Export");
                                        }
                            }
                            writer.WriteEndElement();
                            writer.WriteEndDocument();
                        }
                        MessageBox.Show("Export Successful");
                }
                    else
                    {
                        MessageBox.Show("File Failed on import");
                        
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString());
                    
                }


            

        }

        
        /// <summary>
        /// Importing Contacts in XML file
        /// </summary>
        private void importButton_Click(object sender, EventArgs e)
        {

            try
            {                
                OpenFileDialog importContacts = new OpenFileDialog();
                importContacts.Title = "Select XML Contacts File";
                importContacts.InitialDirectory = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\xmlSample"));
                importContacts.Filter = "|*.*|XML File (*.xml)|*.xml";
                importContacts.FilterIndex = 2;
                importContacts.ShowDialog();
                if (importContacts.FileName != "")
                {

                    using (XmlReader reader = XmlReader.Create(importContacts.FileName))
                    {

                        reader.ReadToFollowing("contact");

                        do
                        {
                            ContactClass contact = new ContactClass();

                            reader.ReadToFollowing("first");
                            contact.firstName = reader.ReadElementContentAsString();

                            reader.ReadToFollowing("last");
                            contact.lastName = reader.ReadElementContentAsString();

                            reader.ReadToFollowing("dob");
                            contact.dateOfBirth = DateTime.Parse(reader.ReadElementContentAsString());

                            reader.ReadToFollowing("phone");
                            contact.phoneNumber = reader.ReadElementContentAsString();

                            contact.id = dbFunctions.Add(contact);
                            publishContact(contact);

                        } while (reader.ReadToFollowing("contact"));


                    }

                }
                else
                {

                    MessageBox.Show("File name not selected");
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString());
                
            }



        }

        /// <summary>
        /// Opens ContactForm to write in contact information
        /// </summary>
        private void addButton_Click(object sender, EventArgs e)
        {

            openChildFormInPanel(new ContactForm(this));

        }
        /// <summary>
        /// Deletes selected contacts
        /// </summary>
        private void deleeteButton_Click(object sender, EventArgs e)
        {

            foreach (ContactDetail contact in listofContactForms.ToList())
            {
                if (contact.isCheckboxSelected)
                {
                    dbFunctions.Delete(contact.ContactInfo.id);
                    panelLayoutContacts.Controls.Remove(contact);
                    listofContactForms.Remove(contact);
                }

            }

            isContactListEmpty();

        }

        /// <summary>
        /// Mouse controls to move the App
        /// </summary>
        #region panelMovent
        private void sidePanel_MouseDown_1(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void sidePanel_MouseUp_1(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void sidePanel_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }




        #endregion

        #endregion


    }
}


