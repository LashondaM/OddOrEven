using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nbrs = {

       754, 233, 509, 792, 700, 596, 833, 658, 998, 742,

       187, 754, 308, 914, 489, 867, 717, 586, 929, 467,

       460, 241, 770, 324, 599, 259, 120, 800, 336, 609,

       690, 134, 598, 249, 282, 574, 334, 956, 659, 214,

       435, 643, 809, 874, 906, 620, 328, 369, 426, 561

    };
            var highest = 1000;
            var lowest = 0;
            foreach(var nbr in nbrs) { 
                if(nbr > highest) {
                    highest = nbr;
                }
                if(nbr < lowest) {
                    lowest = nbr;
                }
            }
            Console.WriteLine($"Highest: {highest}, Lowest: {lowest}");


            //var high = 1000;
            //var low = 0;
            //foreach(var num in nbrs) { 
            //    if(num > high) {
            //        high = num;
            //    }
            //    if(num < low) {
            //        low = num;
            //    }
            //};
            //Console.WriteLine($"highest is: {high}, lowest is: {low}");


            //int total = 0;
            //for (var num = 0; num <= 50; num++) {
            //    if(num % 5 == 0) { 
            //        total += num;
            //        continue;
            //    };

            //    if (num % 7 == 0)
            //    {
            //        total += num;
            //    };

            //if (num % 5 == 0 || num % 7 == 0)
            //{
            //    total += num;
            //};
        //};
            //Console.WriteLine(total);
            //Console.WriteLine($"total is {total}");

            //var comma = "";
            //for (var i = 1; i <= 25; i++) {
            //    Console.Write($"{comma}  {i}");  //writes on the same line as well in the console
            //    comma = ",";
            //};

            //for (var idx = 0; idx < 5; idx++)
            //{
            //    //Console.WriteLine($"idx = {idx}");
            //    //Console.WriteLine("idx = " + idx);

            //    Console.Write("Enter an integer: ");
            //    var answer = Console.ReadLine();
            //    var value = Convert.ToInt32(answer);


            //    if (value % 2 == 0)
            //    {
            //        Console.WriteLine("The number is even");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number is odd");
            //    }
            //};

            //Console.Read();

        }
    }
}
