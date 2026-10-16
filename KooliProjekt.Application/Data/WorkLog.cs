using System;
using System.Collections.Generic;
using System.Text;

namespace KooliProjekt.Application.Data
{
    internal class WorkLog
    {
        public int id { get; set; }
        public DateTime Date { get; set; }
        public decimal HoursSpent { get; set; }
        public string Description { get; set; }
    }
}
