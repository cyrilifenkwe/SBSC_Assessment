using System;
using System.Text;

namespace NumberOfOccurrence
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FormatResult("Occurrence"));
        }
        public static string FormatResult(string GivenString)
        {
            try
            {
                string givenString = GivenString.ToLower().Replace(" ","").Trim();
                StringBuilder builder = new StringBuilder();
                int count = 0;
                int occurrence = 0;
                while(count < givenString.Length)
                {
                    for(int i = 0; i < givenString.Length;i++)
                    {
                        if(givenString[count] == givenString[i])
                        {
                            occurrence++;
                        }
                    }
                    if(builder.ToString().LastIndexOf(givenString[count]) > -1)
                    {
                        occurrence = 0;
                        count++;
                    }
                    else
                    {
                        builder.Append(givenString[count]);
                        builder.Append(occurrence);
                        occurrence = 0;
                        count++;
                    }
                    
                }
            
                return builder.ToString();
                
            }
            catch(Exception ex)
            {
                return "";
            }
            
        }
    }
}
