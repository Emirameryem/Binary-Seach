using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static bool

        BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid= left+(right-left)/2;
                if (arr[mid] == target)
                {
                    return true;
                }
                else if (arr[mid] < target)
                {
                    left = mid+1;
                }
                else { right = mid-1; }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] numbers = {2,3,5,9,4,6,7};
            int target = 6;
            bool found= BinarySearch(numbers, target);
            if (found)
            {
                Console.WriteLine(target + " dizide bulundu");
            }
            else { Console.WriteLine(target + " dizide bulunamadı"); }
            Console.ReadLine();
        }
        
    }
}
