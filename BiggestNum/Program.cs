using System;
using System.Linq;
using System.Text;

namespace BiggestNum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 1,2,3,4,5};
            //Solution solution = new Solution();
            //solution.Function(test);
            Search.LV1Search lV1Search = new Search.LV1Search();
            lV1Search.solution(test);


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

