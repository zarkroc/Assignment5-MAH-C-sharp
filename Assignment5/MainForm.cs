using System;
using System.Windows.Forms;
/// <summary>
/// Author: Tomas Perers
/// Date: 2017-11-17
/// </summary>
namespace Assignment5
{
    public partial class MainForm : Form
    {
        private ContactForm contactForm;
        private CustomerManager customerManager = new CustomerManager();

        /// <summary>
        /// Constructor for the main form. Set the title of the form.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            this.Text = "Customer registry";
        }
        /// <summary>
        /// Update the GUI i.e. the customer list
        /// </summary>
        private void UpdateGUI()
        {
            lstCustomers.Items.Clear();
            for (int i = 0; i < customerManager.Count; i++)
            {
                lstCustomers.Items.Add(customerManager.GetCustomer(i).ToString());
            }
        }

        /// <summary>
        /// when a user clicks the edit button, find what customer is selected in the list and edit that customer. Or tell the user that no customer was selected.
        /// Update GUI when action is done.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = lstCustomers.SelectedIndex;
            if (index != -1)
            {
                contactForm = new ContactForm("Edit customer");
                Customer customer = customerManager.GetCustomer(index);
                contactForm.ContactData = customer.Contact;
                if (contactForm.ShowDialog() == DialogResult.OK)
                {
                    customer.Contact = contactForm.ContactData;
                    customerManager.ChangeCustomer(customer, index);
                    UpdateGUI();
                }
            }
            else
                MessageBox.Show("No customer selected to edit!");
        }

        /// <summary>
        /// Adds a user by calling another form and save the data from that form in the customer list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            contactForm = new ContactForm("Add new customer");
            if (contactForm.ShowDialog() == DialogResult.OK)
            {
                customerManager.AddCustomer(contactForm.ContactData);
                UpdateGUI();
            }
        }

        /// <summary>
        /// Remove the selected customer when the user clicks the remove button. If nothing is selected give an error message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = lstCustomers.SelectedIndex;
            if (index != -1)
            {
                if (customerManager.RemoveCustomer(index))
                {
                    UpdateGUI();
                }
                else
                    MessageBox.Show("Failed to delete customer");
            }
            else
                MessageBox.Show("No customer selected for removal!");
        }
    }
}
