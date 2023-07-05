using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangDienTu.Models;

namespace WebBanHangDienTu.Controllers
{
    public class BlogController : Controller
    {

        private readonly BanHangThietBiMangContext _context;
        public BlogController(BanHangThietBiMangContext context)
        {
            _context = context;
        }
        [Route("blogs.html", Name = ("Blog"))]
        public IActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 10;
            var lsTinTucs = _context.TblTinTucs
                .AsNoTracking()
                .OrderBy(x => x.PostId);
            PagedList<TblTinTuc> models = new PagedList<TblTinTuc>(lsTinTucs, pageNumber, pageSize);

            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }
        [Route("/tin-tuc/{Alias}-{id}.html", Name = "TinChiTiet")]
        public IActionResult Details(int id)
        {
            var tindang = _context.TblTinTucs.AsNoTracking().SingleOrDefault(x => x.PostId == id);
            if (tindang == null)
            {
                return RedirectToAction("Index");
            }
            var lsBaivietlienquan = _context.TblTinTucs
                .AsNoTracking()
                .Where(x => x.Published == true && x.PostId != id)
                .Take(3)
                .OrderByDescending(x => x.CreatedDate).ToList();
            ViewBag.Baivietlienquan = lsBaivietlienquan;
            return View(tindang);
        }
    }
}
