using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SendingTool.Models
{
    public class SinhvienTT
    {
        [Key]
        [Required]
        public int id {get;set;}
        [Required]
        public string Tinh {get;set;}
        [Required]
        public string Hoten {get;set;}
        [Required]
        public int Ngaysinh {get;set;}
        [Required]
        public int Thangsinh {get;set;}
        [Required]
        public int Namsinh {get;set;}
        [Required]
        public string Idnumber {get;set;}
        [Required]
        public string Truong {get;set;}
        [Required]
        public string Lop {get;set;}
        [Required]
        public string Sodienthoai { get;set;}
        [Required]
        public int Status { get;set;}
    }
}