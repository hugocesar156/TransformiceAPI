namespace TransformiceAPI.Application.Models.Responses
{
    public class TitleResponse
    {
        public TitleResponse(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
