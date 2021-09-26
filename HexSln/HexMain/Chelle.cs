using System.Linq;

namespace HexMain
{
    public class Chelle : Character
    {
        public Chelle()
        {
            Name = "Bahkwy-Bah";
            PlayerName = "'Chelle";
            Rank = 3;
            Species = new ZoallanSpecies(this);
            Profession = ProfessionEnum.Marine;

            Credits = 525;
            Prestige = 200;
            Experience = 0;

            // 13
            Skills.Single(x => x.SkillType == SkillsEnum.Athletics).Value.BaseValue = 2;
            Skills.Single(x => x.SkillType == SkillsEnum.Combat).Value.BaseValue = 5;
            Skills.Single(x => x.SkillType == SkillsEnum.Engineering).Value.BaseValue = 0;
            Skills.Single(x => x.SkillType == SkillsEnum.Piloting).Value.BaseValue = 0;
            Skills.Single(x => x.SkillType == SkillsEnum.Science).Value.BaseValue = 2;

            SpecialAbilities.Add(new DirtyFighter(this));
            SpecialAbilities.Add(new SharpShooter(this));
            SpecialAbilities.Add(new ShockTrooper(this));

            Equipments.Add(new Voltrex(this){Upgraded = true});
            Equipments.Add(new MedKit(this));
            Equipments.Add(new Monocle(this));

            InitializeCharacter();
        }
    }
}
