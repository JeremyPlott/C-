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

            //looping with while

            var ints = new int[] { 1, 2, 3, 4, 5 }; //don't forget about zero base
            var total = 0;
            var index = 0;

            while (index < 5) {
                total = total + (ints[index] * ints[index]);
                index = index + 1;
            }
            Console.WriteLine("The total is " + total);


            //looping with for

            //first part happens once to create increment variable. Middle is boolean which then executes body code. 
            //Last executes after body, then returns to middle.
            total = 0;
            for (var idx = 0; idx < 5; idx = idx +1) {
                total = total + (ints[idx] * ints[idx]);
            }
            Console.WriteLine("The total is " + total);

            //compute the average exercise

            var scores = new int[] { 738, 609, 307, 959, 805, 689, 402, 972, 359, 140 };

            total = 0;
            for(var entry = 0; entry < 10; entry = entry + 1) {
                total = total + scores[entry];
            }
            var avgscore = total / 10;

            Console.WriteLine("The average score is " + avgscore);


            //cleaner code
            total = 0;
            avgscore = 0;
            for (var entry = 0; entry < scores.Length; entry++) {
                total += scores[entry];
            }
            avgscore = total / scores.Length;

            Console.WriteLine("The average score is " + avgscore);

            //a += 1 is abbv. for a = a + 1.
            //When adding or subtracting 1 it can be further shortened to a++ or a--.
            //a++; and ++a; are the same when stand-alone statements. If ++a is on the right side of = it makes a difference.

            //var a = 0;
            //var b = a++; This line assigns the value of b first and then increments a.
            //var c = ++a; This line will increment a and then assign it to c. 

            //b = 0, a = 1. for first 2 lines.
            //add third line results in a = 2, c = 2. 


            //looping with foreach()
            total = 0;
            foreach(var score in scores) {
                total += score;
            }
            Console.WriteLine("The grand total is " + total);
        }
    }
}