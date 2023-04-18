using SimpleNetApplication.Contracts;

namespace SimpleNetApplication.Storage
{
    public class Storage : IStorage
    {
        private IStorageFactory _factory;

        public Storage(IStorageFactory factory)
        {
            _factory = factory;
        }

        public SimpleModel AddSimpleDbmodel(SimpleModel model)
        {
            using (var context = _factory.Create())
            {
                var entity = context.Add(DbMapper.CreateDbModel(model));
                context.SaveChanges();
                return DbMapper.CreateModel(entity.Entity);
            }
        }

        public List<SimpleModel> GetSimpleModels()
        {
            using (var context = _factory.Create())
            {
                return context.SimpleModels.Select(DbMapper.CreateModel).ToList();
            }
        }
    }
}