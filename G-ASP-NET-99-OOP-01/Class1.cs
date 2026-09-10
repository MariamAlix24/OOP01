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
    #region 1-Create a DeliveryAddress struct with:
    public struct DeliveryAddress
    {
        public string city;
        public string street;
        public int BuildingNumber;
        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            this.city = city;
            this.street = street;
            this.BuildingNumber = buildingNumber;
        }
        public string GetFullAddress()
        {
            return $"{BuildingNumber} {street}, {city}";
        }
    }
    #endregion
}


