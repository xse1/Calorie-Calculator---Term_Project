using System.ComponentModel.DataAnnotations;
namespace Calorie_Calculator.Models
{
    public class Steps_d
    {
        public int Steps { get; set; }
        [Key]
        public DateTime Hist { get; set; }
    }
}
