using System.Linq;

namespace HexMain
{
    public abstract class Equipment
    {
        protected Equipment(Character character)
        {
            Character = character;
        }

        public abstract string Name { get; }
        protected Character Character { get; private set; }

        public abstract string Description { get; }

        //public abstract int CreditCost { get; }
        public int Mass
        {
            get { return BaseMass / (Upgraded ? 2 : 1); }
        }

        protected abstract int BaseMass { get; }

        public bool Upgraded { get; set; }

        //public abstract bool HasPool { get; }
        //public abstract int Pool { get; }
        //public abstract string PoolDescription { get; }
        public abstract void AlterCharacter();
    }

    public class CyberHand : Equipment
    {
        public CyberHand(Character character) : base(character)
        {
        }

        public override string Name
        {
            get { return "Cyber Hand"; }
        }

        public override string Description
        {
            get { return "Add +1 hand."; }
        }

        protected override int BaseMass
        {
            get { return 6; }
        }

        public override void AlterCharacter()
        {
            Character.Species.Hands.AddedValue += 1;
        }
    }

    public class SkillChip : Equipment
    {
        public SkillChip(Character character, SkillsEnum skill) : base(character)
        {
            Skill = skill;
        }

        public SkillsEnum Skill { get; private set; }

        public override string Name
        {
            get { return string.Format("{0} Skill Chip", Skill); }
        }

        public override string Description
        {
            get { return string.Format("-1 difficulty for {0} skill checks", Skill); }
        }

        protected override int BaseMass
        {
            get { return 2; }
        }

        public override void AlterCharacter()
        {
            Character.Skills.Single(x => x.SkillType == Skill).Value.AddedValue += 1;
        }
    }
}