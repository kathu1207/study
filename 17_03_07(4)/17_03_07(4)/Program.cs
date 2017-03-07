using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_03_07_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] score = new int[20]{
                80,74,81,90,34,84,76,95,45,66,74,82,76,57,51,88,73,98,51,60};

            /*
             //selection sort
            for(int i = 0; i <score.Length; i++)
            {
                int index = i;

                for(int j = i+1; j < score.Length; j++)
                {
                    if (score[j] < score[index])
                    {
                        index = j;
                    }
                    
                }
                int temp = score[index];
                score[index] = score[i];
                score[i] = temp;
                Console.Write(score[i]);
                Console.WriteLine(" ");
            }
            */

            // Bubble sort
            int mix = 0;

            for (int i = 0; i < 20; i++)
            {
                for (int j = i + 1; j < 20; j++)
                {
                    if (score[i] > score[j])
                    {
                        mix = score[i];
                        score[i] = score[j];
                        score[j] = mix;
                    }
                }
                Console.Write(score[i]);
                Console.Write(" ");
            }


        }
    }
}
