using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumCustomer
{
    class Reservation
    {
        public int ReservationID { get; set; }
        public int CustomerID { get; set; }
        public string CheckinDate { get; set; }
        public string CheckoutDate { get; set; }
        public string ViewType { get; set; }
        public int StationNumberAssigned { get; set; }


        public Reservation()
        {
            ReservationID = 0;
            CustomerID = 0;
            CheckinDate = "Default Checkin Date";
            CheckoutDate = "Default Checkout Date";
            ViewType = "Default View";
            StationNumberAssigned = 0;
        }

        public Reservation(int id, int custid, string checkin, string checkout, string view, int station)
        {
            ReservationID = id;
            CustomerID = custid;
            CheckinDate = checkin;
            CheckoutDate = checkout;
            ViewType = view;
            StationNumberAssigned = station;
        }

        public override string ToString()
        {
            return "Reservation ID is: " + ReservationID +
               "\nCustomer ID is: " + CustomerID +
               "\nCheckin Date is: " + CheckinDate +
               "\nCheckout Date is : " + CheckoutDate +
               "\nView Type is: " + ViewType +
               "\nStation Number Assigned is " + StationNumberAssigned;
        }
    }
}
