using System;
//2018326660145
//Joshua Mikhay Kusuma
//Eratosthenes Prime Algorithm
namespace _2._3
{
    class Program
    {
        public static int findNotEqualToZero(int[] b, int m) //find the m numbers in array list that doesnt equal to 0
        {
            int n = 0;
            int c = 0;
            for (int i = 0; n < m; i++)
            {
                c++;
                //proceed, then determine
                if ((b[i]) != 0) //should be != 0
                {
                    n++;
                }
            }
            return b[c - 1]; //return the value
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" >> Eratosthenes Prime Number Algorithm << " + "\n");
            Console.WriteLine("The list of Array Numbers : ");
            int[] a = new int[100];
            int aLength = a.Length;
            int counter = 0;
            for (int i = 0; i < aLength; i++)
            {  
                a[i] = i + 2; //start the array with initial value = 2,3,4...
                Console.Write(a[i] + " ");
                counter++;
                if(counter%20==0)
                {
                    Console.WriteLine("\n");
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("The list of Prime Numbers: ");
            for (int m = 1; findNotEqualToZero(a, m) * findNotEqualToZero(a, m) < aLength; m++)
            {        
                //Erathosthnes Logarithm, find all Prime number within the n range                                                                      
                for (int n = 0; n < aLength; n++)
                {                    
                    //Eliminate prime number's multiples
                    if (findNotEqualToZero(a, m) != 0)
                    {                         
                        //divisor should not be 0
                        if (a[n] % (findNotEqualToZero(a, m)) == 0 && a[n] != (findNotEqualToZero(a, m)))
                        {          
                            //assign 0 to array list that can be divided exactly by m                                                                           
                            a[n] = 0;
                        }
                    }
                    else break;
                }
            }
            printNotEqualToZero(a);
        }


        public static void printNotEqualToZero(int[] b)
        {               
            //print numbers in array that doesnt equal to 0
            int bLength = b.Length;
            int counter = 0;
            for (int i = 0; i < bLength; i++)
            {
                if (b[i] != 0)
                {
                    Console.Write(b[i] + " ");
                    counter++;
                    if(counter % 10==0)
                    {
                        Console.WriteLine("\n");
                    }
                }
            }
        }
    }
}

