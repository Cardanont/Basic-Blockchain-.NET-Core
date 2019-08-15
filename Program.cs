using BasicBlockchain.DataStructure;
using Newtonsoft.Json;
using System;

namespace BasicBlockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockchain practiceCoin = new Blockchain();
            practiceCoin.AddBlock(new Block(DateTime.Now, null, "{sender:Henry,receiver:MaHesh,amount:1000}"));
            practiceCoin.AddBlock(new Block(DateTime.Now, null, "{sender:MaHesh,receiver:Henry,amount:5}"));
            practiceCoin.AddBlock(new Block(DateTime.Now, null, "{sender:MaHesh,receiver:Henry,amount:7}"));

            Console.WriteLine(JsonConvert.SerializeObject(practiceCoin, Formatting.Indented));
        }
    }
}
