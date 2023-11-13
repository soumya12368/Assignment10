using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            int[][] studentScores = new int[][]  // Create a jagged array called studentScores
            {
            new int[] {85, 92, 78},
            new int[] {90, 87, 93, 89},
            new int[] {76, 88}
            };           
            Console.WriteLine("Scores of each student:");  // Print the scores of each student using loops
            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.Write($"Student {i + 1}: ");
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.Write(studentScores[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nAverage score of each student:"); // Calculate and print the average score of each student
            for (int i = 0; i < studentScores.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    sum += studentScores[i][j];
                }
                double average = (double)sum / studentScores[i].Length;
                Console.WriteLine($"Student {i + 1}: {average:F2}");
            }           
            Console.WriteLine("\nAverage score for all students combined:");  // Calculate and print the average score for all students combined
            int totalsum = 0;
            int totalCount = 0;
            for (int i = 0; i < studentScores.Length; i++) 
            {
                for (int j = 0; j < studentScores[i].Length; j++) 
                {
                    totalsum += studentScores[i][j];
                    totalCount++;
                }
            }
            double overallAverage = (double)totalsum / totalCount;
            Console.WriteLine($"Overall Average: {overallAverage:F2}");
        }
    }   
}
