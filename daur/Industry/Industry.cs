using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAUR
{
    internal class Industry
    {
        private int _companyID;
        private string _companyName;
        private string _companyAddress;
        private string _typeOfWaste;
        private bool _deliveryRequest;

        // Constructor to initialize the industry
        public Industry(int companyID, string companyName, string companyAddress, string typeOfWaste)
        {
            _companyID = companyID;
            _companyName = companyName;
            _companyAddress = companyAddress;
            _typeOfWaste = typeOfWaste;
            _deliveryRequest = false; // Initially, no delivery request is made
        }

        // Properties
        public int companyID
        {
            get { return _companyID; }
        }

        public string companyName
        {
            get { return _companyName; }
        }

        public string companyAddress
        {
            get { return _companyAddress; }
        }

        public string typeOfWaste
        {
            get { return _typeOfWaste; }
        }

        public bool deliveryRequest
        {
            get { return _deliveryRequest; }
            set { _deliveryRequest = value; }
        }

        // Method to request waste delivery for recycling
        public bool RequestDelivery()
        {
            if (!_deliveryRequest)
            {
                _deliveryRequest = true;
                Console.WriteLine($"{_companyName} has requested waste delivery for recycling.");
                return true;
            }
            else
            {
                Console.WriteLine($"{_companyName} already has a pending waste delivery request.");
                return false;
            }
        }

        // Method to cancel a delivery request
        public bool CancelDeliveryRequest()
        {
            if (_deliveryRequest)
            {
                _deliveryRequest = false;
                Console.WriteLine($"{_companyName} has canceled their waste delivery request.");
                return true;
            }
            else
            {
                Console.WriteLine($"{_companyName} does not have a pending waste delivery request to cancel.");
                return false;
            }
        }
    }
}
