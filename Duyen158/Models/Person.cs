using System.ComponentModel.DataAnnotations;

namespace Duyen158.Models
{
    public class Person
    {
        [Key]
        public string CanCuocCongDan { get; set; }
        public string HoTen { get; set; }
        public string QueQuan { get; set; }

    }
}