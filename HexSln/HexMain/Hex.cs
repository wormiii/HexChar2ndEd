using System.Linq;

namespace HexMain
{
    public class Hex : Character
    {
        public Hex()
        {
            Name = "Hexadecimal";
            PlayerName = "Bryan";
            Rank = 5;
            Species = new SilicoidSpecies(this);
            Profession = ProfessionEnum.Scientist;

            Credits = 1000;
            Prestige = 0;
            Experience = 100;

            Skills.Single(x => x.SkillType == SkillsEnum.Athletics).Value.BaseValue = 2;
            Skills.Single(x => x.SkillType == SkillsEnum.Combat).Value.BaseValue = 0;
            Skills.Single(x => x.SkillType == SkillsEnum.Engineering).Value.BaseValue = 0;
            Skills.Single(x => x.SkillType == SkillsEnum.Piloting).Value.BaseValue = 2;
            Skills.Single(x => x.SkillType == SkillsEnum.Science).Value.BaseValue = 5;

            SpecialAbilities.Add(new SpaceLegs(this));
            SpecialAbilities.Add(new Healer(this));
            SpecialAbilities.Add(new Doctor(this));
            SpecialAbilities.Add(new Mobile(this));
            SpecialAbilities.Add(new ForeThinker(this));

           

            Equipments.Add(new SkillChip(this, SkillsEnum.Piloting) { Upgraded = true });
            Equipments.Add(new SkillChip(this, SkillsEnum.Science) {Upgraded = true});
            Equipments.Add(new CyberHand(this) {Upgraded = true});
            Equipments.Add(new WristComp(this));
            Equipments.Add(new MedKit(this) {Upgraded = true});
            Equipments.Add(new Blaster(this));

            InitializeCharacter();
        }
    }
}