using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumCustomer
{
    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerStreetAddress { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerState { get; set; }
        public int CustomerZip { get; set; }
        public string CustomerPhoneNumber { get; set; }
    

    public Customer()
    {
            CustomerID = 0;
            CustomerFirstName = "Default First Name";
            CustomerLastName = "Default Last Name";
            CustomerStreetAddress = "Default Street Address";
            CustomerCity = "Default City";
            CustomerState = "Default State";
            CustomerZip = 00000;
            CustomerPhoneNumber = "(000) 000-0000";
    }

    public Customer (int id, string first, string last, string street, string city, string state, int zip, string phone)
        {
            CustomerID = id;
            CustomerFirstName = first;
            CustomerLastName = last;
            CustomerStreetAddress = street;
            CustomerCity = city;
            CustomerState = state;
            CustomerZip = zip;
            CustomerPhoneNumber = phone;
        }
        public override string ToString()
        {
            return "Customer ID is: " + CustomerID +
               "\nCustomer First Name is: " + CustomerFirstName +
               "\nCustomer Last Name is : " + CustomerLastName +
               "\nCustomer Street Address is: " + CustomerStreetAddress +
               "\nCustomer City is: " + CustomerCity +
               "\nCustomer State is: " + CustomerState +
               "\nCustomer Zip is: " + CustomerZip +
               "\nCustomer Whole Address is" + CustomerStreetAddress + " " + CustomerCity + ", " + CustomerState + ", " + CustomerZip +
               "\nCustomer Phone Number is" + CustomerPhoneNumber;
        }
    }
}
