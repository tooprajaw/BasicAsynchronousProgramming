using Cores;
using System.Diagnostics;

namespace SynchrousProgramming
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();

            PourCoffee();
            Console.WriteLine("coffee is ready");

            FryEggs(2);
            Console.WriteLine("eggs are ready");

            FryBacon(3);
            Console.WriteLine("bacon is ready");

            Toast toast = ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");

            PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");
            sw.Stop();
            Console.WriteLine($"Time usage : {sw.ElapsedMilliseconds}");
        }

        private static void PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
        }

        private static void ApplyJam(Toast toast)
        {
            // Apply jam to toast
            Console.WriteLine("Putting jam on the toast");
        }

        private static void ApplyButter(Toast toast)
        {
            // Apply butter to toast
            Console.WriteLine("Putting butter on the toast");
        }

        private static Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Remove toast from toaster");
            return new Toast();
        }

        private static void FryBacon(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            Task.Delay(3000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put bacon on plate");
        }

        private static void FryEggs(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            Task.Delay(3000).Wait();
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put eggs on plate");
        }

        private static void PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
        }
    }
}