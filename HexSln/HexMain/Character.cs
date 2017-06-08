using System;
using System.Collections.Generic;
using System.Linq;

namespace HexMain
{
    public abstract class Character
    {
        protected Character()
        {
            CarryCapacity = new BaseAndAddedValue();
            Luck = new BaseAndAddedValue();
            HitPoints = new BaseAndAddedValue();
            Equipments = new List<Equipment>();
            Skills = Enum.GetValues(typeof(SkillsEnum)).Cast<SkillsEnum>().Select(x => new Skill(x)).ToList();
            SpecialAbilities = new List<SpecialAbility>();
        }

        public string PlayerName { get; set; }
        public BaseAndAddedValue HitPoints { get; set; }
        public List<Equipment> Equipments { get; set; }
        public int Experience { get; set; }
        public int Prestige { get; set; }
        public int Credits { get; set; }
        public Species Species { get; set; }
        public ProfessionEnum Profession { get; set; }
        public List<SpecialAbility> SpecialAbilities { get; set; }
        public BaseAndAddedValue CarryCapacity { get; set; }

        public string Name { get; set; }
        public BaseAndAddedValue Luck { get; set; }
        public int Rank { get; set; }
        public List<Skill> Skills { get; set; }

        protected void InitializeCharacter()
        {
            CarryCapacity.BaseValue = Skills.Single(x => x.SkillType == SkillsEnum.Athletics).Value.BaseValue * 10;
            Luck.BaseValue = Rank + 5;
            HitPoints.BaseValue = Rank + Skills.Single(x => x.SkillType == SkillsEnum.Athletics).Value.BaseValue +
                                  Species.BaseHitPoints;
            SpecialAbilities.ForEach(x => x.AlterCharacter());
            Equipments.ForEach(x => x.AlterCharacter());
        }
    }
}