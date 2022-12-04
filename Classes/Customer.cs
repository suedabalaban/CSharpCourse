using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        //we can hold customer's information by defining "property" in class.
        public int Id { get; set; }

        //encapsulation
        private string firstName; //field
        public string FirstName
        {
            get { return "Mr." +firstName; }      
            set { firstName = value; }
        }

        public string LastName { get; set; }
        public string City { get; set; }





    }
}
