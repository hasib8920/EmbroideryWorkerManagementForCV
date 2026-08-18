using System.ComponentModel.DataAnnotations;
using EmbroideryWorkerManagement.Models;
using Microsoft.EntityFrameworkCore;
namespace EmbroideryWorkerManagement.Models
{
    public class MonthlyPaymentViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Worker")]
        public int WorkerId { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int Month { get; set; }

        public decimal BaseSalary { get; set; }

        public decimal OvertimeAmount { get; set; }
        public decimal TargetBonus { get; set; }

        public decimal ExtraBonus { get; set; }

        public decimal MealAllowance { get; set; }
        public decimal AdvanceDeduction { get; set; }

        public decimal TotalSalary { get; set; }

        public decimal NetSalary { get; set; }

        public string? WorkerName { get; set; }
    }
}
