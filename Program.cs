using System;
using System.Diagnostics.Tracing;
using System.Runtime.Intrinsics.Arm;

namespace PracticeSet01
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string str = "shadab hasan khan";
            //string reverseStr = "";

            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    reverseStr = reverseStr + str[i];
            //}
            //Console.WriteLine(reverseStr);
            //*********************************************************************************************************
            //string str = "shadab hasan khan";
            //string[] spcArr = str.Split(" ");
            //string revstr = "";
            //foreach (var a in spcArr)
            //{
            //    char[] arr = a.ToCharArray();
            //    for (int i = arr.Length - 1; i >= 0; i--)
            //    {
            //        revstr = revstr + arr[i];
            //    }
            //    revstr = revstr + " ";
            //}
            //Console.WriteLine(revstr);
            //*********************************************************************************************************
            //int num = 1221;
            //int rem;
            //int result = 0;
            //int temp = num;

            //while(num>0)
            //{
            //    rem = num % 10;
            //    result = result*10 + rem;
            //    num = num / 10;
            //}
            //num = temp;
            //Console.WriteLine(result);
            //if(num== result)
            //{
            //    Console.WriteLine("Palindrome");
            //}
            //else 
            //{ 
            //    Console.WriteLine("Not a Palindrome");
            //}
            //*********************************************************************************************************

            //for(int i=0; i<=5; i++)
            //{
            //    for(int j=1; j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 4; i >= 0; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //*********************************************************************************************************
            //string name = "shadab hasan khan";

            //Dictionary<char, int> counts = new Dictionary<char, int>();
            //foreach(char ch in name)
            //{
            //    if(!counts.ContainsKey(ch))
            //    {
            //        counts.Add(ch, 1);
            //    }
            //    else
            //    {
            //        counts[ch]++;
            //    }
            //}
            //foreach(var word in counts)
            //{
            //    Console.WriteLine(word);
            //}
            //*********************************************************************************************************
            // int count = 0; 

            //for(int number =1000; number<= 1999 && count < 4; number++) 
            //{
            //    int temp = number;
            //    int reverse = 0;
            //    int rem;

            //    while (temp > 0) 
            //    {
            //        rem = temp % 10;
            //        reverse = reverse * 10 + rem;
            //        temp = temp / 10;
            //    }

            //    if(number == reverse)
            //    {
            //        Console.WriteLine(number);
            //        count++;
            //    }
            //}
            //*********************************************************************************************************
            //int rem;
            //int result = 0;
            //Console.WriteLine("Please enter any number");
            //int num = int.Parse(Console.ReadLine());
            //int temp = num;
            //while(num>0)
            //{
            //    rem = num % 10;
            //    result = result + rem * rem * rem;
            //    num = num / 10;
            //}
            //if(temp==result) 
            //{
            //    Console.WriteLine("Armstrong");
            //}
            //else
            //{
            //    Console.WriteLine("Not aArmstrong");
            //}
            //int[] number = { 2, 5, 8, 9, 20 };
            //int max = number[0];
            //int secmax = number[0];
            //for (int i = 0; i <= number.Length - 1; i++)
            //{
            //    if (number[i] > max)
            //    {
            //        secmax = max;
            //        max =  number[i];
            //    }
            //    else if (number[i] < secmax)
            //    {
            //        secmax = number[i];
            //    }
            //}
            //Console.WriteLine(max);
            //Console.WriteLine(secmax);


            string str = "shadab hasan khan";
            Dictionary<char, int> counts = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (!counts.ContainsKey(str[i]))
                {
                    counts.Add(str[i], 1);

                }

            }
            foreach (var item in counts)
            {

                Console.WriteLine("{0}={1}", item.Key, item.Value.ToString());
            }

            //Console.Write("Enter a String : ");
            //string inputString = "shadab hasan khan";
            //string resultString = "";
            //for (int i = 0; i < inputString.Length; i++)
            //{
            //    if (!resultString.Contains(inputString[i]))
            //    {
            //        resultString += inputString[i];
            //    }
            //}
            //Console.WriteLine(resultString);

            //string str = "Shadab Hasan Khan";
            //char[] retrnStr = str.ToCharArray();
            //string result = "";
            //foreach (var ch in retrnStr)
            //{
            //    if (char.IsLower(ch))
            //    {
            //        result = result + ch.ToString().ToUpper();
            //    }
            //    else if (char.IsUpper(ch))
            //    {
            //        result = result + ch.ToString().ToLower();
            //    }
            //    else
            //    {
            //        result = result + ch;
            //    }

            //}
            string name = "Shadab";
            string rev = "";
            for (int i = 0; i < name.Length - 1; i += 2)
            {
                //rev += name[i + 1];
                rev += name[i];
            }

            Console.WriteLine(rev);

            int count = 0;
            for(int i=5; i>=0; i--)
            {
                if(i == count)
                {
                    count++;
                    i = 5;
                    Console.WriteLine();
                    if(i==5 && count==5)
                    {
                        break;
                    }
                }
                
                Console.Write("*");

            }
        }
    }
}