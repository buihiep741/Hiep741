using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("DaiLys")]
    public class DaiLy
   {
    [Key]
    public string MaDaiLy { get; set; }
    public string TenDaiLy { get; set; }
    public string DiaChi { get; set; }
    public string NguoiDaiDien { get; set; }
    public string DienThoai { get; set; }
    public string MaHTPP { get; set; }
    [ForeignKey("MaHTPP")]
    public HeThongPhanPhoi HeThongPhanPhoi { get; set; }  // Mối quan hệ với HeThongPhanPhoi
}
}