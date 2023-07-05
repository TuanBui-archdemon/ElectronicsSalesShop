using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using WebBanHangDienTu.Models;
using WebShop.Helpper;

namespace WebBanHangDienTu.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminTblTinTucsController : Controller
    {
        private readonly BanHangThietBiMangContext _context;
        public INotyfService _notyfService { get; }
        public AdminTblTinTucsController(BanHangThietBiMangContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        // GET: Admin/AdminTblTinTucs
        public IActionResult Index(int? page)
        {
        
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 10;
            var lsPosts = _context.TblTinTucs
                .AsNoTracking()
                .OrderBy(x => x.PostId);
            PagedList<TblTinTuc> models = new PagedList<TblTinTuc>(lsPosts, pageNumber, pageSize);

            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }

        // GET: Admin/AdminTblTinTucs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblTinTuc = await _context.TblTinTucs
                .Include(t => t.Account)
                .Include(t => t.Cat)
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (tblTinTuc == null)
            {
                return NotFound();
            }

            return View(tblTinTuc);
        }

        // GET: Admin/AdminTblTinTucs/Create
        public IActionResult Create()
        {
            ViewData["AccountId"] = new SelectList(_context.Accounts, "AccountId", "AccountId");
            ViewData["CatId"] = new SelectList(_context.Categories, "CatId", "CatId");
            return View();
        }

        // POST: Admin/AdminTblTinTucs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PostId,Title,Scontents,Contents,Thumb,Published,Alias,CreatedDate,Author,AccountId,Tags,CatId,IsHot,IsNewfeed,MetaKey,MetaDesc,Views")] TblTinTuc tblTinTuc, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (ModelState.IsValid)
            {
                //Xu ly Thumb
                if (fThumb != null)
                {
                    string extension = Path.GetExtension(fThumb.FileName);
                    string imageName = Utilities.SEOUrl(tblTinTuc.Title) + extension;
                    tblTinTuc.Thumb = await Utilities.UploadFile(fThumb, @"news", imageName.ToLower());
                }
                if (string.IsNullOrEmpty(tblTinTuc.Thumb)) tblTinTuc.Thumb = "default.jpg";
                tblTinTuc.Alias = Utilities.SEOUrl(tblTinTuc.Title);
                tblTinTuc.CreatedDate = DateTime.Now;


                _context.Add(tblTinTuc);
                await _context.SaveChangesAsync();
                _notyfService.Success("Thêm mới thành công");
                return RedirectToAction(nameof(Index));
            }
            return View(tblTinTuc);
        }

        // GET: Admin/AdminTblTinTucs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblTinTuc = await _context.TblTinTucs.FindAsync(id);
            if (tblTinTuc == null)
            {
                return NotFound();
            }
            ViewData["AccountId"] = new SelectList(_context.Accounts, "AccountId", "AccountId", tblTinTuc.AccountId);
            ViewData["CatId"] = new SelectList(_context.Categories, "CatId", "CatId", tblTinTuc.CatId);
            return View(tblTinTuc);
        }

        // POST: Admin/AdminTblTinTucs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PostId,Title,Scontents,Contents,Thumb,Published,Alias,CreatedDate,Author,AccountId,Tags,CatId,IsHot,IsNewfeed,MetaKey,MetaDesc,Views")] TblTinTuc tblTinTuc, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (id != tblTinTuc.PostId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //Xu ly Thumb
                    if (fThumb != null)
                    {
                        string extension = Path.GetExtension(fThumb.FileName);
                        string imageName = Utilities.SEOUrl(tblTinTuc.Title) + extension;
                        tblTinTuc.Thumb = await Utilities.UploadFile(fThumb, @"news", imageName.ToLower());
                    }
                    if (string.IsNullOrEmpty(tblTinTuc.Thumb)) tblTinTuc.Thumb = "default.jpg";
                    tblTinTuc.Alias = Utilities.SEOUrl(tblTinTuc.Title);

                    _context.Update(tblTinTuc);
                    await _context.SaveChangesAsync();
                    _notyfService.Success("Chỉnh sửa thành công");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblTinTucExists(tblTinTuc.PostId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tblTinTuc);
        }

        // GET: Admin/AdminTblTinTucs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblTinTuc = await _context.TblTinTucs
                .Include(t => t.Account)
                .Include(t => t.Cat)
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (tblTinTuc == null)
            {
                return NotFound();
            }

            return View(tblTinTuc);
        }

        // POST: Admin/AdminTblTinTucs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblTinTuc = await _context.TblTinTucs.FindAsync(id);
            _context.TblTinTucs.Remove(tblTinTuc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblTinTucExists(int id)
        {
            return _context.TblTinTucs.Any(e => e.PostId == id);
        }
    }
}
