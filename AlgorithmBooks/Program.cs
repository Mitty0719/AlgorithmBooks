﻿using System;

namespace AlgorithmBooks
{
    class Program
    {

        static void Main(string[] args)
        {

        }

        #region 15552
        //static System.Text.StringBuilder sb = new System.Text.StringBuilder();

        //static void Main(string[] args)
        //{
        //    int cnt = Int32.Parse(Console.ReadLine());
        //    for(int i = 0; i < cnt; i++)
        //    {
        //        string inputNums = Console.ReadLine();
        //        string res = (Int32.Parse(inputNums.Split()[0]) + Int32.Parse(inputNums.Split()[1])).ToString();
        //        sb.Append(res + "\n");
        //    }

        //    Console.WriteLine(sb);
        //}
        #endregion 15552

        #region 8393
        //public static int addNum(int num)
        //{
        //    if(num == 1)
        //    {
        //        return 1;
        //    }
        //    return num + addNum(num-1);
        //}

        //static void Main(string[] args)
        //{

        //int inNum = Int32.Parse(Console.ReadLine());
        //Console.WriteLine(addNum(inNum));
        //}
        #endregion

        #region 10950
        //int cnt = Int32.Parse(Console.ReadLine());

        //for(int i = 0; i < cnt; i++)
        //{
        //    string str = Console.ReadLine();
        //    int oNum = Int32.Parse(str.Split(" ")[0]);
        //    int tNum = Int32.Parse(str.Split(" ")[1]);
        //    Console.WriteLine(oNum + tNum);
        //}
        #endregion

        #region 2739
        //int multiNum = Int32.Parse(Console.ReadLine());

        //for(int i = 1; i < 10; i++)
        //{
        //    Console.WriteLine(multiNum.ToString() + " * " + i + " = " + (multiNum * i).ToString());
        //}
        #endregion

        #region 2884
        //string input = Console.ReadLine();
        //int hour = Int32.Parse(input.Split(" ")[0]);
        //int min = Int32.Parse(input.Split(" ")[1]);

        //string res = "";

        //if(min >= 45)
        //{
        //    min -= 45;
        //}
        //else
        //{
        //    min = (60 + min) - 45;
        //    hour -= 1;
        //    if(hour < 0)
        //    {
        //        hour = 23;
        //    }
        //}

        //res = hour.ToString() + " " + min.ToString();
        //Console.WriteLine(res);
        #endregion

        #region 14681
        //int x = Int32.Parse(Console.ReadLine());
        //int y = Int32.Parse(Console.ReadLine());
        //int res = 0;

        //if(x > 0)
        //{
        //    res = 4;

        //    if(y > 0)
        //    {
        //        res = 1;
        //    }
        //}
        //else
        //{
        //    res = 3;

        //    if(y > 0)
        //    {
        //        res = 2;
        //    }
        //}

        //Console.WriteLine(res);
        #endregion


        #region 2753

        //int year = Int32.Parse(Console.ReadLine());
        //string res = "0";

        //if((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        //{
        //    res = "1";
        //}

        //Console.WriteLine(res);
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
