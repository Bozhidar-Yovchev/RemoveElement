using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array:");
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine("Enter comparing  value:");
            int val = int.Parse(Console.ReadLine());
            int[] arr =  new int[nums.Length];
            int k = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]!=val)
                {
                    arr[k] = nums[i];
                    k++;
                } 
            }

            Console.WriteLine(k);
            
            
        }
    }
}
