using System.Collections.Generic;
using System.Linq;

namespace BiggestNum.StackAndQueue
{
    public class FunctionUpdate
    {
        //기능 개성 수행중

        //각 기능은 진도가 100%일때 서비스에 반영

        //각 기능의 개발속도는 모두 다르기때문에 뒤에 있는 기능보다 먼저 개발할수있음
        //이때 뒤에 있는 기능은 앞에 있는 기능이 배포될때 배포되어야함

        //먼저 배포되어야하는 순서대로 작업의 진도가 적힌 와 
        //각 작업의 개발속도가 적힌 speeds가 주어질때

        //각 배포마다 몇개의 기능이 배포되는지를 return


        //배포는 하루에 한번만

        //93 30 55                  1,30,5          2,1

        //95 90 99 99 80 99         1,1,1,1,1       1,3,2
        public int[] solution(int[] progresses, int[] speeds)
        {
            List<int> answer = new List<int>();

            Queue<int> Que_progresses = new Queue<int>(progresses);
            Queue<int> Que_speeds = new Queue<int>(speeds);

            int total_job =0;

            while (Que_progresses.Count>0)
            {
                for (int i = 0; i < Que_progresses.Count; i++)
                {
                    //현재 작업
                    int tmp_progress = Que_progresses.Dequeue();

                    //작업진도 계산
                    tmp_progress += Que_speeds.ElementAt(i);

                    Que_progresses.Enqueue(tmp_progress);
                }
                if (Que_progresses.Count>0)
                {
                    //작업이 완료가되면
                    while (Que_progresses.Peek() >= 100)
                    {
                        Que_progresses.Dequeue();
                        total_job++;
                        //모든 개발이 끝나면 종료
                        if (Que_progresses.Count == 0)
                            break;
                    }

                    if (total_job >0)
                    {
                        answer.Add(total_job);
                        total_job = 0;
                    }
                }
            }
            
            return answer.ToArray();

        }
    }
}
