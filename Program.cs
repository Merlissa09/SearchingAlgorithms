namespace SearchingAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 1, 2, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int arr1Result = LinearSearch(arr1, 4);
            Console.WriteLine(arr1Result);
        }

        public static int LinearSearch(int[] arrToSearch, int target)
        {
            // int i = 0 - initializing our loop conditional - in this case to 0
            // next we evaluate if the value meets the condition
            // after each loop we run the update logic
            // Big O - O(n)
            // Big Omega - O(1)
            for (int i = 0; i < arrToSearch.Length; i++)
            {
                if (arrToSearch[i] == target) return i;
            }

            return -1;
        }

        /// <summary>
        /// This is my binary search. target means ....
        /// </summary>
        /// <param name="arrToSearch"> The array to search </param>
        /// <param name="target"> target is the value you want to search for</param>
        /// <returns></returns>
        public static int BinarySearch(int[] arrToSearch, int target)
        {
            int lower = 0;
            int upper = arrToSearch.Length - 1;

            while (lower <= upper)
            {
                int mid = (lower + upper) / 2;
                if(arrToSearch[mid] == target) return mid;
                else if (target < arrToSearch[mid])
                {
                    upper = mid - 1;
                } else
                {
                    lower = mid + 1;
                }
            }

            return -1;
        }
    }
}
