using System.Collections.Generic;

namespace HexMain
{
    public abstract class Species
    {
        protected Species()
        {
            TargetNumber = new BaseAndAddedValue();
            AlienAbilities = new List<SpecialAbility>();
            Movement = new BaseAndAddedValue();
            Hands = new BaseAndAddedValue();
        }

        public abstract string Name { get;  }
        public bool CanWearArmor { get; set; }
        public BaseAndAddedValue Movement { get; set; }
        public BaseAndAddedValue Hands { get; set; }
        public BaseAndAddedValue TargetNumber { get; set; }
        public List<SpecialAbility> AlienAbilities { get; set; }
        public int BaseHitPoints { get; set; }
    }

    public class SilicoidSpecies : Species
    {
        public SilicoidSpecies(Character character)
        {
            CanWearArmor = false;
            BaseHitPoints = 9;
            TargetNumber.BaseValue = 7;
            Hands.BaseValue = 1;
            Movement.BaseValue = 4;
            AlienAbilities.Add(new Rocky(character));
            AlienAbilities.Add(new Strong(character));
        }

        public override string Name
        {
            get { return "Silicoid"; }
        }
    }

    public class ZoallanSpecies : Species
    {
        public ZoallanSpecies(Character character)
        {
            CanWearArmor = false;
            BaseHitPoints = 4;
            TargetNumber.BaseValue = 7;
            Hands.BaseValue = 3;
            Movement.BaseValue = 7;
            AlienAbilities.Add(new Carapice(character));
        }

        public override string Name
        {
            get { return "Zoallan"; }
        }
    }
}