using Cores;
using System.Diagnostics;

namespace _03.CompositionWithTasks
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();

            PourCoffee();
            Console.WriteLine("coffee is ready");

            Task toastTask = MakeToastWithButterAndJamAsync(2);
            Task eggsTask = FryEggsAsync(2);
            Task baconTask = FryBaconAsync(3);

            await toastTask;
            Console.WriteLine("toast is ready");

            PourOJ();
            Console.WriteLine("oj is ready");

            await eggsTask;
            Console.WriteLine("eggs are ready");

            await baconTask;
            Console.WriteLine("bacon is ready");
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

        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            await Task.Delay(3000);
            Console.WriteLine("Remove toast from toaster");
            return new Toast();
        }
        private static async Task MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);
        }

        private static async Task FryBaconAsync(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            await Task.Delay(3000);
            Console.WriteLine("Put bacon on plate");
        }

        private static async Task FryEggsAsync(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            await Task.Delay(3000);
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            await Task.Delay(3000);
            Console.WriteLine("Put eggs on plate");
        }

        private static void PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
        }
    }
}