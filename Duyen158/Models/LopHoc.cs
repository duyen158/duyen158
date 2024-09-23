using System.ComponentModel.DataAnnotations;

namespace  demoMVC.Model


{
    public class LopHoc
    {
        [Key]
        public int MaLopHoc { get; set; }
        public string? TenLop { get; set; }
    }
}