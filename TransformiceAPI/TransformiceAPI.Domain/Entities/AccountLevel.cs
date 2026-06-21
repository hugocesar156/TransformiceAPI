namespace TransformiceAPI.Domain.Entities
{
    public class AccountLevel
    {
        public AccountLevel(int id, int experience, Level level)
        {
            Id = id;
            Experience = experience;
            Level = level;
        }

        public int Id { get; set; }
        public int Experience { get; set; }
        public Level Level { get; set; }
    }
}
