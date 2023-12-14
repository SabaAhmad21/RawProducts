using Microsoft.AspNetCore.Mvc;
using RawProducts.Infrastructure.Interfaces;
using RawProducts.ViewModels;

namespace RawProducts.Controllers
{
    public class MaterialController : Controller
    {
        private IMaterialRepository _materialRepository;
        public MaterialController(IMaterialRepository materialRepository) 
        
        { 
            _materialRepository = materialRepository;
        
        }
        [HttpGet]
        public IActionResult CreateMaterial()
        {
            return View();
        }

        [HttpPost]

        public IActionResult CreateMaterial(MaterialVM guiMaterial)
        {
            if(ModelState.IsValid)
            {
                if(_materialRepository.CreateMaterial(guiMaterial))
                {
                    ModelState.AddModelError("", "Material created successfully");
                }
                else
                {
                    ModelState.AddModelError("", "Something went wrong");
                }
                return View();
            }
            return View();
        }

       
    }
}
