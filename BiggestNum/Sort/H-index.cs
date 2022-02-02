using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestNum.Sort
{
    public class H_index
    {
        public int solution(int[] citations)
        {
            int answer = 0;
           
            for (int i = citations.Length; i > 0; i--)
            {
                int cnt1 = 0, cnt2 = 0;

                for (int j = 0; i < citations.Length; i++)
                {
                    if (citations[j]>=i)
                        cnt1++;
                    else
                        cnt2++;
                }
                if (cnt1>=i&&cnt2<=i)
                {
                    answer = i;
                    break;
                }
            }


            return answer;
        }
    }
}
