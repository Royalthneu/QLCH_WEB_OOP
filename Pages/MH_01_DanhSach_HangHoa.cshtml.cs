using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLCH_WEB_OOP.XuLy;
using QLCH_WEB_OOP.Entity;


namespace QLCH_WEB_OOP.Pages
{
    public class MH_01_DanhSach_HangHoaModel : PageModel
    {
        public class MH_DanhSachHangHoaModel : PageModel
        {
            public List<HangHoa> DanhSachHangHoa { get; set; }
            private IXuLyHangHoa _xuLyHangHoa;
            [BindProperty]
            public string TuKhoa { get; set; }
            public string Chuoi = String.Empty;

            public MH_DanhSachHangHoaModel()
            {
                _xuLyHangHoa = ObjectCreator.TaoDoiTuongXuLyHangHoa();
            }
            public void OnGet()
            {
                try
                {
                    //DanhSachHangHoa = _xuLyHangHoa.DocDanhSach(TuKhoa);
                }
                catch (Exception ex)
                {
                    Chuoi = ex.Message;
                }
            }
            public void OnPost()
            {
                try
                {
                    //DanhSachHangHoa = _xuLyHangHoa.DocDanhSach(TuKhoa);
                }
                catch (Exception ex)
                {
                    Chuoi = ex.Message;
                }

            }
        }
    }

}

