using System;
using System.Linq;
using System.Text;

namespace BiggestNum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] testc = { 1, 5, 2, 6, 3, 7, 4 };
            int[,] command = new int[3, 3] { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 }};
            
            //Solution solution = new Solution();
            //solution.Function(test);
           Sort.Solution solution = new Sort.Solution();
            
            solution.solution(testc, command);

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
    //더 좋은 
        public string solution1(int[] numbers)
        {
            Array.Sort(numbers, (x, y) =>
            {
                string XY = x.ToString() + y.ToString();
                string YX = y.ToString() + x.ToString();
                return YX.CompareTo(XY);
            });
            if (numbers.Where(x => x == 0).Count() == numbers.Length) return "0";
            else return string.Join("", numbers);
        }
    }


}

