using TransformiceAPI.Domain.Entities;

namespace TransformiceAPI.Application.Models.Responses
{
    public class AccountResponse
    {
        public AccountResponse(int id, string name, string gender, DateTime inscriptionDate, int level,
            int experience, int experienceNeeded, string actualTitle, int normalModeSaves, int hardModeSaves,
            int divineModeSaves, int cheeseShaman, int fisrtCheese, int cheese, int bootcamp, List<Title> titles)
        {
            Id = id;
            Name = name;
            Gender = gender;
            InscriptionDate = inscriptionDate;
            Level = level;
            Experience = experience;
            ExperienceNeeded = experienceNeeded;
            ActualTitle = actualTitle;
            NormalModeSaves = normalModeSaves;
            HardModeSaves = hardModeSaves;
            DivineModeSaves = divineModeSaves;
            CheeseShaman = cheeseShaman;
            FirstCheese = fisrtCheese;
            Cheese = cheese;
            Bootcamp = bootcamp;
            Titles = titles;
        }

        public int Id { get; }
        public string Name { get; }
        public string Gender { get; }
        public DateTime InscriptionDate { get; }
        public int Level { get; }
        public int Experience { get; }
        public int ExperienceNeeded { get; }
        public string ActualTitle { get; }
        public int NormalModeSaves { get; }
        public int HardModeSaves { get; }
        public int DivineModeSaves { get; }
        public int CheeseShaman { get; }
        public int FirstCheese { get; }
        public int Cheese { get; }
        public int Bootcamp { get; }
        public List<Title> Titles { get; }
    }
}
