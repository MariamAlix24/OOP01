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
    /*public struct Shipment { 
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
    }*/
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

    #region 2.Ceate a Shipment struct
    public struct Shipment
    {
        //private fields
        private string trackingCode;
        private string description;
        private double weight;
        private double deliveryFee;
        //public properties
        public string TrackingCode
        {
            get { return trackingCode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingCode = value;
                }
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }

        }
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }
        public double DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
            }
        }
        public DeliveryAddress Destination
        {
            get; set;

        }
        public double EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5);

            }
        }
        //Testing the Shipment struct
         public Shipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination)
         {
             this.trackingCode = !string.IsNullOrWhiteSpace(trackingCode) ? trackingCode : "UNKNOWN";
             this.description = !string.IsNullOrWhiteSpace(description) ? description : "No Description";
             this.weight = weight > 0 ? weight : 1.0;
             this.deliveryFee = deliveryFee > 0 ? deliveryFee : 10.0;
             this.Destination = destination;
         }
        #region Add constructor overloading to Shipment and Add two methods
        public Shipment(string trackingCode){
            this.trackingCode = !string.IsNullOrWhiteSpace(trackingCode) ? trackingCode : "UNKNOWN";
            this.description = "No Description";
            this.weight = 1.0;
            this.deliveryFee = 10.0;
            this.Destination = new DeliveryAddress("cairo", "Egypt",2 );
        }
        public void UpdateDeliveryFee(double newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }
        public void printshipment() {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}"); 
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}"); 
        }


        #endregion

    }

    #endregion
}


