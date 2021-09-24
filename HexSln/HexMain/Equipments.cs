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
            get { return BaseMass; }
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
        public CyberHand(Character character)
            : base(character)
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

    public class CyberFoot : Equipment
    {
        public CyberFoot(Character character)
            : base(character)
        {
        }

        public override string Name
        {
            get { return "Cyber Foot"; }
        }

        public override string Description
        {
            get { return "+1 movement."; }
        }

        protected override int BaseMass
        {
            get { return 8; }
        }

        public override void AlterCharacter()
        {
            Character.Species.Movement.AddedValue += 1;
        }
    }

    public class ToolKit : Equipment
    {
        public ToolKit(Character character)
            : base(character)
        {
        }

        public override string Name
        {
            get { return "Tool Kit"; }
        }

        public override string Description
        {
            get
            {
                return
                    "Reduce the difficulty of Engineering Skill checks to upgrade, repair, install or put out local fires by 1. An upgraded ToolKit reduces this difficulty by 2 instead.";
            }
        }

        protected override int BaseMass
        {
            get { return 5; }
        }

        public override void AlterCharacter()
        {
        }
    }

    public class MedKit : Equipment
    {
        public MedKit(Character character)
            : base(character)
        {
        }

        public override string Name
        {
            get { return "Med Kit"; }
        }

        public override string Description
        {
            get
            {
                return
                    "A MedKit in hand allows you to use your Science skill to heal, detoxify or de-ionize yourself and/or adjacent characters. If it is upgraded, the difficulty to use your MedKit is reduced by 1.";
            }
        }

        protected override int BaseMass
        {
            get { return 5; }
        }

        public override void AlterCharacter()
        {
        }
    }

    public class Blaster : Equipment
    {
        public Blaster(Character character)
            : base(character)
        {
        }

        public override string Name
        {
            get { return "Blaster"; }
        }

        public override string Description
        {
            get
            {
                return
                    "Damage: 2d6 - 1";
            }
        }

        protected override int BaseMass
        {
            get { return 4; }
        }

        public override void AlterCharacter()
        {
        }
    }
    public class Voltrex : Equipment
    {
        public Voltrex(Character character)
            : base(character)
        {
        }

        public override string Name
        {
            get { return "Voltrex"; }
        }

        public override string Description
        {
            get
            {
                return
                    "Damage: 1d6; up to 4; -1 for every target to hit; upgraded: 1 easier to hit";
            }
        }

        protected override int BaseMass
        {
            get { return 10; }
        }

        public override void AlterCharacter()
        {
        }
    }

    public class JetPack : Equipment
    {
        public JetPack(Character character)
            : base(character)
        {
        }

        public override string Name
        {
            get { return "Jet Pack"; }
        }

        public override string Description
        {
            get
            {
                return
                    "Turn a move into jet pack move vs 8 Pilot adding +3 difficulty for each additional move (Upgraded, 1 less difficult)";
            }
        }

        protected override int BaseMass
        {
            get { return 4; }
        }

        public override void AlterCharacter()
        {
        }
    }

    public class WristComp : Equipment
    {
        public WristComp(Character character)
            : base(character)
        {
        }

        public override string Name
        {
            get { return "Wrist Comp"; }
        }

        public override string Description
        {
            get
            {
                return
                    "+1 to science checks to hack/repair/upgrade. Used to ask yes/no question. +3 difficulty for each additional question.";
            }
        }

        protected override int BaseMass
        {
            get { return 1; }
        }

        public override void AlterCharacter()
        {
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
            if (Skill == SkillsEnum.Athletics)
            {
                Character.CarryCapacity.AddedValue += 10;
            }
        }
    }
}