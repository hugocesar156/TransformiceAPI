namespace TransformiceAPI.Domain.Entities
{
    public class Level
    {
        public Level(int id, int number, int experience)
        {
            Id = id;
            Number = number;
            Experience = experience;
        }

        public int Id { get; set; }
        public int Number { get; set; }
        public int Experience { get; set; }
    }
}
