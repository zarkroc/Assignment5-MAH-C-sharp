using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Author: Tomas Perers
/// Date: 2017-11-10
/// </summary>
namespace Assignment5
{
    /// <summary>
    /// A representation of a customer manager that holds a list of Customers.
    /// </summary>
    class CustomerManager
    {
        private List<Customer> customerList;
        private const int customerIdOffset = 100;

        /// <summary>
        /// How many customers do we have in the list?
        /// </summary>
        public int Count
        {
            get { return customerList.Count; }
        }

        /// <summary>
        /// Returns a new Customer ID, checks the last customer in the list if there is one and adds +1 to that customer ID
        /// </summary>
        public int GetNewID
        {
            get
            {
                if (customerList.Count > 0)
                {
                    Customer lastCustomer = customerList.Last();
                    if (int.TryParse(lastCustomer.Id, out int result))
                        return result + 1;
                    else
                        return -1;
                }
                else
                    return 100 + Count;
            }
        }
        /// <summary>
        /// Constructor create a new customer list.
        /// </summary>
        public CustomerManager()
        {
            customerList = new List<Customer>();
        }

        /// <summary>
        /// Add a customer and make sure that we don't have one idetical customer added already.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>boolean</returns>
        public bool AddCustomer(Customer customer)
        {

            if (customerList.Contains(customer))
                return false;
            else
            {
                customerList.Add(customer);
                return true;
            }
        }

        /// <summary>
        /// Creates a customer object from a contact object and calls the other method.
        /// </summary>
        /// <param name="contact"></param>
        /// <returns>boolean</returns>
        public bool AddCustomer(Contact contact)
        {
            Customer customer = new Customer(contact, GetNewID.ToString());
            return AddCustomer(customer);
        }
        /// <summary>
        /// Change the customer at index in the list.
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="index"></param>
        public void ChangeCustomer(Customer customer, int index)
        {
            customerList[index] = customer;
        }
        /// <summary>
        /// Returns the customer at index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Customer</returns>
        public Customer GetCustomer(int index)
        {
            return customerList[index];
        }

        /// <summary>
        /// Removes the customer at index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>boolean</returns>
        public bool RemoveCustomer(int index)
        {
            if (index < customerList.Count && index >= 0)
            {
                customerList.RemoveAt(index);
                return true;
            }
            return false;
        }
    }
}
