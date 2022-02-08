using System;
using System.Text;

namespace BiggestNum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] test = {10,12,231};
            Solution solution = new Solution();
            solution.Function(test);



        }
    }

    public class Solution
    {
        public string solution(int[] numbers)
        {
            string answer = "";

            StringBuilder sb = new StringBuilder();
            Array.Sort(numbers, (x, y) =>
                    string.Compare(y.ToString() + x.ToString(), x.ToString() + y.ToString()));


            for (int i = 0; i < numbers.Length; i++)
            {
                sb.Append(numbers[i].ToString());
            }

            answer = sb.ToString();

            int count = 0;

            foreach (var item in answer)
            {
                if (item == '0')
                {
                    count++;
                }
            }

            if (count == answer.Length)
            {
                return "0";
            }
            else
            {
                return answer;
            }

            return answer;
        }
    }

}

