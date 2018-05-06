using System;

namespace pullUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            // basic c# program to exercise arrays.  program takes in a set of int's into
            // an array dimensioned at 100; once received, process the array with two nested
            // loops to determine whether arrayOfInts[i] is unique; if unique, copies to a
            // differnet array.  notable if an int is duplicated, it is compared 2x; one
            // at arrayOfInt[i] with arrayOfInt[i+increment] and then again with arrayOfInt[i+increment]
            // wiht arrayOfInt[i].  
            // 
            // will revise with a list that will allow pairs that are deemed dupliates to be removed
            // so that the processing load becomes less as we work through the list.  Unimportant computationally
            // with a small routine, but more important obviously with a larger dataset.
            
            int dimension = 100;

            int[] arrayOfInts = new int[dimension];
            int[] arrayOfUniqueInts = new int[dimension];
            int index = 0;
            int indexUnique = 0;

            Console.WriteLine("Unique number identifier");
            Console.WriteLine("Enter new numbers or 'Quit' to stop");
            string inputString = Console.ReadLine();

            while (inputString != "Quit")
            {
                arrayOfInts[index] = int.Parse(inputString);
                inputString = Console.ReadLine();
                index++;

            }

            // for(int i = 0; i < index + 1 ; i++)
            // {
            //    Console.WriteLine($"{arrayOfInts[i]}");
            // }

            // determine unique numbers in the array
            // algo:  take first number at location[0], cycle through 1..array.length
            //   if it doesn't appear, then push to the arrayOfUniqueInts
            //   go to [1]; cycle the ones before and the ones after, and see if unique
            //   if [1] is unique, copy to arrayOfUniqueInts

            for(int i = 0; i < index + 1; i++)
            {
                for(int j = 0; j < index + 1; j++)
                {
                    if(i != j)  // we won't compare an entry to itsef and generate a false-indication
                    {
                        if(arrayOfInts[i] == arrayOfInts[j])  // if
                        {
                            Console.WriteLine($"Array[{i}]: {arrayOfInts[i]} equals Array[{j}]: {arrayOfInts[j]}");
                            break;   // stop, this isn't unique; increment i and continue
                        } else if (j == index) // we have gotten all the way through
                        {
                            arrayOfUniqueInts[indexUnique] = arrayOfInts[i];
                            indexUnique++;
                        }

                    }

                }

            }

            for(var k = 0; k < indexUnique + 1; k++)
            {
                Console.WriteLine($"Unique Num[{k}] is {arrayOfUniqueInts[k]}");
            }

            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
