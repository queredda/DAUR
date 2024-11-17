using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAUR.Delivery
{
    internal class Delivery
    {
        public int _ID;
        public int _requestCourier;
        public string _deliveryStatus;
        public string _deliveryAddress;
        public string _deliveryCompany;
        public int _deliveryNumber;
        public int _deliveryWeight;
        public DateOnly _deliveryDate;

        public Delivery(int deliveryID, int requestCourier, string deliveryStatus, string deliveryAddress, string deliveryCompany, int deliveryNumber, int deliveryWeight, DateOnly deliveryDate)
        {
            _ID = deliveryID;
            _requestCourier = requestCourier;
            _deliveryStatus = deliveryStatus;
            _deliveryAddress = deliveryAddress;
            _deliveryCompany = deliveryCompany;
            _deliveryNumber = deliveryNumber;
            _deliveryWeight = deliveryWeight;
            _deliveryDate = deliveryDate;
        }

        //Properties
        public int deliveryID
        {
            get { return _ID; }
        }

        public int requestCourier
        {
            get { return _requestCourier; }
        }

        public string deliveryStatus
        {
            get { return _deliveryAddress; }
        }

        public string deliveryAddress
        {
            get { return _deliveryAddress; }
        }

        public string deliveryCompany
        {
            get { return _deliveryCompany; }
        }

        public int deliveryNumber
        {
            get { return _deliveryNumber; }
        }

        public int deliveryWeight
        {
            get { return _deliveryWeight; }
        }

        public DateOnly deliveryDate
        {
            get { return _deliveryDate; }
        }
    }
}
