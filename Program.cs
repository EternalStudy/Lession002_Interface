namespace Lession002_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*IBits ibits = new Bits(99);
            ibits.GetBits(0);
            Console.WriteLine(ibits.GetBits(1));
            ibits.SetBits(1, true);
            Console.WriteLine(ibits.GetBits(1));*/
            Bits bits = new Bits(3);
            //Console.WriteLine(bits.Value);
            bits[1] = false;
            long num = (long)bits;
            Console.WriteLine(num);
        }
    }
}
