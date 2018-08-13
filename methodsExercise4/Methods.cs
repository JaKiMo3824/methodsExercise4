using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsExercise4
{
    public class Methods
    {
        public int Problem1(int num1, int num2 = 4)
        {
            int result = (num1 + num1) + (num2 + num2);
            return result;
        }
    }
}
