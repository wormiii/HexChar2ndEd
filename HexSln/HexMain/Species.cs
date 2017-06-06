using System.Collections.Generic;

namespace HexMain
{
    public abstract class Species
    {
        protected Species()
        {
            AlienAbilities = new List<SpecialAbility>();
            Movement = new BaseAndAddedValue();
            Hands = new BaseAndAddedValue();
        }

        public abstract string Name { get;  }
        public bool CanWearArmor { get; set; }
        public BaseAndAddedValue Movement { get; set; }
        public BaseAndAddedValue Hands { get; set; }
        public int TargetNumber { get; set; }
        public List<SpecialAbility> AlienAbilities { get; set; }
        public int BaseHitPoints { get; set; }
    }

    public class SilicoidSpecies : Species
    {
        public SilicoidSpecies(Character character)
        {
            //SpeciesType = SpeciesEnum.Silicoid;
            CanWearArmor = false;
            BaseHitPoints = 9;
            TargetNumber = 7;
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
}