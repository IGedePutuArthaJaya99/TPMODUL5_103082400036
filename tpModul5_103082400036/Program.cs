using System;

namespace tpmodul5_103082400036
{
    // Class dari branch generic-method
    public class HaloGeneric
    {
        public void SapaUser<T>(T x)
        {
            Console.WriteLine("Halo user " + x);
        }
    }

    // Class dari branch generic-class
    public class DataGeneric<T>
    {
        public T Data { get; set; }

        public DataGeneric(T data)
        {
            this.Data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + this.Data);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
         
            HaloGeneric halo = new HaloGeneric();
            halo.SapaUser<string>("I GEDE PUTU ARTHA JAYA WINANGUN"); 

      
            DataGeneric<string> dataNIM = new DataGeneric<string>("103082400036");
            dataNIM.PrintData();
        }
    }
}