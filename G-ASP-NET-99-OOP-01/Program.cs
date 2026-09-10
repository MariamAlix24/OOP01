namespace G_ASP_NET_99_OOP_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1(a)
            DeliveryAddress address1 = new DeliveryAddress { city = "New York" , street = "NY" };
            DeliveryAddress address2 = address1;
            address2.city = "Los Angeles";
            Console.WriteLine($"Address1 City: {address1.city}"); // Output: Address1 City: New York
            Console.WriteLine($"Address2 City: {address2.city}"); // Output: Address2 City: Los Angeles
            /* When a Struct is copied, a completely independent copy of the data is created in memory (Value Type).
             Modifying 'address2' will NOT affect 'address1'. 'address1.City' remains "New York" because each variable holds its own data on the Stack.*/
            #endregion
            #region Question1(B)
            Customer customer1 = new Customer { name = "John Doe" }; 
            Customer customer2 = customer1;
            customer2.name = "Jane Smith";
            Console.WriteLine($"Customer1 Name: {customer1.name}");
            Console.WriteLine($"Customer2 Name: {customer2.name}");
            /* When a Class is copied, only the reference (memory address) is copied, not the object itself (Reference Type).
            Both 'customer1' and 'customer2' point to the exact same object in the Heap. Modifying 'customer2.name' WILL change 'customer1.name' to "Jane Smith". */
            #endregion
            #region Question2(AandB)
            Shipment shipment = new Shipment();
            shipment.Description = "box of books";
            shipment.Weight = 3.5;
            shipment.DeliveryFee = 40.0m;
            Console.WriteLine($"Shipment Description: {shipment.Description}");
            Console.WriteLine($"Shipment Weight: {shipment.Weight}");
            Console.WriteLine($"Shipment Delivery Fee: {shipment.DeliveryFee}");
            // Answer(A)
            /*1-Public fields break encapsulation: The fields are exposed directly, allowing any outside code to modify them without restriction.
             2-No data validation: There is no control over input values, which allows invalid data like negative numbers for ⁠Weight⁠ or ⁠DeliveryFee⁠.
             3-Risk of unwanted modifications (Mutable Struct): Exposing public fields directly in a struct makes it mutable, leading to unpredictable bugs when copying values.*/
            // Answer(B)
            /* 1-Private fields: Hide the internal data from direct outside access.
             2-Public properties: Provide controlled access using getters and setters, allowing us to add validation logic to prevent invalid values (like negative numbers).*/
            #endregion
        }
    }
}
