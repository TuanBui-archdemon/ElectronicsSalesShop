using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangDienTu.Extension;
using WebBanHangDienTu.ModelViews;

namespace WebBanHangDienTu.Controllers.Components
{
    public class NumberCartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            int soluongsp = 0;
            if(cart != null)
            {
                soluongsp = cart.Count();
            }

            return View(cart);
        }
    }
}
