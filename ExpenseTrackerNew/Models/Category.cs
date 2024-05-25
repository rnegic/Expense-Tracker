using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace ExpenseTrackerNew.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column(TypeName ="nvarchar(80)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Icon { get; set; } = "";

        [Column(TypeName = "nvarchar(15)")]
        public string Type { get; set; } = "Expense";
    }
}
