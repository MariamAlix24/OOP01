namespace G_ASP_NET_99_OOP_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1(a)
            //DeliveryAddress address1 = new DeliveryAddress { city = "New York" , street = "NY" };
            //DeliveryAddress address2 = address1;
            //address2.city = "Los Angeles";
            // Console.WriteLine($"Address1 City: {address1.city}"); // Output: Address1 City: New York
            // Console.WriteLine($"Address2 City: {address2.city}"); // Output: Address2 City: Los Angeles
            /* When a Struct is copied, a completely independent copy of the data is created in memory (Value Type).
             Modifying 'address2' will NOT affect 'address1'. 'address1.City' remains "New York" because each variable holds its own data on the Stack.*/
            #endregion
            #region Question1(B)
            Customer customer1 = new Customer { name = "John Doe" };
            Customer customer2 = customer1;
            customer2.name = "Jane Smith";
            // Console.WriteLine($"Customer1 Name: {customer1.name}");
            // Console.WriteLine($"Customer2 Name: {customer2.name}");
            /* When a Class is copied, only the reference (memory address) is copied, not the object itself (Reference Type).
            Both 'customer1' and 'customer2' point to the exact same object in the Heap. Modifying 'customer2.name' WILL change 'customer1.name' to "Jane Smith". */
            #endregion
            #region Question2(AandB)
            //Shipment shipment = new Shipment();
            // shipment.Description = "box of books";
            // shipment.Weight = 3.5;
            //shipment.DeliveryFee = 40.0m;
            //Console.WriteLine($"Shipment Description: {shipment.Description}");
            //Console.WriteLine($"Shipment Weight: {shipment.Weight}");
            //Console.WriteLine($"Shipment Delivery Fee: {shipment.DeliveryFee}");
            // Answer(A)
            /*1-Public fields break encapsulation: The fields are exposed directly, allowing any outside code to modify them without restriction.
             2-No data validation: There is no control over input values, which allows invalid data like negative numbers for ⁠Weight⁠ or ⁠DeliveryFee⁠.
             3-Risk of unwanted modifications (Mutable Struct): Exposing public fields directly in a struct makes it mutable, leading to unpredictable bugs when copying values.*/
            // Answer(B)
            /* 1-Private fields: Hide the internal data from direct outside access.
             2-Public properties: Provide controlled access using getters and setters, allowing us to add validation logic to prevent invalid values (like negative numbers).*/
            #endregion

            #region Part02 practical Smart Delivery System

            #region 1-Create a DeliveryAddress struct with:
            DeliveryAddress address1 = new DeliveryAddress("New York", "Main Street", 123);
            DeliveryAddress address2 = address1; // Copying the struct
            address2.city = "Los Angeles"; // Modifying the copy
            address2.street = "Sunset Boulevard";
            address2.BuildingNumber = 456;
            Console.WriteLine("Original Address: " + address1.GetFullAddress());
            Console.WriteLine("Modified Address: " + address2.GetFullAddress());

            #endregion 2.Ceate a Shipment struct
            /* Shipment shipment = new Shipment("TRK-9900", "Laptops", 3.0, 50.0, address1);

             Console.WriteLine("Tracking Code: " + shipment.TrackingCode);
             Console.WriteLine("Description: " + shipment.Description);
             Console.WriteLine("Weight: " + shipment.Weight);
             Console.WriteLine("Delivery Fee: " + shipment.DeliveryFee);
             Console.WriteLine("Estimated Cost: " + shipment.EstimatedCost);*/


            #region Add constructor overloading to Shipment:




            #endregion

            #region 6. In Main, build a Console Application that does the following:
            DeliveryCenter center = new DeliveryCenter();
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine($"Enter details for shipment {i} Data");
                Console.Write("Tracking Code: ");
                string code = Console.ReadLine();

                Console.Write("Description: ");
                string desc = Console.ReadLine();

                Console.Write("Weight: ");
                double.TryParse(Console.ReadLine(), out double weight);

                Console.Write("Delivery Fee: ");
                decimal.TryParse(Console.ReadLine(), out decimal fee);

                Console.Write("City: ");
                string city = Console.ReadLine();

                Console.Write("Street: ");
                string street = Console.ReadLine();

                Console.Write("Building Number: ");
                int.TryParse(Console.ReadLine(), out int bNum);

                DeliveryAddress address = new DeliveryAddress(city, street, bNum);
                Shipment shipment = new Shipment(code, desc, weight, (double)fee, address);
                if (center.AddShipment(shipment))
                {
                    Console.WriteLine("Shipment added successfully.");
                }
                Console.WriteLine("ALL Shipments:");
                
            }

            for (int i = 0; i < 3; i++)
            {
                Shipment s = center[i];
                s.Printshipment();
                Console.WriteLine();
            }
            Console.Write("Enter a tracking code to search: ");
            string searchCode = Console.ReadLine();

                        Shipment foundShipment = center[searchCode]; 

            if (!string.IsNullOrEmpty(foundShipment.TrackingCode))
            {
                Console.WriteLine($"Shipment found: {foundShipment.TrackingCode} - {foundShipment.Description}\n");
            }
            else
            {
                Console.WriteLine("Shipment not found.\n");
            }       Console.WriteLine("Struct Copy Test");
            DeliveryAddress originalAddress = new DeliveryAddress("Cairo", "Tahrir Street", 15);

            DeliveryAddress copiedAddress = originalAddress;

            copiedAddress.street = "Makram Ebeid Street";
            copiedAddress.BuildingNumber = 20;
            Console.WriteLine($"Original Address: {originalAddress.GetFullAddress()}");
            Console.WriteLine($"Copied Address: {copiedAddress.GetFullAddress()}");
            #endregion
            #endregion
        }
    }
}