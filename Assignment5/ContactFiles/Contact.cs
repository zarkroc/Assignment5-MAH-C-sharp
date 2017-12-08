using System;

/// <summary>
/// Author: Tomas Perers
/// Date: 2017-11-01
/// </summary>
/// 
namespace Assignment5
{
    /// <summary>
    /// A representation of a Contact.
    /// </summary>
    public class Contact
    {
        private Address m_address;
        private Email m_email;
        private Phone m_phone;
        private string m_fistname, m_lastname;
        private string m_errorMessage = String.Empty;

        /// <summary>
        /// Constructor to create an object. Holds Firstname, lastname, address, phone numbers and emails.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <param name="phoneNr"></param>
        /// <param name="email"></param>
        public Contact(string firstName, string lastName, Address address, Phone phoneNr, Email email)
        {
            m_fistname = firstName;
            m_lastname = lastName;
            m_address = address;
            m_phone = phoneNr;
            m_email = email;
        }
        /// <summary>
        /// A contact that creates an object with no values.
        /// </summary>
        public Contact()
        {
            m_fistname = String.Empty;
            m_lastname = String.Empty;
            m_address = new Address();
            m_phone = new Phone();
            m_email = new Email();
        }
        
        public Email Email { get => m_email; set => m_email = value; }
        public string Fistname { get => m_fistname; set => m_fistname = value; }
        public string Lastname { get => m_lastname; set => m_lastname = value; }
        internal Address Address { get => m_address; set => m_address = value; }
        internal Phone Phone { get => m_phone; set => m_phone = value; }
        public string ErrorMessage { get => m_errorMessage; }

        public string Fullname => m_lastname + " " + m_fistname;

        /// <summary>
        /// Returns a formatted string of the objects data.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("{0, -20} {1, -20} {2, 20} {3}" , Fullname, m_address.ToString(), m_phone.ToString(), m_email.ToString());
        }

        /// <summary>
        /// Verifys the address input
        /// </summary>
        /// <returns>boolean</returns>
        public bool CheckAddress()
        {
            bool returnValue;
            if (!m_address.Validate())
            {
                returnValue = false;
                m_errorMessage = m_address.ErrorMessage;
            }
            else
                returnValue = true;
            return returnValue;
        }

        /// <summary>
        /// Verifyes that the name inputs are not empty.
        /// </summary>
        /// <returns>boolean</returns>
        public bool CheckName()
        {
            bool returnValue;
            if (m_fistname == "")
            {
                returnValue = false;
                m_errorMessage = "No first name specefied";
            }
            else if (m_lastname == "")
            {
                returnValue = false;
                m_errorMessage = "No last name specefied";
            }
            else
                returnValue = true;
            return returnValue;
        }
    }
}
