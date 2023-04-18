using SimpleNetApplication.Contracts;
using SimpleNetApplication.Storage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNetApplication.Storage
{
    public static class DbMapper
    {
        public static SimpleDbModel CreateDbModel(SimpleModel model)
        {
            return new SimpleDbModel
            {
                Id = model.Id,
                SubModels = model.SubModels.Select(CreateDbModel).ToList()
            };
        }
        public static SimpleSubDbModel CreateDbModel(SimpleSubModel model)
        {
            return new SimpleSubDbModel
            {
                DbModelFk = model.SimpleModelId,
                Id = model.Id
            };
        }

        public static SimpleModel CreateModel(SimpleDbModel model)
        {
            return new SimpleModel
            {
                Id = model.Id,
                SubModels = model.SubModels.Select(CreateModel).ToList()
            };
        }

        public static SimpleSubModel CreateModel(SimpleSubDbModel model)
        {
            return new SimpleSubModel
            {
                SimpleModelId = model.DbModelFk,
                Id = model.Id
            };
        }
    }
}
