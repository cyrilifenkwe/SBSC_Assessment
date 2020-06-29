using System;

namespace HyphenSeparatedNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetResult("3-c-5-6-7"));
        }
        public static bool GetResult(string givenString)
        {
            try
            {

                bool result = true;
                if(givenString.Contains("-") == false)
                {
                    result = false;
                }
                else
                {                
                    var splitted = givenString.Split("-");
                    double intervalValue = double.Parse(splitted[1]) - double.Parse(splitted[0]);
                    for(int i=0;i<splitted.Length;i++)
                    {
                        if(i+1 != splitted.Length)
                        {
                            var interval = double.Parse(splitted[i + 1]) - double.Parse(splitted[i]);
                            if(intervalValue == interval && result == true)
                            {
                                result = true;
                            }
                            else{
                                result = false;

                            }
                        }
                    }
                }
            
                return result;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
