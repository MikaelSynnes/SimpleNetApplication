namespace SimpleNetApplication.Contracts
{
    public class SimpleModel
    {
        public SimpleModel()
        {
            SubModels = new List<SimpleSubModel>();
        }

        public int Id { get; set; }
        public List<SimpleSubModel> SubModels { get; set; }
    }
}
