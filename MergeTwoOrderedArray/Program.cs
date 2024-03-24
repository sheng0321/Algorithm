

namespace MergeTwoOrderedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //two ordered arraries
            int[] array1 = { 4, 9, 15, 24, 30 };
            int[] array2 = { 2, 6, 18, 20 };
            int[] res = MergeTwoOrderedArray2(array1, array2);
            //output
            foreach (int i in res)
            {
                Console.Write(i + ", ");
            }
        }

        private static int[] MergeTwoOrderedArray2(int[] array1, int[] array2)
        {
            int low1 = 0;
            int high1 = array1.Length ;
            int low2 = 0;
            int high2 = array2.Length;

            int[] temp= new int[array1.Length+array2.Length];
            int i = 0;
            while(low1<high1 && low2< high2)
            {
                if (array1[low1] < array2[low2]) {
                    temp[i++] = array1[low1++];

                }
                else
                {
                    temp[i++] = array2[low2++];
                }
            }
            while (low1 < high1)
            {
                temp[i++] = array1[low1++];

            }
            while (low2 < high2)
            {
                temp[i++] = array2[low2++];

            }

            return temp;


        }

        private static int[] MergeTwoOrderedArray1(int[] array1, int[] array2)
        {
            int[] res = new int[array1.Length + array2.Length];
            int array1Index = 0;
            int array2Index = 0;

            for (int i = 0; i < res.Length; i++)
            {
                if (array1Index == array1.Length)
                {
                    res[i] = array2[array1Index];
                    array2Index++;
                }
                else if (array2Index == array2.Length)
                {
                    res[i] = array1[array1Index];
                    array1Index++;
                }
                else if (array1[array1Index] < array2[array2Index] && array1Index < array1.Length && array2Index < array2.Length)
                {
                    res[i] = array1[array1Index];
                    array1Index++;
                }
                else
                {
                    res[i] = array2[array2Index];
                    array2Index++;
                }

            }
            return res;

        }
    }
}
