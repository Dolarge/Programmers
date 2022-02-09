using System.Collections.Generic;
using System.Linq;

namespace BiggestNum
{
    public class spy
    {
        public int solution(string[,] clothes)
        {
            int answer = 1;
            Dictionary<string, int> clothoes_dic = new Dictionary<string, int>();

            for (int i = 0; i < clothes.GetLength(0); i++)
            {
                if (clothoes_dic.ContainsKey(clothes[i, 1]))
                {
                    clothoes_dic[clothes[i, 1]]++;
                }
                else
                {
                    clothoes_dic.Add(clothes[i, 1], 1);
                }

            }

            foreach (KeyValuePair<string, int> cloth in clothoes_dic)
            {
                answer *= (cloth.Value + 1);
            }


            return answer - 1;

        }
    }
}
