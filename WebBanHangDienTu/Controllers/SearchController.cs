using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangDienTu.Models;

namespace WebBanHangDienTu.Controllers
{
    public class SearchController : Controller
    {
        private readonly BanHangThietBiMangContext _context;

        public SearchController(BanHangThietBiMangContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
       [HttpPost]
        public IActionResult FindProduct(string keyword)
        {
            List<Product> ls = new List<Product>();
            if (string.IsNullOrEmpty(keyword) || keyword.Length < 1)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            ls = _context.Products.AsNoTracking()
                                 .Where(x => x.ProductName.Contains(keyword))
                                 .OrderByDescending(x => x.ProductName)
                                 .ToList();
            if (ls == null)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            else
          {
              return PartialView("ListProductsSearchPartial", ls);
           }
        }
    }
}
