using System;
/// <summary>
/// Author: Tomas Perers
/// Date: 2017-11-01
/// </summary>
/// 
namespace Assignment5
{
    /// <summary>
    /// An object to hold phone numbers.
    /// </summary>
    public class Phone
    {
        private string m_home, m_work;

        /// <summary>
        /// Calls another constructor with two empty strings.
        /// </summary>
        public Phone() : this(String.Empty, String.Empty)
        {
            
        }

        /// <summary>
        /// Creats an object with specefied phone numbers.
        /// </summary>
        /// <param name="homePhone"></param>
        /// <param name="workPhone"></param>
        public Phone(string homePhone, string workPhone)
        {
            m_home = homePhone;
            m_work = workPhone;
        }
        public string Home { get => m_home; set => m_home = value; }
        public string Work { get => m_work; set => m_work = value; }

        /// <summary>
        /// Returns a formatted string with the phone numbers.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string output = String.Empty;
            if (m_home != String.Empty)
                output = "home: " + m_home;
            if (m_work != String.Empty)
                output = output + " work: " + m_work;
           return output;
        }
    }
}
