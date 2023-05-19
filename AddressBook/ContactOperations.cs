using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace AddressBook
{
    class ContactOperations
    {
        //List Creation
        public List<Contacts> contactlist;

        public ContactOperations()
        {
            contactlist = new List<Contacts>();
        }

        //Add method for adding the contacts in the contact list
        public void AddContact(Contacts c)
        {
            contactlist.Add(c);

        }

        //Edit method for editing the contacts in the contact list
        public void EditContact(string name)
        {
                foreach (var contact in contactlist)
                {
                if (contact.firstName.Equals(name))
                {
                    while (contact.firstName.Equals(name))
                    {
                        Console.WriteLine("Enter the First Name :");
                        contact.firstName = Console.ReadLine();

                        Console.WriteLine("Enter the Last Name :");
                        contact.lastName = Console.ReadLine();

                        Console.WriteLine("Enter the Address :");
                        contact.address = Console.ReadLine();

                        Console.WriteLine("Enter the City :");
                        contact.city = Console.ReadLine();

                        Console.WriteLine("Enter the Zip code :");
                        contact.zipCode = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the State :");
                        contact.state = Console.ReadLine();

                        Console.WriteLine("Enter the Email :");
                        contact.email = Console.ReadLine();

                        Console.WriteLine("Enter the Phone number :");
                        contact.phoneNumber = int.Parse(Console.ReadLine());

                        Console.WriteLine();
                        Console.WriteLine("Contact Edited Successfully ");
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------------");
                        break;

                    }
                    
                }
                else { 
                    Console.WriteLine("Contact not found"); 
                }
             
                }
        }

        //Remove method for removing the contacts from the contact list
        public void removeContact(string name)
        {
            Contacts c = find(name);
            if(c != null)
            {
                contactlist.Remove(c);
                Console.WriteLine("Contact removed successfully");
            }
            else
            {
                Console.WriteLine("No contact found");
            }
           


        }

        //Find method for searching the contact in the contact list
        public Contacts find(string name)
        {
            Contacts c = contactlist.Find(delegate (Contacts c)
            {
                return c.firstName == name;
            }
            );
            return c;
        }

        //Display method for displaying the contacts in the list
        public void displayContact()
        {
            if (contactlist.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("CONTACT DETAILS");
                Console.WriteLine("----------------------------------------------------");
                foreach (var contact in contactlist)
                {
                    Console.WriteLine("First Name : " + contact.firstName);
                    Console.WriteLine("Last Name : " + contact.lastName);
                    Console.WriteLine("Address : " + contact.address);
                    Console.WriteLine("City : " + contact.city);
                    Console.WriteLine("Zip Code : " + contact.zipCode);
                    Console.WriteLine("State : " + contact.state);
                    Console.WriteLine("Email : " + contact.email);
                    Console.WriteLine("Phone Number : " + contact.phoneNumber);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("ADDRESS BOOK IS EMPTY");
                Console.WriteLine("----------------------------------------------------");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Creating object of class ContactOperations
            ContactOperations contactOperations = new ContactOperations();

            //Menu driven Program
            Console.WriteLine("**************ADDRESS BOOK**************");
            Console.WriteLine();

            int choice = 0;

            while (choice != 5)
            {
                Console.WriteLine("MENU FOR CONTACT OPERATIONS");
                Console.WriteLine("1.Add Contact \n2.Edit Contact \n3.Remove Contact \n4.Display Contact \n5.Exit");

                Console.WriteLine("----------------------------------------------------");

                Console.WriteLine("Enter choice :");
                choice = int.Parse(Console.ReadLine());

                Console.WriteLine("----------------------------------------------------");


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("ADD CONTACT DETAILS");

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
                                firstName = firstName,
                                lastName = lastName,
                                address = address,
                                city = city,
                                zipCode = zip,
                                state = state,
                                email = email,
                                phoneNumber = phoneNumber
                                
                        };
                            contactOperations.AddContact(c);
                            Console.WriteLine("Contact Added Successfully");
                        }
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------------");
                        break;

                    case 2:
                        Console.WriteLine("EDIT CONTACT DETAILS");

                        Console.WriteLine("Enter the name :");
                        string name = Console.ReadLine();

                        contactOperations.EditContact(name);
                        
                        break;

                    case 3:
                        Console.WriteLine("REMOVE CONTACT DETAILS");

                        Console.WriteLine("Enter the name :");
                        name = Console.ReadLine();

                        contactOperations.removeContact(name);
                        
                        break;


                    case 4:
                        contactOperations.displayContact();
                        break;

                }
            }
        }

    }

}
