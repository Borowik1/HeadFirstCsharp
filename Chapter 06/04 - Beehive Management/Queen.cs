using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Beehive_Management
{
    class Queen
    {
        private Worker[] workers;
        private int shiftNumber = 0;
        public Queen(Worker[] inputArray)
        {
            workers = inputArray;
        }

        public bool AssignWork(string work, int shifts)
        {
            foreach (Worker item in workers)
            {
                if (item.DoThisWork(work, shifts))
                {
                    return true;
                }
            }
            return false;
        }

        public string WorkTheNextShift()
        {
            shiftNumber++;
            string report = "Отчёт за смену №" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DidYouFinish())
                    report += "Рабочий №" + (i + 1) + "закончил работу" + "\r\n";

                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Рабочий №" + (i + 1) + " не работает\r\n";
                else
                    if (workers[i].ShiftsLeft > 0)
                    report += "Рабочий №" + (i + 1) + " выполняет ‘" + workers[i].CurrentJob
                    + "’ еще " + workers[i].ShiftsLeft + " смен\r\n";
                else
                    report += "Рабочий №" + (i + 1) + " закончит ‘"
                    + workers[i].CurrentJob + "’ после этой смены\r\n";
            }
            return report;

        }

    }
}

