using SimpleNetApplication.Contracts;
using SimpleNetApplication.Storage;
namespace SimpleNetApplication.Managers
{
    public class SimpleManager : ISimpleManager
    {
        private IStorage _storage;

        public SimpleManager(IStorage storage)
        {
            _storage = storage;
        }
        public SimpleModel Add(SimpleModel model)
        {
            return _storage.AddSimpleDbmodel(model);
        }

        public List<SimpleModel> GetAll()
        {
           return _storage.GetSimpleModels();
        }
    }
}
