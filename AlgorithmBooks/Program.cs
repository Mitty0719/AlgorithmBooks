using System;

namespace AlgorithmBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 2753

            int year = Int32.Parse(Console.ReadLine());
            string res = "0";

            if((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                res = "1";
            }

            Console.WriteLine(res);
            #endregion

            #region 9498
            //int score = Int32.Parse(Console.ReadLine());
            //string res = "F";

            //if(score >= 90)
            //{
            //    res = "A";
            //}
            //else if(score >= 80)
            //{
            //    res = "B";
            //}
            //else if(score >= 70)
            //{
            //    res = "C";
            //}
            //else if(score >= 60)
            //{
            //    res = "D";
            //}

            //Console.WriteLine(res);
            #endregion

            #region 1330
            //string[] input = Console.ReadLine().Split();

            //int leftNum = Int32.Parse(input[0]);
            //int rightNum = Int32.Parse(input[1]);
            //string res = "";


            //if(leftNum > rightNum)
            //{
            //    res = ">";
            //}
            //else if(leftNum < rightNum)
            //{
            //    res = "<";
            //}
            //else
            //{
            //    res = "==";
            //}

            //Console.WriteLine(res);
            #endregion

            #region 2588

            //long anum = Int32.Parse(Console.ReadLine());
            //long bnum = Int32.Parse(Console.ReadLine());
            //long num = 1;
            //long temp = bnum;
            //while(bnum > 0)
            //{
            //    num = bnum % 10;
            //    bnum = bnum / 10;

            //    Console.WriteLine(anum * num);
            //}

            //Console.WriteLine(anum * temp);

            #endregion

            #region 10430
            //string[] strs = Console.ReadLine().Split(' ');
            //int A = Int32.Parse(strs[0]);
            //int B = Int32.Parse(strs[1]);
            //int C = Int32.Parse(strs[2]);

            //Console.WriteLine((A + B) % C);
            //Console.WriteLine(((A % C) + (B % C)) % C);
            //Console.WriteLine((A * B) % C);
            //Console.WriteLine(((A % C) * (B % C)) % C);
            #endregion

            #region 10869
            //string[] strs = Console.ReadLine().Split();
            //Console.WriteLine(Int32.Parse(strs[0]) + Int32.Parse(strs[1]));
            //Console.WriteLine(Int32.Parse(strs[0]) - Int32.Parse(strs[1]));
            //Console.WriteLine(Int32.Parse(strs[0]) * Int32.Parse(strs[1]));
            //Console.WriteLine(Int32.Parse(strs[0]) / Int32.Parse(strs[1]));
            //Console.WriteLine(Int32.Parse(strs[0]) % Int32.Parse(strs[1]));
            #endregion

            #region 1000, 1001, 1008, 10998
            //string[] strs = Console.ReadLine().Split();
            //Console.WriteLine(Int32.Parse(strs[0]) + Int32.Parse(strs[1]));
            #endregion

            #region 10172
            //Console.WriteLine("|\\_/|" + "\n" +
            //                  "|q p|   /}" + "\n" +
            //                  "( 0 )\"\"\"\\" + "\n" +
            //                  "|\"^\"`    |" + "\n" +
            //                  "||_/=\\\\__|");
            #endregion
        }
    }
}
