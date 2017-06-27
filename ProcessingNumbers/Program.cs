using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProcessingNumbers
{
    class Program
    {


        struct NumberPair
        {
            public int number1;
            public int number2;
            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;

                var compareObj = (NumberPair)obj;

                if ((this.number1 == compareObj.number1 && this.number2 == compareObj.number2) 
                    || (this.number1 == compareObj.number2 && this.number2 == compareObj.number1)
                    
                    )
                    return true;

                return false;

            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }


        }




        static void Main(string[] args)
        {
            
            var numberArray = new int[10];
            var length = numberArray.Length;

           
            Console.WriteLine("Array of numbers:");
            for (var i = 0; i < length; i++)
            {
                numberArray[i] = i;
                Console.Write(i+" ");
              
            }
            Console.WriteLine();

            var random = new Random();
            var number = random.Next(1, length);
            Console.WriteLine("some number: {0}", number);


            var res = ProcessNumbers.FindPairs(numberArray, number);



            Console.WriteLine("Finded pairs:");
            Console.WriteLine(string.Join("; ",res.Select(x=>x.number1+"-"+x.number2)));
          
            Console.ReadLine();

        }





    }
}
