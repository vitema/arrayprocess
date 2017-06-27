using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingNumbers
{
    public class ProcessNumbers
    {

        /// <summary>
        /// структура для пар значений, переопределен метод Equals, 
        /// чтобы исключить повторения, когда отличаются только позиции в паре, а значения одинаковые
        /// </summary>
      public  struct NumberPair
        {
            public int number1;
            public int number2;
            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;

                var compareObj = (NumberPair)obj;

                if ((this.number1 == compareObj.number1 && this.number2 == compareObj.number2) || (this.number1 == compareObj.number2 && this.number2 == compareObj.number1))
                    return true;

                return false;

            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }


        public static IEnumerable<NumberPair> FindPairs(int[] numberArray, int number)
        {
         
            var count = numberArray.Length;

            var res =
                    (from i in ParallelEnumerable.Range(0, count)
                    from j in ParallelEnumerable.Range(i + 1, count - (i + 1))
                    where (numberArray[i] + numberArray[j] == number)
                    select (new NumberPair { number1 = numberArray[i], number2 = numberArray[j] })).Distinct();

            return res;

        }

    }
}
