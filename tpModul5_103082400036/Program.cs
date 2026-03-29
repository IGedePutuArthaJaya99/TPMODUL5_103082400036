using System;

namespace tpmodul5_103082400036
{
    // Class DataGeneric sesuai tabel class model
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

            DataGeneric<string> dataNIM = new DataGeneric<string>("103082400036");
            dataNIM.PrintData();
        }
    }
}