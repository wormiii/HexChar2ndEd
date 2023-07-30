using System.Linq;

namespace HexMain
{
    public class Hex : Character
    {
        public Hex()
        {
            Name = "Hexadecimal, Jr.";
            PlayerName = "Bryan";
            Rank = 10;
            Species = new SilicoidSpecies(this);
            Profession = ProfessionEnum.Scientist;

            Credits = 2600;
            Prestige = 0;
            Experience = 0;

            Skills.Single(x => x.SkillType == SkillsEnum.Athletics).Value.BaseValue = 3;
            Skills.Single(x => x.SkillType == SkillsEnum.Science).Value.BaseValue = 9;
            Skills.Single(x => x.SkillType == SkillsEnum.Engineering).Value.BaseValue = 0;
            Skills.Single(x => x.SkillType == SkillsEnum.Combat).Value.BaseValue = 0;
            Skills.Single(x => x.SkillType == SkillsEnum.Piloting).Value.BaseValue = 5;

            SpecialAbilities.Add(new TriageMedic(this));
            SpecialAbilities.Add(new SpaceLegs(this));
            SpecialAbilities.Add(new Healer(this));
            SpecialAbilities.Add(new Doctor(this));
            SpecialAbilities.Add(new Smuggler(this));
            SpecialAbilities.Add(new Mobile(this));
            SpecialAbilities.Add(new ForeThinker(this));
            SpecialAbilities.Add(new ToughSilicoid(this));
            SpecialAbilities.Add(new Obsessive(this));
            SpecialAbilities.Add(new Calm(this));

            EarnedAbilities.Add(new Blink(this));


            Equipments.Add(new SkillChip(this, SkillsEnum.Combat) { Upgraded = true });
            Equipments.Add(new SkillChip(this, SkillsEnum.Engineering) { Upgraded = true });
            Equipments.Add(new SkillChip(this, SkillsEnum.Athletics) { Upgraded = true });
            Equipments.Add(new SkillChip(this, SkillsEnum.Piloting) { Upgraded = true });
            Equipments.Add(new SkillChip(this, SkillsEnum.Science) {Upgraded = true});
            Equipments.Add(new CyberFoot(this) { Upgraded = false });
            Equipments.Add(new CyberHand(this) { Upgraded = true });
            Equipments.Add(new AutoNurse(this));
            Equipments.Add(new WristComp(this));
            Equipments.Add(new JetPack(this) { Upgraded = true });
            Equipments.Add(new MedKit(this) {Upgraded = true});
            Equipments.Add(new Blaster(this));

            InitializeCharacter();
        }
    }
}