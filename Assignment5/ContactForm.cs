using System;
using System.Windows.Forms;

/// <summary>
/// Author: Tomas Perers
/// Date: 2017-11-15
/// </summary>
namespace Assignment5
{
    public partial class ContactForm : Form
    {
        private bool m_closeForm;
        private Contact m_contact = new Contact();
        
        public ContactForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        /// <summary>
        /// Constructor for the form. Sets the title and update the GUI.
        /// </summary>
        /// <param name="title"></param>
        public ContactForm(string title)
        {
            InitializeComponent();
            this.Text = title;
            InitializeGUI();
        }

        /// <summary>
        /// Receives or sends contact data.
        /// </summary>
        public Contact ContactData
        {
            get { return m_contact; }
            set
            {
                if (value != null)
                    m_contact = value;
                UpdateGUI();
            }
        }
            
        /// <summary>
        /// Update the gui with information from the object.
        /// </summary>
        private void UpdateGUI()
        {
            txtCity.Text = m_contact.Address.City;
            txtStreet.Text = m_contact.Address.Street;
            txtZipcode.Text = m_contact.Address.Zipcode;
            txtFirstName.Text = m_contact.Fistname;
            txtLastName.Text = m_contact.Lastname;
            txtHomePhone.Text = m_contact.Phone.Home;
            txtWorkPhone.Text = m_contact.Phone.Work;
            txtPrivateEmail.Text = m_contact.Email.Personal;
            txtWorkEmail.Text = m_contact.Email.Work;
            cmbCountry.SelectedIndex = (int) m_contact.Address.Country;
        }
        private void InitializeGUI()
        {
            cmbCountry.DataSource = Enum.GetNames(typeof(Countries));
            m_closeForm = false;
            cmbCountry.SelectedIndex = (int) Countries.Sverige;
        }

        /// <summary>
        /// Exit the form if all fields that are needed have been filled in.
        /// Calls other functions to read the data and saves the read data in the object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            m_contact.Email = ReadEmail();
            m_contact.Phone = ReadPhone();
            m_contact.Address = ReadAddress();
            if ( ! m_contact.CheckAddress())
            {
                MessageBox.Show(m_contact.ErrorMessage);
                this.DialogResult = DialogResult.None;
            }
            else if (! ReadName())
            {
                MessageBox.Show(m_contact.ErrorMessage);
                this.DialogResult = DialogResult.None;
            }
            else
            {
                MessageBox.Show(m_contact.ToString());
                m_closeForm = true;
                this.Close();
            }
        }

        /// <summary>
        /// Cancel the form button. Close form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            m_closeForm = false;
            this.Close();
        }

        /// <summary>
        /// Read the phone numbers.
        /// </summary>
        /// <returns>Phone object.</returns>
        private Phone ReadPhone()
        {
            Phone phone = new Phone();
            phone.Home = txtHomePhone.Text;
            phone.Work = txtWorkPhone.Text;
            return phone;
        }

        /// <summary>
        /// Reads the names and return true or false depending on the check in the created contact functions.
        /// </summary>
        /// <returns></returns>
        private bool ReadName()
        {
            m_contact.Fistname = txtFirstName.Text;
            m_contact.Lastname = txtLastName.Text;
            return m_contact.CheckName();
        }

        /// <summary>
        /// Reads the address and creats an address object.
        /// </summary>
        /// <returns>address object</returns>
        private Address ReadAddress()
        {
            Address address = new Address();
            address.City = txtCity.Text;
            address.Country = (Countries)Enum.Parse(typeof(Countries), cmbCountry.SelectedItem.ToString());
            address.Street = txtStreet.Text;
            address.Zipcode = txtZipcode.Text;
            return address;
        }

        /// <summary>
        /// Reads the email fields and creates an email object.
        /// </summary>
        /// <returns></returns>
        private Email ReadEmail()
        {
            Email email = new Email();
            email.Work = txtWorkEmail.Text;
            email.Personal = txtPrivateEmail.Text;
            return email;
        }
        
        /// <summary>
        /// Event when form is closing. Ask the user if he is sure he wants to exit without saving.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_closeForm)
            {
                e.Cancel = false;
            }
            else
            {
                if (MessageBox.Show("Discard all data?", "Think twice",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
