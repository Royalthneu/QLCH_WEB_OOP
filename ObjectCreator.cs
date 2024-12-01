using QLCH_WEB_OOP.XuLy;
using QLCH_WEB_OOP.LuuTru;

namespace QLCH_WEB_OOP
{
    public class ObjectCreator
    {
        public static IXuLyHangHoa TaoDoiTuongXuLyHangHoa()
        {
            ILuuTruHangHoa luuTru = new LuuTruHangHoa();
            return new XuLyHangHoa(luuTru);
        }
    }
}
