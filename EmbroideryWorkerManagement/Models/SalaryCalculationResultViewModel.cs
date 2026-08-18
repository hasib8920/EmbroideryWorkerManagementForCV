using EmbroideryWorkerManagement.Models;
using Microsoft.EntityFrameworkCore;
namespace EmbroideryWorkerManagement.Models
{
    public class SalaryCalculationResultViewModel
    {
        public int Id { get; set; }
        public string WorkerName { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public decimal BaseSalary { get; set; }

        public decimal FullAttendanceBonus { get; set; }

        public decimal DailyTargetBonus { get; set; }

        public decimal ExtraUnitBonus { get; set; }

        public decimal TotalMealAllowance { get; set; }

        public decimal AdvanceDeduction { get; set; }

        public decimal NetSalary { get; set; }
    }
}
