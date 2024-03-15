﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumCustomer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //customer page
            toolTip1.SetToolTip(this.numericUpDownCustomerID, "This is the customer ID that will be added. This is not editable.");
            toolTip1.SetToolTip(this.buttonCheckCustomerDatabaseRows, "This will reference the rows in the database to find the next free customer ID and will change the Customer ID field.");
            toolTip1.SetToolTip(this.textBoxCustomerFirstName, "Enter the customer's first name here.");
            toolTip1.SetToolTip(this.textBoxCustomerLastName, "Enter the customer's last name here.");
            toolTip1.SetToolTip(this.textBoxCustomerStreetAddress, "Enter the customer's street address here.");
            toolTip1.SetToolTip(this.textBoxCustomerCity, "Enter the customer's city here.");
            toolTip1.SetToolTip(this.comboBoxCustomerState, "Choose the customer's state or territory from this list.");
            toolTip1.SetToolTip(this.maskedTextBoxCustomerZipCode, "Enter the customer's zip code here.");
            toolTip1.SetToolTip(this.maskedTextBoxCustomerPhoneNumber, "Enter the customer's phone number here.");
            toolTip1.SetToolTip(this.buttonAddCustomer, "This will add a new customer with the information filled out on screen.");

            //reservation page
            toolTip1.SetToolTip(this.numericUpDownReservationID, "This is the reservation ID that will be added. This is not editable.");
            toolTip1.SetToolTip(this.buttonCheckCustomerDatabaseRows, "This will reference the rows in the database to find the next free reservation ID and will change the Customer ID field.");
            toolTip1.SetToolTip(this.textBoxCustomerID, "Enter the customer's ID number here.");
            toolTip1.SetToolTip(this.dateTimePickerCheckin, "Choose the time the customer is checking in here.");
            toolTip1.SetToolTip(this.dateTimePickerCheckout, "Choose the time the customer is checking out here.");
            toolTip1.SetToolTip(this.comboBoxView, "Choose the customer's desired view from the list.");
            toolTip1.SetToolTip(this.maskedTextBoxStationAssigned, "Enter the customer's assigned station ID here. The ID must be three numbers.");
            toolTip1.SetToolTip(this.buttonAddCustomer, "This will add a new reservation with the information filled out on screen.");

            Reservation res1 = new Reservation(1, 1, "Tuesday, January 1, 2019", "Thursday, January 3, 2019", "Denali", 9);
            Reservation res2 = new Reservation(2, 2, "Wednesday, January 2, 2019", "Friday, January 5, 2019", "River", 6);
            Reservation res3 = new Reservation(3, 3, "Wednesday, January 2, 2019", "Saturday, January 6, 2019", "Wilderness", 1);
            Reservation res4 = new Reservation(4, 4, "Saturday, January 5, 2019", "Sunday, Jnuary 6, 2019", "No preference", 10);
            Reservation res5 = new Reservation(5, 5, "Saturday, January 5, 2019", "Saturday, January 12, 2019", "River", 4);
            Reservation res6 = new Reservation(6, 6, "Monday, April 1, 2019", "Saturday, April 6, 2019", "River", 4);
            Reservation res7 = new Reservation(7, 1, "Tuesday, April 2, 2019", "Sunday, April 7, 2019", "No preference", 7);
            Reservation res8 = new Reservation(8, 7, "Tuesday, April 2, 2019", "Tuesday, April 9, 2019", "Wilderness", 2);
            Reservation res9 = new Reservation(9, 8, "Wednesday, April 3, 2019", "Thursday, April 4, 2019", "Denali", 9);
            Reservation res10 = new Reservation(10, 9, "Sunday April 7, 2019", "Sunday, April 14, 2019", "River", 4);

            Customer customer1 = new Customer(1, "John", "Smith", "123 Internet Street", "Online", "GA", 12345, "(123) 456-7890");
            Customer customer2 = new Customer(2, "Mary", "Smith", "456 Peachtree Street", "Atlanta", "GA", 30512, "(404) 123-4567");
            Customer customer3 = new Customer(3, "Paul", "Kelley", "1600 Pennsylvania Avenue", "", "DC", 54321, "(900) 987-5432");
            Customer customer4 = new Customer(4, "Logan", "Teffertiller", "1 GGC Avenue", "Lawrenceville", "GA", 30054, "(800) 999-9990");
            Customer customer5 = new Customer(5, "Amonn", "Brewer", "2 GGC Way", "Lawrenceville", "GA", 30054, "(999) 999-9999");
            Customer customer6 = new Customer(6, "Nanette", "Napier", "1000 University Parkway", "Lawrenceville", "GA", 30054, "(888) 500-5000");
            Customer customer7 = new Customer(7, "Sweet", "Caroline", "9 Street Street", "City Town", "AL", 05252, "(111) 111-1111");
            Customer customer8 = new Customer(8, "Awesome", "Customer", "880 Customer Blvd.", "Customerville", "CA", 94568, "(925) 925-9259");
            Customer customer9 = new Customer(9, "Awesome", "Customer", "880 Customer Blvd.", "Customerville", "CA", 94568, "(925) 925-9259");
            Customer customer10 = new Customer(10, "Kevin", "The best programmer assistant", "1 Computer Way", "Computertown", "MO", 55555, "(555) 555-5555");

            reservationBindingSource.Add(res1);
            reservationBindingSource.Add(res2);
            reservationBindingSource.Add(res3);
            reservationBindingSource.Add(res4);
            reservationBindingSource.Add(res5);
            reservationBindingSource.Add(res6);
            reservationBindingSource.Add(res7);
            reservationBindingSource.Add(res8);
            reservationBindingSource.Add(res9);
            reservationBindingSource.Add(res10);
            customerBindingSource.Add(customer1);
            customerBindingSource.Add(customer2);
            customerBindingSource.Add(customer3);
            customerBindingSource.Add(customer4);
            customerBindingSource.Add(customer5);
            customerBindingSource.Add(customer6);
            customerBindingSource.Add(customer7);
            customerBindingSource.Add(customer8);
            customerBindingSource.Add(customer9);
            customerBindingSource.Add(customer10);



            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);

        }

        string emptyVar = string.Empty;

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            foreach (Customer c in customerBindingSource)
            {
                if (c.CustomerFirstName == textBoxCustomerFirstName.Text && c.CustomerLastName == textBoxCustomerLastName.Text && c.CustomerPhoneNumber == maskedTextBoxCustomerPhoneNumber.Text)
                {
                    MessageBox.Show("There is a duplicate record in the system matching a first name, last name, and phone number. Please confirm everything is correct or update the existing record.", "Alert!");
                    return;
                }

            }

            //check for blank boxes
            if (textBoxCustomerFirstName.Text == emptyVar || textBoxCustomerFirstName.Text == emptyVar || textBoxCustomerStreetAddress.Text == emptyVar || textBoxCustomerCity.Text == emptyVar || comboBoxCustomerState.Text == emptyVar || maskedTextBoxCustomerPhoneNumber.Text == emptyVar || maskedTextBoxCustomerZipCode.Text == emptyVar)
            {
                MessageBox.Show("Something is missing. Please check data and try again.", "Error!");
                return;
            }
            else
            {
                //execute customer addition

                Customer newCustomer = new Customer(Convert.ToInt32(numericUpDownCustomerID.Text), textBoxCustomerFirstName.Text, textBoxCustomerLastName.Text, textBoxCustomerStreetAddress.Text, textBoxCustomerCity.Text, comboBoxCustomerState.Text, Convert.ToInt32(maskedTextBoxCustomerZipCode.Text), maskedTextBoxCustomerPhoneNumber.Text);

                customerBindingSource.Add(newCustomer);
                MessageBox.Show("Customer added. Check the Customer Database tab if edits are needed.", "Added!");

                //get next row ID number and set it for the next new customer
                int nextCustomerNumber = Convert.ToInt32(customerGridView.RowCount.ToString());
                numericUpDownCustomerID.Value = Convert.ToDecimal(nextCustomerNumber);

                //set all boxes to null
                textBoxCustomerFirstName.Text = emptyVar;
                textBoxCustomerLastName.Text = emptyVar;
                textBoxCustomerStreetAddress.Text = emptyVar;
                textBoxCustomerCity.Text = emptyVar;
                comboBoxCustomerState.SelectedIndex = -1;
                maskedTextBoxCustomerZipCode.Text = emptyVar;
                maskedTextBoxCustomerPhoneNumber.Text = emptyVar;
            }


        }

        private void buttonAddReservation_Click(object sender, EventArgs e)
        {
            //check for blank boxes
            if (textBoxCustomerID.Text == emptyVar || comboBoxView.Text == emptyVar || dateTimePickerCheckin.Text == emptyVar || dateTimePickerCheckout.Text == emptyVar || maskedTextBoxStationAssigned.Text == emptyVar || maskedTextBoxStationAssigned.Text == emptyVar)
            {
                MessageBox.Show("Something is missing. Please check data and try again.", "Error!");
                return;
            }
            else if (dateTimePickerCheckin.Value > dateTimePickerCheckout.Value)
            {
                MessageBox.Show("The checkout date is earlier than the checkin date. Correct this and try again.", "Error!");
                return;
            }

            else
            {
                //execute customer addition

                Reservation newReservation = new Reservation();

                newReservation.ReservationID = Convert.ToInt32(numericUpDownReservationID.Value);
                newReservation.CustomerID = Convert.ToInt32(textBoxCustomerID.Text);
                newReservation.CheckinDate = dateTimePickerCheckin.Text;
                newReservation.CheckoutDate = dateTimePickerCheckout.Text;
                newReservation.ViewType = comboBoxView.Text;
                newReservation.StationNumberAssigned = Convert.ToInt32(maskedTextBoxStationAssigned.Text);

                reservationBindingSource.Add(newReservation);
                MessageBox.Show("Reservation added. Check the Reservation Database tab if edits are needed.", "Added!");

                //get next row ID number and set it for the next new customer
                int nextReservationNumber = Convert.ToInt32(customerGridView.RowCount.ToString());
                numericUpDownReservationID.Value = Convert.ToDecimal(nextReservationNumber);

                //set all boxes to null
                textBoxCustomerID.Text = string.Empty;
                dateTimePickerCheckin.Text = string.Empty;
                dateTimePickerCheckout.Text = string.Empty;
                comboBoxView.SelectedIndex = -1;
                maskedTextBoxStationAssigned.Text = string.Empty;
            }
        }

        private void buttonCheckCustomerDatabaseRows_Click(object sender, EventArgs e)
        {
            int nextCustomerNumber = Convert.ToInt32(customerGridView.RowCount.ToString());
            numericUpDownCustomerID.Value = Convert.ToDecimal(nextCustomerNumber);
            MessageBox.Show("Customer database has been checked; it is now set to row " + numericUpDownCustomerID.Value, "Checked!");
        }

        private void buttonCheckReservationDatabaseRows_Click(object sender, EventArgs e)
        {
            int nextReservationNumber = Convert.ToInt32(reservationGridView.RowCount.ToString());
            numericUpDownReservationID.Value = Convert.ToDecimal(nextReservationNumber);
            MessageBox.Show("Resvervation database has been checked; it is now set to row " + numericUpDownReservationID.Value, "Checked!");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "password")
                {
                tabControl1.TabPages.Add(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabControl1.SelectTab(tabPage2);
                int nextCustomerNumber = Convert.ToInt32(customerGridView.RowCount.ToString());
                numericUpDownCustomerID.Value = Convert.ToDecimal(nextCustomerNumber);
                tabControl1.TabPages.Add(tabPage3);
                tabControl1.SelectTab(tabPage3);
                int nextReservationNumber = Convert.ToInt32(customerGridView.RowCount.ToString());
                numericUpDownReservationID.Value = Convert.ToDecimal(nextReservationNumber);
                tabControl1.TabPages.Add(tabPage4);
                tabControl1.SelectTab(tabPage1);
                tabControl1.TabPages.Remove(tabPage5);
                textBoxLogin.Text = emptyVar;
                MessageBox.Show("Welcome!");
            }
            else
            {
                MessageBox.Show("That's not the right password! Try again!", "ALERT!");

            }
        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage5);
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
            MessageBox.Show("Locked!");
        }
    }
}
