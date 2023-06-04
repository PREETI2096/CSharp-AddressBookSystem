namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System Program");
            Console.WriteLine("Please enter contact details");
            Contact contact = new Contact();
            Console.WriteLine("Enter first name of contact");
            contact.firstName = Console.ReadLine();
            Console.WriteLine("Enter last name of contact");
            contact.lastName = Console.ReadLine();
            Console.WriteLine("Enter address of contact");
            contact.address = Console.ReadLine();
            Console.WriteLine("Enter city of contact");
            contact.city = Console.ReadLine();
            Console.WriteLine("Enter state of contact");
            contact.state = Console.ReadLine();
            Console.WriteLine("Enter zipCode of contact");
            contact.zipcode = Console.ReadLine();
            Console.WriteLine("Enter phoneNumber of contact");
            contact.phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter email of contact");
            contact.email = Console.ReadLine();
            Console.WriteLine(contact.ToString());
        }
    }
    }
