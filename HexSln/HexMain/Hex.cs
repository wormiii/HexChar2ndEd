using System.Linq;

namespace HexMain
{
    public class Hex : Character
    {
        public Hex()
        {
            Name = "Hexadecimal";
            PlayerName = "Bryan";
            Rank = 9;
            Species = new SilicoidSpecies(this);
            Profession = ProfessionEnum.Engineer;

            Credits = 3000;
            Prestige = 0;
            Experience = 0;

            Skills.Single(x => x.SkillType == SkillsEnum.Athletics).Value.BaseValue = 1;
            Skills.Single(x => x.SkillType == SkillsEnum.Combat).Value.BaseValue = 2;
            Skills.Single(x => x.SkillType == SkillsEnum.Engineering).Value.BaseValue = 8;
            Skills.Single(x => x.SkillType == SkillsEnum.Piloting).Value.BaseValue = 2;
            Skills.Single(x => x.SkillType == SkillsEnum.Science).Value.BaseValue = 6;

            SpecialAbilities.Add(new Resourceful(this));
            SpecialAbilities.Add(new SpaceLegs(this));
            SpecialAbilities.Add(new ToughSilicoid(this));
            SpecialAbilities.Add(new Mobile(this));
            SpecialAbilities.Add(new FastLearner(this));
            SpecialAbilities.Add(new EngineSpecialist(this));
            SpecialAbilities.Add(new ForeThinker(this));
            SpecialAbilities.Add(new GreaseMonkey(this));
            SpecialAbilities.Add(new Fated(this));

            Equipments.Add(new SkillChip(this, SkillsEnum.Engineering) {Upgraded = true});
            Equipments.Add(new SkillChip(this, SkillsEnum.Science) {Upgraded = true});
            Equipments.Add(new SkillChip(this, SkillsEnum.Combat));
            Equipments.Add(new CyberHand(this) {Upgraded = true});
            Equipments.Add(new CyberFoot(this) {Upgraded = true});
            Equipments.Add(new MedKit(this) {Upgraded = true});
            Equipments.Add(new ToolKit(this) {Upgraded = true});
            Equipments.Add(new Blaster(this));

            InitializeCharacter();
        }
    }
}