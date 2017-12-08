using System;

/// <summary>
/// Author: Tomas Perers
/// Date: 2017-11-05
/// </summary>
namespace Assignment5
{
    public class Address
    {
        private string m_street, m_zipcode, m_city;
        private Countries m_country;
        private string m_errorMessage = String.Empty;

        public string Street { get => m_street; set => m_street = value; }
        public string Zipcode { get => m_zipcode; set => m_zipcode = value; }
        public string City { get => m_city; set => m_city = value; }
        public Countries Country { get => m_country; set => m_country = value; }
        public string ErrorMessage { get => m_errorMessage; }
        /// <summary>
        /// Creates an address object and no default settings.
        /// </summary>
        /// <param name="street"></param>
        /// <param name="zipcode"></param>
        /// <param name="city"></param>
        /// <param name="country"></param>
        public Address(string street, string zipcode, string city, Countries country)
        {
            Street = street;
            Zipcode = zipcode;
            City = city;
            Country = country;
        }

        /// <summary>
        /// Creates an address object and gets a street, zipcode and city. Calls another constructor and sends Countries.Sverige as a default setting.
        /// </summary>
        /// <param name="street"></param>
        /// <param name="zipcode"></param>
        /// <param name="city"></param>
        public Address(string street, string zipcode, string city):  this(street, zipcode, city, Countries.Sverige)
        {

        }
        /// <summary>
        /// Creates an address Calls another constructor and sends the City as Stockholm and two empty strings as default.
        /// </summary>
        public Address() : this(string.Empty, String.Empty, "Stockholm")
        {

        }
        /// <summary>
        /// Create and address by sending in another address object.
        /// </summary>
        /// <param name="theOther"></param>
        public Address(Address theOther)
        {
            this.m_city = theOther.m_city;
            this.m_country = theOther.m_country;
            this.m_errorMessage = theOther.m_errorMessage;
            this.m_street = theOther.m_street;
            this.m_zipcode = theOther.m_zipcode;
        }
        /// <summary>
        /// Removes _ from countries that have a _ in them.
        /// </summary>
        /// <returns></returns>
        public string GetCountryString()
        {
            string strCountry = m_country.ToString();
            strCountry = strCountry.Replace("_", " ");
            return strCountry;
        }
        /// <summary>
        /// Returns a string representation of the object.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("{0,-25} {1,-8} {2,-10} {3}", m_street, m_zipcode, m_city, GetCountryString());
        }
        public string GetAddressLabel()
        {
            throw new Exception("Not implemented yet!");
        }

        /// <summary>
        /// Validates that the input is nut empty.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            bool returnValue;
            if (String.IsNullOrEmpty(m_country.ToString()))
            {
                returnValue = false;
                m_errorMessage = "Country has not been set";
            }
            else if (String.IsNullOrEmpty(m_city))
            {
                returnValue = false;
                m_errorMessage = "City has not been set";
            }
            else
                returnValue = true;
            return returnValue;
        }
    }
}
