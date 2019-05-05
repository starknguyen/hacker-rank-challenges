using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRC.Code30Days
{
    public class NestedLogic
    {
        public int CalculateFine(DateTime dueDate, DateTime recvDate)
        {
            if (recvDate.Year < dueDate.Year)
                return 0;
            else if (recvDate.Year == dueDate.Year &&
                recvDate.Month <= dueDate.Month &&
                recvDate.Day <= dueDate.Day)
                return 0;

            else if (recvDate.Year == dueDate.Year &&
                recvDate.Month == dueDate.Month)
                return (15 * (recvDate.Day - dueDate.Day));

            else if (recvDate.Year == dueDate.Year)
                return (500 * (recvDate.Month - dueDate.Month));

            else
                return 10000;
        }
    }
}
