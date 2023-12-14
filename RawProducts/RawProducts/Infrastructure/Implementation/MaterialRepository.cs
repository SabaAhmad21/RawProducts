using RawProducts.Infrastructure.Interfaces;
using RawProducts.Models;
using RawProducts.ViewModels;

namespace RawProducts.Infrastructure.Implementation
{
    public class MaterialRepository : IMaterialRepository
    {
        private readonly RawProductContext _context;
        public MaterialRepository(RawProductContext context)
        {

            _context = context;

        }


        public bool CreateMaterial(MaterialVM guiMaterial)
        {
            //Material dbMaterial = new Material();
            //    dbMaterial.ProductName = guiMaterial.ProductName;
            //    dbMaterial.Quantity = guiMaterial.Quantity;
            //    dbMaterial.Unit= guiMaterial.Unit;
            //    dbMaterial.Date = guiMaterial.Date;

            //}
            Material dbMaterial = new Material
            {

                ProductName = guiMaterial.ProductName,
                Quantity = guiMaterial.Quantity,
                Unit = guiMaterial.Unit,
                Date = guiMaterial.Date
                
            };
            _context.Materials.Add(dbMaterial);
            _context.SaveChanges();
            return true;

            }  
    
       public bool MaterialDelete(int id)
        {
            var dbMaterial = _context.Materials.FirstOrDefault(x => x.Id == id);
            _context.Materials.Remove(dbMaterial);
            _context.SaveChanges();
            return true;
        }

        public MaterialUpdate
    } 

}


