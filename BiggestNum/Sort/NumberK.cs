using System.Collections.Generic;

namespace BiggestNum.Sort
{
    public class Solution
    {
        public int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.GetLength(0)];
            //array에 값이 들어오고

            //commands
            //[2,6,3] 2번째부터 6번째까지 뽑아내고 , 정렬해서 3번째
            //

            List<int> list = new List<int>();

            for (int i = 0; i < commands.GetLength(0); i++)
            {
                if (list.Count > 0)
                    list.Clear();

                for (int j = commands[i,0]; j <= commands[i, 1]; j++)
                {
                    list.Add(array[j-1]);
                }

                list.Sort();
                answer[i] = list[ commands[i, 2] -1 ];

            }



            return answer;
        }
    }
}
