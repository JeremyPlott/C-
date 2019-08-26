using System;

//here's a comment

namespace HelloWorldProject {

    class Program {

        static void Main(string[] args) {
            Console.Write("Hello C# Bootcamp World! ");
            Console.WriteLine("At MAX Technical Training.");
            Console.WriteLine("Write vs WriteLine can be seen here.");

            int daysInBootcamp = 6;
            if (daysInBootcamp == 6) {
                Console.WriteLine("Yes.");
            } else {
                Console.WriteLine("No.");
            }

            string instructor = "";
            string lastname = "Doud";
            instructor = "Greg";

            Console.Write("The instructor is named ");
            Console.WriteLine(instructor);

            Console.WriteLine(instructor + " " + lastname);
            Console.WriteLine("The instructor is named " + instructor + " " + lastname);
        }
    }
}