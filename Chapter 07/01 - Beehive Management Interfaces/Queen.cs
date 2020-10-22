using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Beehive_Management_Interfaces
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int shiftNumber = 0;
        public Queen(Worker[] inputArray, double weightMg) : base(weightMg)
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
            double honeyConsumed = HoneyConsumptionRate();
            shiftNumber++;
            string report = "Отчёт за смену №" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                honeyConsumed += workers[i].HoneyConsumptionRate();
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
            report += "Всего потреблено мёда за смену: " + honeyConsumed + "\r\n";
            return report;

        }

    }
}

