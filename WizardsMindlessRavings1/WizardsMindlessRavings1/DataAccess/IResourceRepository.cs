using WizardsMindlessRavings1.Models.Entities;
using WizardsMindlessRavings1.Models.ViewModels.Resource;

namespace WizardsMindlessRavings1.DataAccess
{
    public interface IResourceRepository
    {
        Resource Create(ResourceViewModel model);
        bool Delete(int id);
        IReadOnlyCollection<Resource> GetAll();
        Resource? GetById(int id);
        bool Update(int id, ResourceViewModel model);
    }
}
