using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestNum.Search
{
    public class LV1Search
    {

        //문제는 최대 10,000
        //문제의 정답은 1`5
        //가장 높은 점수를 받은 사람이 여럿인 경우, 오름차순정렬

        public int[] solution(int[] answers)
        {

            List<int> answer = new List<int>();

            int[][] Students = new int[3][];
            int[] score = new int[3] { 0, 0, 0 };


            Students[0] = new int[] { 1, 2, 3, 4, 5 };
            Students[1] = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
            Students[2] = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };


            for (int i = 0; i < answers.Length; i++)
            {
                for (int j = 0; j < score.Length; j++)
                {
                    if (Students[j][i % Students[j].Length] == answers[i])
                        score[j]++;

                }
            }

            for (int i = 0; i < score.Length; i++)
            {
                if (score[i] == score.Max())
                {
                    answer.Add(i+1);

                }
            }
            answer.Sort();

            return answer.ToArray();
        }
    }
}
