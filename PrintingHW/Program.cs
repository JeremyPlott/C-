using System;

namespace PrintingHW {

    class Program {

        static void Main(string[] args) {

            //Define variables
            string firstname = "Jeremy";
            string lastname = "Plott";
            string city = "City";
            string state = "??";
            string zip = "12345";
            string address = "1234 Hello World St.";
            string phone = "123-456-7890";
            string email = "notenoughlette@aol.com";


            Console.WriteLine("Hello World! Here's all of my personal information!");
            Console.WriteLine("My name is " + firstname + " " + lastname + ".");
            Console.WriteLine("I live at " + address + ", " + city + " " + state + ", " + zip + "."); //all of these spaces could be put into the variables for cleaner code
            Console.Write("My phone number is " + phone + " and ");
            Console.Write("my email address is " + email);
            Console.WriteLine(". Tune in next week for my social!");
        }
    }
}
