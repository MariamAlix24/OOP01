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
            /* When a Struct is copied, a completely independent copy of the data is created in memory (Value Type).
             Modifying 'address2' will NOT affect 'address1'. 'address1.City' remains "New York" because each variable holds its own data on the Stack.*/
            #endregion
        }
    }
}
