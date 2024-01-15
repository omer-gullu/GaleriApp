using GaleriApp.Context;
using GaleriApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace GaleriApp.Controllers
{
    public class AracTuruController : Controller
    {
        private readonly IAracTuruRepository _aracTuruRepository;
        public AracTuruController(IAracTuruRepository dataContext)
        {
            _aracTuruRepository = dataContext;
        }
        public IActionResult Index()
        {
            List<AracTuru> aracTuruObj = _aracTuruRepository.GetAll().ToList();
            return View(aracTuruObj);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AracTuru aracTuru)
        {
            if (aracTuru == null)
            {
                return BadRequest();
            }
            if (ModelState.IsValid)
            {
                _aracTuruRepository.Ekle(aracTuru);
                _aracTuruRepository.Kaydet();
                TempData["Bilgi"] = "Araç Türü Başarılı Bir Şekilde Eklendi";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            AracTuru? aracTuruObj = _aracTuruRepository.Get(t=>t.Id == id);
            if (aracTuruObj == null)
            {
                return NotFound();
            }
            return View(aracTuruObj);
        }
        [HttpPost]
        public IActionResult Update(AracTuru aracTuru)
        {
            if (ModelState.IsValid)
            {
                _aracTuruRepository.Guncelle(aracTuru);
                _aracTuruRepository.Kaydet();
                   TempData["Bilgi"] = "Araç Türü Başarılı Bir Şekilde Güncellendi";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            AracTuru? aracTuruObj = _aracTuruRepository.Get(t => t.Id == id);
            if (aracTuruObj == null)
            {
                return BadRequest();
            }
            return View(aracTuruObj);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            AracTuru? aracTuruObj = _aracTuruRepository.Get(t => t.Id == id);
            if (aracTuruObj == null)
            {
                return NotFound();
            }
            _aracTuruRepository.Sil(aracTuruObj);
            _aracTuruRepository.Kaydet();
             TempData["Bilgi"] = "Araç Türü Başarılı Bir Şekilde Silindi";
            return RedirectToAction(nameof(Index));


        }
    }
}
