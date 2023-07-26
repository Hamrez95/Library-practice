namespace Library_practice.Customers
{

    public class Customer
    {
        public string Name { get; set; }
        public string ContactInfo { get; set; }

        // Constructor
        public Customer(string name, string contactInfo)
        {
            Name = name;
            ContactInfo = contactInfo;
        }
    }


}