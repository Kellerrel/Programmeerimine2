using System;
using System.Collections.Generic;
using System.Text;

namespace KooliProjekt.Application.Data
{
    internal class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public decimal EstimatedHours { get; set; }
        public decimal ActualHours { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public decimal FixedPrice { get; set; }
    }
}
