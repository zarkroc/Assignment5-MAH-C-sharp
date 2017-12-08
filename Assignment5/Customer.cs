using System;
/// <summary>
/// Author: Tomas Perers
/// Date: 2017-11-10
/// </summary>

namespace Assignment5
{
    /// <summary>
    /// Representation of a customer.
    /// </summary>
    class Customer
    {
        private Contact m_contact;
        private string m_id;

        /// <summary>
        /// Constructor, Creates a customer with a Customer Id and Contact information (reference to a Contact object).
        /// </summary>
        /// <param name="contact">Contact object</param>
        /// <param name="id">Customer Id number</param>
        public Customer(Contact contact, string id)
        {
            Contact = contact;
            Id = id;
        }

        public Contact Contact { get => m_contact; set => m_contact = value; }
        public string Id { get => m_id; set => m_id = value; }

        /// <summary>
        /// Returns the Id and calls Contact.ToString method and returns a formatted string.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return String.Format("{0,-4} {1}",  Id, m_contact.ToString());
        }
    }
}
