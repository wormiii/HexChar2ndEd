using System.Linq;

namespace HexMain
{
    public class Chelle : Character
    {
        public Chelle()
        {
            Name = "Bahkwy-Bah";
            PlayerName = "'Chelle";
            Rank = 1;
            Species = new ZoallanSpecies(this);
            Profession = ProfessionEnum.Fighter;

            Credits = 500;
            Prestige = 0;
            Experience = 0;

            // 13
            Skills.Single(x => x.SkillType == SkillsEnum.Athletics).Value.BaseValue = 2;
            Skills.Single(x => x.SkillType == SkillsEnum.Combat).Value.BaseValue = 4;
            Skills.Single(x => x.SkillType == SkillsEnum.Engineering).Value.BaseValue = 0;
            Skills.Single(x => x.SkillType == SkillsEnum.Piloting).Value.BaseValue = 0;
            Skills.Single(x => x.SkillType == SkillsEnum.Science).Value.BaseValue = 0;

            SpecialAbilities.Add(new DirtyFighter(this));

            Equipments.Add(new Blaster(this));
            Equipments.Add(new MedKit(this));

            InitializeCharacter();
        }
    }
}
