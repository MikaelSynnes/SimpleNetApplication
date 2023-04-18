using SimpleNetApplication.Contracts;

namespace SimpleNetApplication.Managers
{
    public interface ISimpleManager
    {
        public SimpleModel Add(SimpleModel model);
        public List<SimpleModel> GetAll();
    }
}
