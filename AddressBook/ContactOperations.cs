namespace AddressBook
{
    class ContactOperations
    {
        //List Creation
        List<Contacts> contactlist;

        public ContactOperations()
        {
            contactlist = new List<Contacts>();
        }

        //Add method for adding the contacts in the list
        public void addContact(Contacts c)
        {
            contactlist.Add(c);

        }

        //Display method for displaying the contacts in the list
        public void displayContact()
        {
            Console.WriteLine();
            Console.WriteLine("CONTACT DETAILS");
            Console.WriteLine("----------------------------------------------------");

            foreach (var contact in contactlist)
            {
                Console.WriteLine("First Name : " + contact.FirstName);
                Console.WriteLine("Last Name : " + contact.LastName);
                Console.WriteLine("Address : " + contact.Address);
                Console.WriteLine("City : " + contact.City);
                Console.WriteLine("Zip Code : " + contact.Zip);
                Console.WriteLine("State : " + contact.State);
                Console.WriteLine("Email : " + contact.Email);
                Console.WriteLine("Phone Number : " + contact.PhoneNumber);
                Console.WriteLine();
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ContactOperations contactOperations = new ContactOperations();

            int size;
            Console.WriteLine("Enter the number of contacts to add : ");
            size = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int contactNum = 0; contactNum < size; contactNum++)
            {

                Console.WriteLine("Enter the First Name :");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter the Last Name :");
                string lastName = Console.ReadLine();

                Console.WriteLine("Enter the Address :");
                string address = Console.ReadLine();

                Console.WriteLine("Enter the City :");
                string city = Console.ReadLine();

                Console.WriteLine("Enter the Zip code :");
                int zip = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the State :");
                string state = Console.ReadLine();

                Console.WriteLine("Enter the Email :");
                string email = Console.ReadLine();

                Console.WriteLine("Enter the Phone number :");
                int phoneNumber = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Contacts c = new Contacts
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Address = address,
                    City = city,
                    Zip = zip,
                    State = state,
                    Email = email,
                    PhoneNumber = phoneNumber

                };
                contactOperations.addContact(c);
            }
            Console.WriteLine("----------------------------------------------------");

            contactOperations.displayContact();
        }

    }

}
