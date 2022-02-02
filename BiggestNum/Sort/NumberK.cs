using System.Collections.Generic;
using System.Linq;

namespace BiggestNum.Sort
{
    public class Solution
    {
        public int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.GetLength(0)];
 
            List<int> listArray = new List<int>(array);

            for (int i = 0; i < commands.GetLength(0); i++)
            {
                int nStart = commands[i, 0];
                int nEnd = commands[i, 1];
                int nIndex = commands[i, 2];
                List<int> list = listArray.Where((x, idx) => idx >= nStart -1 && idx<nEnd).OrderBy(x=>x).ToList();
                answer[i] = list[nIndex - 1];
            }
            return answer;
        
        }
    }
}
