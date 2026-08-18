using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmbroideryWorkerManagement.Models
{
    public class Attendance
    {
        public int Id { get; set; }

        [Required]
        public int WorkerId { get; set; }

        public Worker Worker { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public bool IsPresent { get; set; } = false;

        public bool IsHoliday { get; set; } = false;

        [Range(0, double.MaxValue)]
        public decimal OvertimeHours { get; set; } = 0;

        [Range(0, double.MaxValue)]
        public decimal MealAllowance { get; set; } = 0;

        [Range(0, int.MaxValue)]
        public int UnitsProduced { get; set; } = 0;
    }
}
