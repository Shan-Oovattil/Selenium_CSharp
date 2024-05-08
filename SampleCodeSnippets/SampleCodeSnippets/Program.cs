using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCodeSnippets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n1 = 12345;
            //int n2 = 45678;
            string n1 = 12345.ToString();
            string n2 = 45678.ToString();

            Program codeSnippets = new Program();

            //codeSnippets.IdentifyNonDuplicateNumbersWayOne(n1.ToString(), n2.ToString());

            codeSnippets.IdentifyNonDuplicateNumbersWayTwo(n1, n2);
        }

        void IdentifyNonDuplicateNumbersWayOne(string n1, string n2)
        {           
            string n1n2 = n1 + n2;
            char[] chars = n1n2.ToCharArray();
            List<string> duplicateValues = new List<string>();
            List<string> values = new List<string>();

            for (int i = 0; i < chars.Length - 1; i++)
            {
                for (int j = i + 1; j < chars.Length; j++)
                {
                    if (chars[i] == chars[j])
                    {                       
                        duplicateValues.Add(chars[i].ToString());
                    }
                }
            }

            foreach (char c in chars) 
            {
                values.Add(c.ToString());
            }                      

            Console.WriteLine("DISTINCT VALUES");

            for(int i=0; i< duplicateValues.Count;i++) 
            {
                values.Remove(duplicateValues[i]);
            }

            foreach (string s in values) 
            {
                Console.Write(s);
            }
            
            Console.ReadLine();         

        }
    
    
        void IdentifyNonDuplicateNumbersWayTwo(string n1, string n2)
        {
            string n1n2 = n1 + n2;
            char[] chars = n1n2.ToCharArray();
            Dictionary<string, int> dict = new Dictionary<string, int>();           
           
            for(int i=0; i< chars.Length; i++)
            {
                if (dict.ContainsKey(chars[i].ToString()))
                {
                    dict[chars[i].ToString()]++;                   
                }
                else
                {
                    dict.Add(chars[i].ToString(), 1);                    
                }
            }

            Console.WriteLine("DISTINCT VALUES");
            foreach (string s in dict.Keys)
                Console.WriteLine(s);
            Console.Read();

        }


    }
}
