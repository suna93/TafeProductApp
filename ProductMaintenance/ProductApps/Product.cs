using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private decimal price;
        private int quantity;
        private decimal totalPayment;
        private decimal delivery;
        private decimal wrapping;
        private decimal gst;

        private decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }


        public decimal Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }


        public decimal Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        public decimal GST
        {
            get { return gst; }
            set { gst = value; }
        }

        //Constructor for Product
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
        }

        //Calculate the total charge with delivery fee
        public void calTotalCharge()
        {
            decimal deliveryCost = 25M;
            Delivery = TotalPayment + deliveryCost;
        }

        //Calculate the total charge with wrapping fee
        public void calTotalChargeWithWrapping()
        {
            decimal wrappingCost = 5M;
            Wrapping = Delivery + wrappingCost;
        }

        //Calculate the total charge after GST
        public void calTotalChargeWithGST()
        {
            GST = Wrapping * 1.1M;
        }
    }
}
