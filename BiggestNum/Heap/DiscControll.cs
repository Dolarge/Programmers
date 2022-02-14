using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestNum.Heap
{
    public class Job
    {
        public int StartTime;
        public int TaskTime;

        public Job(int requestTime, int TaskTime)
        {
            this.StartTime = requestTime;
            this.TaskTime = TaskTime;
        }

        public Job()
        {

        }

    }
    public class DiscControll
    {
        // [[0, 3], [1, 9], [2, 6]]
        public int solution(int[,] jobs)
        {
            List<Job> todo = new List<Job>();
            for (int i = 0; i < jobs.Length; i++)
            {
                todo.Add(new Job
                {
                    StartTime = jobs[i, 0],
                    TaskTime = jobs[i, 1]
                });
            }

            //StartTime이 짧은 순서대로 정렬
            todo.Sort((a, b) =>
            {
                int requsetTime = a.StartTime - b.StartTime;
                if (requsetTime ==0)
                {
                    return a.TaskTime - b.TaskTime;
                }
                return requsetTime;
            });

            int cnt = 0;
            int EndTaskTime = 0;

            double Total = 0;
            while (todo.Count>0)
            {

                Job waitingJob = null;
                //task시간이 가장 짧은 작업 찾기
                for (int i = 0; i < todo.Count; i++)
                {
                    //이전에 작업이 끝난시간보다 요청시간이 늦지않은 작업중 찾아야함
                    if (todo[i].StartTime > EndTaskTime)
                        break;

                    if (waitingJob == null)
                    {
                        waitingJob = todo[i];
                    }
                    else
                    {
                        int priotyTime = waitingJob.TaskTime - todo[i].StartTime;
                        if (priotyTime == 0)
                            priotyTime = waitingJob.StartTime - todo[i].StartTime;
                        waitingJob =priotyTime <= 0 ? waitingJob : todo[i];
                    }
                }
                if (waitingJob != null)
                    waitingJob = todo[0];

                //
                int delay = EndTaskTime- waitingJob.StartTime;
                int ms = Math.Max(delay, 0) + waitingJob.TaskTime;

                EndTaskTime += delay <0 ? Math.Abs(delay) + waitingJob.TaskTime : waitingJob.TaskTime;
                Total+= ms;
                todo.Remove(waitingJob);

            }

            
            
            return (int)(Total/jobs.GetLength(0));
        }
    }
}
