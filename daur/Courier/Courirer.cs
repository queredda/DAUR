using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAUR.Courier
{
    public class Courier
    {
        // Properties
        public string CourierName { get; set; }
        public int CourierID { get; set; }
        public string CourierAddress { get; set; }
        public long CourierNumber { get; set; }
        public string CourierVehicle { get; set; }
        public string CourierStatus { get; set; }  // Status could be: Pending, In Transit, Delivered, etc.

        // Constructor
        public Courier(string courierName, int courierID, string courierAddress, long courierNumber, string courierVehicle, string courierStatus)
        {
            CourierName = courierName;
            CourierID = courierID;
            CourierAddress = courierAddress;
            CourierNumber = courierNumber;
            CourierVehicle = courierVehicle;
            CourierStatus = courierStatus;
        }

        // Method to simulate taking a request
        public void TakeRequest()
        {
            // Logic to take a request
            if (CourierStatus == "Available" || CourierStatus == "Pending")
            {
                CourierStatus = "In Transit";  // Assume that when a request is taken, the status changes to "In Transit"
                Console.WriteLine($"Courier {CourierName} (ID: {CourierID}) has taken the request. Current Status: {CourierStatus}");
            }
            else
            {
                Console.WriteLine($"Courier {CourierName} (ID: {CourierID}) is not available to take the request. Current Status: {CourierStatus}");
            }
        }

        // Method to simulate tracking the request
        public string TrackRequest()
        {
            // Logic to return the current status of the request
            switch (CourierStatus)
            {
                case "In Transit":
                    return $"Courier {CourierName} (ID: {CourierID}) is currently on the way. Status: {CourierStatus}.";

                case "Delivered":
                    return $"Courier {CourierName} (ID: {CourierID}) has already delivered the package. Status: {CourierStatus}.";

                default:
                    return $"Courier {CourierName} (ID: {CourierID}) is currently not handling any requests. Status: {CourierStatus}.";
            }
        }

        // You can add other logic to update the status, for example when delivery is completed
        public void CompleteDelivery()
        {
            // Logic to mark the request as complete
            if (CourierStatus == "In Transit")
            {
                CourierStatus = "Delivered";  // Status updated to Delivered when the package is delivered
                Console.WriteLine($"Courier {CourierName} (ID: {CourierID}) has delivered the package. Status updated to: {CourierStatus}");
            }
            else
            {
                Console.WriteLine($"Courier {CourierName} (ID: {CourierID}) cannot complete delivery. Current Status: {CourierStatus}");
            }
        }
    }
}
