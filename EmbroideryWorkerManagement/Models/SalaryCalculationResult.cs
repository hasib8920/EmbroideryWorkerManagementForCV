using EmbroideryWorkerManagement.Models;
using Microsoft.EntityFrameworkCore;
namespace EmbroideryWorkerManagement.Models
{
    public class SalaryCalculationResult
    {
        public int Id { get; set; }
        public string WorkerName { get; set; }

        public decimal BaseSalary { get; set; }
        public int TotalPresentDays { get; set; }

        public decimal MealAllowance { get; set; }

        public decimal FullAttendanceBonus { get; set; }
        public int TargetMetDays { get; set; }

        public decimal DailyTargetBonus { get; set; }
        public int ExtraUnits { get; set; }

        public decimal ExtraUnitBonus { get; set; }

        public decimal TotalAdvanceDeduction { get; set; }

        public decimal FinalSalary { get; set; }
    }
}
