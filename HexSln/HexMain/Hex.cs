using System.Linq;

namespace HexMain
{
    public class Hex : Character
    {
        public Hex()
        {
            Name = "Hexadecimal";
            PlayerName = "Bryan";
            Rank = 12;
            Species = new SilicoidSpecies(this);
            Profession = ProfessionEnum.Engineer;

            Credits = 6000;
            Prestige = 900;
            Experience = 100;

            Skills.Single(x => x.SkillType == SkillsEnum.Athletics).Value.BaseValue = 4;
            Skills.Single(x => x.SkillType == SkillsEnum.Combat).Value.BaseValue = 4;
            Skills.Single(x => x.SkillType == SkillsEnum.Engineering).Value.BaseValue = 10;
            Skills.Single(x => x.SkillType == SkillsEnum.Piloting).Value.BaseValue = 4;
            Skills.Single(x => x.SkillType == SkillsEnum.Science).Value.BaseValue = 7;

            SpecialAbilities.Add(new Resourceful(this));
            SpecialAbilities.Add(new JuryRigger(this));
            SpecialAbilities.Add(new SpaceLegs(this));
            SpecialAbilities.Add(new ToughSilicoid(this));
            SpecialAbilities.Add(new Mobile(this));
            SpecialAbilities.Add(new Smuggler(this));
            SpecialAbilities.Add(new EngineSpecialist(this));
            SpecialAbilities.Add(new Patient(this));
            SpecialAbilities.Add(new ForeThinker(this));
            SpecialAbilities.Add(new JetPackJockey(this));
            SpecialAbilities.Add(new Fated(this));
            SpecialAbilities.Add(new Obsessive(this));
            //37

            Equipments.Add(new SkillChip(this, SkillsEnum.Piloting) { Upgraded = true });
            Equipments.Add(new SkillChip(this, SkillsEnum.Engineering) { Upgraded = true });
            Equipments.Add(new SkillChip(this, SkillsEnum.Science) {Upgraded = true});
            Equipments.Add(new SkillChip(this, SkillsEnum.Combat));
            Equipments.Add(new CyberHand(this) {Upgraded = true});
            Equipments.Add(new CyberFoot(this) {Upgraded = true});
            Equipments.Add(new MedKit(this) {Upgraded = true});
            Equipments.Add(new ToolKit(this) {Upgraded = true});
            Equipments.Add(new Blaster(this));
            Equipments.Add(new JetPack(this));
            Equipments.Add(new WristComp(this));

            InitializeCharacter();
        }
    }
}