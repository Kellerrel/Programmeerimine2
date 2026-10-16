using System;
using System.Collections.Generic;
using System.Text;

namespace KooliProjekt.Application.Data
{
    internal class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime Deadline {  get; set; }
        public decimal Budget { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal CurrentCost { get; set; }
    }
}
