using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Descuentar.Models;
using Microsoft.AspNetCore.Mvc;

namespace Descuentar.Controllers
{
    public class LikerController : Controller
    {
        private readonly Context _context;

        public LikerController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return RedirectToAction("updateLikes");
        }

        [HttpPost]
        public IActionResult UpdateLikes(Cupon cupon)
        {
            return Json(new { data = DarLike(cupon.ID) });
        }

        private int DarLike(int id)
        {
            Cupon cupon = _context.cupons.Find(id);
            cupon.likes++;
            _context.cupons.Update(cupon);
            _context.SaveChanges();
            return cupon.likes;
        }
    }
}
