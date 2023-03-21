using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1.LinearTable
{
    public static class LinearTableOperations
    {
        public static void ShowLinearTable(int[] linearTableInput) 
        {
            for (int i = 0; i < linearTableInput.Length; i++)
            {
                if (i == linearTableInput.Length - 1)
                    Console.Write("[" + i + "] = " + linearTableInput[i]+"\n");
                else
                    Console.Write("[" + i + "] = " + linearTableInput[i] + ", ");
            }
        }
        public static int[] AddNewValue(int[] linearTableInput, int newValue) 
        {
            Console.WriteLine("\nAdd New Value -> "+newValue+"\n");
            
            int[] linearTableTemporary = new int[linearTableInput.Length+1];
            
            for (int i = 0; i < linearTableInput.Length;i++) 
            {
                linearTableTemporary[i] = linearTableInput[i];
            }
            linearTableTemporary[linearTableInput.Length] = newValue;
            return linearTableTemporary;
        }
        public static int[] AddNewValueInIndex(int[] linearTableInput, int newValue, int index) 
        {
            Console.WriteLine("\nAdd New Value -> " + newValue+" In Index -> ["+index+"]\n");

            int[] linearTableTemporary = new int[linearTableInput.Length + 1];

            for (int i = 0; i < linearTableInput.Length; i++)
            {
                if(i < index)
                    linearTableTemporary[i] = linearTableInput[i];
                else
                    linearTableTemporary[i + 1] = linearTableInput[i];
            }            
            linearTableTemporary[index] = newValue;
            return linearTableTemporary;
        }
        public static int[] DeleteValueInIndex(int[] linearTableInput,  int index) 
        {
            Console.WriteLine("\nDelete Index -> " + index + "\n");

            int[] linearTableTemporary = new int[linearTableInput.Length - 1];
            for (int i = 0; i<linearTableInput.Length;i++) 
            {
                if (i < index)
                    linearTableTemporary[i] = linearTableInput[i];
                if(i>index)
                    linearTableTemporary[i-1] = linearTableInput[i];
            }
            return linearTableTemporary;
        }
        public static int GetMinValueInLinearTable(int[] linearTableInput)
        {
            Console.WriteLine("\nCatching the Min Value in Linear Table\n");
            int minIndex = 0;            
            for (int j = 1; j < linearTableInput.Length; j++)
            {
                if (linearTableInput[minIndex] > linearTableInput[j])
                    minIndex = j;
            }
            return linearTableInput[minIndex]);

        }
        public static int GetIndexByValue(int[] linearTableInput, int value) 
        {
            Console.WriteLine("\nCatching Index by Value in Linear Table\n");
            bool isSearch = false;
            var result = -1;
            for (int i = 0; i < linearTableInput.Length; i++) 
            {
                if (linearTableInput[i] == value) 
                {
                    isSearch = true;                    
                    result =  i;
                    break;
                }
            }
            if (!isSearch)
                result = -1;
            return result;
        }
        public static int GetIndexByValueWhithBinarySearch(int[] linearTableInput, int value)
        {
            Console.WriteLine("\nCatching Index by Value in Linear Table with Binary Search\n");
            int minor = 0, half = 0, major = linearTableInput.Length - 1;
            while (minor <= major)
            {
                half = (minor + major) / 2;
                if (linearTableInput[half] == value)
                    return half;
                else if (linearTableInput[half] < value)
                    minor = half + 1;
                else if (linearTableInput[half] > value)
                    minor = half - 1;
            }
            return -1;
        }
        public static void BubbleSorting(int[] linearTableInput) 
        {
            Console.WriteLine("\nSorting Linear Table\n");

            for (int i = 0;i< linearTableInput.Length-1;i++) 
            {
                bool isSwap = false;
                for (int j=0;j< linearTableInput.Length-1;j++) 
                {
                    if (linearTableInput[j]> linearTableInput[j+1]) 
                    { 
                        int flag = linearTableInput[j];
                        linearTableInput[j] = linearTableInput[j+1];
                        linearTableInput[j + 1] = flag;
                        isSwap = true;
                    }
                }
                if (!isSwap)     
                    break;              
                
            }
        }        
        public static void SelectSorting(int[] linearTableInput)
        {
            Console.WriteLine("\nSelect Sorting Linear Table\n");

            int len = linearTableInput.Length - 1;
            int minIndex;
            for (int i = 0;i<len;i++) 
            {
                minIndex = i;
                int minValue = linearTableInput[minIndex];
                for (int j = i;j<len;j++) 
                { 
                    if(minValue > linearTableInput[j + 1]) 
                    { 
                        minValue = linearTableInput[j+1];
                        minIndex = j + 1;
                    }
                }
                if (i != minIndex) 
                {
                    int temp = linearTableInput[i];
                    linearTableInput[i] = linearTableInput[minIndex];
                    linearTableInput[minIndex] = temp;
                }
            }
        }
        public static void InsertSorting(int[] linearTableInput) 
        {
            Console.WriteLine("\nInsert Sorting Linear Table\n");

            for (int i = 0; i < linearTableInput.Length;i++) 
            {
                int insertValue = linearTableInput[i];
                int insertIndex = i;
                for (int j = insertIndex-1;j>=0;j--) 
                {
                    if (insertValue < linearTableInput[j]) 
                    {
                        linearTableInput[j+1] = linearTableInput[j];
                        insertIndex--;
                    }
                }
                linearTableInput[insertIndex] = insertValue;
            }
        }
        public static void ReverseSorting(int[] linearTableInput) 
        {
            Console.WriteLine("\nReverse Sorting Linear Table\n");

            int lenght = linearTableInput.Length;
            int middle = lenght / 2;
            for (int i =0;i<=middle;i++) 
            {
                int temp = linearTableInput[i];
                linearTableInput[i] = linearTableInput[lenght - i - 1];
                linearTableInput[lenght - i - 1] = temp;
            }
        }
        
        
    }
}
