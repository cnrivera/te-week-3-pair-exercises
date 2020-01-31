using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Classes
{
    public class StringCalculator
    {

        
        public int Add(string numbers)
        {
            int numResult = 0;

            if (numbers == "")
            {
                numResult = 0;
                return numResult;
            }

            

            string[] strArray = numbers.Split(',','\n');
            
            foreach (string num in strArray)
            {
                numResult += int.Parse(num);                
            
            }
            return numResult;

           




        }

    }
}
