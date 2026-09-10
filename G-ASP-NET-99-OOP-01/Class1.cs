using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_99_OOP_01
{
#region Question1 And 2

	/*public struct DeliveryAddress
    {
        public string city;
        public string street;
    }*/
    public class Customer
    {
        public string name;
      
    }
    public struct Shipment { 
        private string description;
        private double weight;
        private decimal deliveryFeee;
        public string Description {
            get {
                return description;
            }
            set {
                description = value;
                } 
         }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value>=0 ? value : 0;
            }
        }
        public decimal DeliveryFee
        {
            get
            {
                return deliveryFeee;
            }
            set
            {
                deliveryFeee = value >= 0 ? value : 0;
            }
        }
    }
    #endregion
    public struct DeliveryAddress2
    {
        private string city;
        private string street;
        private int BuildingNumber;
        

    }


}


