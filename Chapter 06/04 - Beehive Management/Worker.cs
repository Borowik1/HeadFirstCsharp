using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Beehive_Management
{
    class Worker
    {
        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;
        private string currentJob = "";

        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }
        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        public Worker(string[] jobsICanDo)
        {
            this.jobsICanDo = jobsICanDo;
        }

        public bool DoThisWork(string job, int shiftQnty)
        {
            if (String.IsNullOrEmpty(currentJob))
            {
                foreach (string item in jobsICanDo)
                {
                    if (item == job)
                    {
                        currentJob = job;
                        shiftsToWork = shiftQnty;
                        shiftsWorked = 0;
                        return true;
                    }
                }
            }

            return false;
        }

        public bool DidYouFinish()
        {
            if (String.IsNullOrEmpty(currentJob)) return false;

            shiftsWorked++;

            if (shiftsToWork < shiftsWorked)
            {
                currentJob = "";
                shiftsWorked = 0;
                shiftsToWork = 0;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
