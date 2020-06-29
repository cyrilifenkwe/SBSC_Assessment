using System;
using System.Collections.Generic;

namespace AbsoluteDifference
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            List<int> givenList = new List<int>{1,2};
            Console.WriteLine(GetResult(3,givenList));
        }
        public static int GetResult(int k,List<int> givenList)
        {
            int count = 0;
            List<int> difference = new List<int>();
            int listLength = givenList.Count;
            try
            {
                    while(count <  listLength - 1)
                    {

                        for(int i = count + 1;i < givenList.Count;i++)
                        {
                            int absoluteDifference = givenList[i] - givenList[count];
                            if(givenList.LastIndexOf(absoluteDifference) <= -1)
                            {
                                givenList.Add(absoluteDifference); 
                            }
                        }
                        givenList.Sort();                    
                        count++;
                    }

                    givenList.Reverse();
                    return givenList[k - 1];
            }
            catch(Exception ex)
            {
                return -1;
            }
        }

            
    }
}
