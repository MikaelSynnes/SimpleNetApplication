using SimpleNetApplication.Contracts;


namespace SimpleNetApplication.Storage
{
    public interface IStorage
    {
        List<SimpleModel> GetSimpleModels();
        SimpleModel AddSimpleDbmodel(SimpleModel model);
    }
}
