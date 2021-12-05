using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Codewars
{
    using System.Collections.Generic;

    class prgram
    {



        static void Main(string[] args)
        {

            int[][] arr = new int[][]
            {
                new int[] {1, 4, 2, 3},
                new int[] {3, 2, 4, 1},

                new int[] {4, 1, 3, 2},
                new int[] {2, 3, 1, 4}
            };
            Kata kata = new Kata(arr);
            Console.Write(kata.Return);

        }
    }

    public class Kata
    {
        public bool Return { get; set; }
    public Kata(int[][] sudokodata)
    {

     var retur= IsValid(sudokodata);
     Return = retur;
    }

    public bool IsValid(int[][] sudokodata)
    {
        int number_valid = 0;
        for (int i = 1; i < (sudokodata.Length + 1); i++)
        {
            number_valid += i;
        }

        //List<int> cheack_digit = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int role_row = 0;
        int role_column = 0;
        int sum = 0;
        int sqrt_number = Convert.ToInt32(Math.Sqrt(sudokodata[0].Length));
        for (int m_total = 0; m_total < sudokodata.Length; m_total++)
        {


            for (int m = 0; m < Math.Sqrt(sudokodata[0].Length); m++)
            {

                for (int i = 0; i < Math.Sqrt(sudokodata[0].Length); i++)
                {

                    for (int j = 0; j < Math.Sqrt(sudokodata[0].Length); j++)
                    {
                        //if (cheack_digit.Contains(sudokodata[i + sqrt_number][j + role_row])==false) return false;
                        sum += sudokodata[i + sqrt_number][j + role_row];
                    }
                }

                if (sum != number_valid) return false;
                role_row += sqrt_number;
                sum = 0;
            }

            role_column += sqrt_number;
            role_row = 0;
        }

        sum = 0;
        for (int i = 0; i < sudokodata.Length; i++)
        {
            for (int j = 0; j < sudokodata[0].Length; j++)
            {
                sum += sudokodata[i][j];
            }

            if (sum != number_valid) return false;
            sum = 0;
        }

        sum = 0;
        for (int i = 0; i < sudokodata.Length; i++)
        {
            for (int j = 0; j < sudokodata.Length; j++)
            {
                sum += sudokodata[j][i];
            }

            if (sum != number_valid) return false;
            sum = 0;
        }

        return true;
    }
    }
}



