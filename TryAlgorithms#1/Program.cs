using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryAlgorithms_lib_cs;

namespace TryAlgorithms_1 {
    internal class Program {
        static void Main(string[] args) {
            /* RdmVal=Random.Equals(new Random().Next());*/
            Random rdmVal = new Random();
            rdmVal.Next(0, 30);
            HeapSort(rdmVal) = HSort;
            Console.WriteLine(HSort);
        }
    }
}
