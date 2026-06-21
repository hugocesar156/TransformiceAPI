namespace TransformiceAPI.Domain.Entities
{
    public class Account
    {
        public Account(int id, string name, Gender gender, DateTime inscriptionDate, AccountLevel accountLevel,
            Title actualTitle, int normalModeSaves, int hardModeSaves, int divineModeSaves, int cheeseShaman,
            int firstCheese, int cheese, int bootcamp, List<Title> titles)
        {
            Id = id;
            Name = name;
            Gender = gender;
            InscriptionDate = inscriptionDate;
            AccountLevel = accountLevel;
            ActualTitle = actualTitle;
            NormalModeSaves = normalModeSaves;
            HardModeSaves = hardModeSaves;
            DivineModeSaves = divineModeSaves;
            CheeseShaman = cheeseShaman;
            FirstCheese = firstCheese;
            Cheese = cheese;
            Bootcamp = bootcamp;
            Titles = titles;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime InscriptionDate { get; set; }
        public AccountLevel AccountLevel { get; set; }
        public Title ActualTitle { get; set; }
        public int NormalModeSaves { get; set; }
        public int HardModeSaves { get; set; }
        public int DivineModeSaves { get; set; }
        public int CheeseShaman { get; set; }
        public int FirstCheese { get; set; }
        public int Cheese { get; set; }
        public int Bootcamp { get; set; }
        public List<Title> Titles { get; set; }
    }
}
