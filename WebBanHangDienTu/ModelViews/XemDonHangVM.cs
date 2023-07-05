using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangDienTu.Models;

namespace WebBanHangDienTu.ModelViews
{
    public class XemDonHangVM
    {
        public Order DonHang { get; set; }
        public List<OrderDetail> ChiTietDonHang { get; set; }
    }
}
