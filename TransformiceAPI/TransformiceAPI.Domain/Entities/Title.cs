namespace TransformiceAPI.Domain.Entities
{
    public class Title
    {
        public Title(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }
    }
}
