using System;

namespace tpmodul5_103082400036
{

    public class HaloGeneric
    {
        public void SapaUser<T>(T x)
        {
            Console.WriteLine("Halo user " + x);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();
   
            halo.SapaUser<string>("I GEDE PUTU ARTHA JAYA WINANGUN");
        }
    }
}