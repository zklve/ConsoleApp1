using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 65500;
            //ushort.

            var byt = new byte[] { 0xc1,0xb0,0x80,0x00};

            //byt = new byte[] { 0xb0, 0xc1, 0x00, 0x80 };
            Array.Reverse(byt);
            var ff=   BitConverter.ToSingle(byt, 0);
            Console.WriteLine(string.Format("{0,18}", ff));

            //10 00 04 00 = 268436480  intbyte = 00 04 00 10
            var intbyte = BitConverter.GetBytes(268436480);

            var ht =  BitConverter.GetBytes(28785);
            var kk = BitConverter.ToInt32(new byte[] { 0x00, 0x00, 0x70, 0x71 }, 0);

            while ( !string.IsNullOrEmpty( Console.ReadLine()))
            {
                for (int i = 0; i < 10; i++)
                {
 
                    var random = new Random(Guid.NewGuid().GetHashCode());
                    var seed = random.Next(1, ushort.MaxValue);
                    var now = DateTime.Now;
                    long ticks = now.Ticks;
                    Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss ffffff"));
                    DateTime newDate = new DateTime(ticks + seed);

                    Console.WriteLine(newDate.ToString("yyyy-MM-dd HH:mm:ss ffffff"));
      
                }
            }

          
             

            Console.WriteLine("Hello World!");
             Console.ReadLine();
        }
    }
}
