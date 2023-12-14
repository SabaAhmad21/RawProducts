using RawProducts.ViewModels;

namespace RawProducts.Infrastructure.Interfaces
{
    public interface IMaterialRepository
    {
        bool CreateMaterial(MaterialVM guiMaterial);
    }
}
