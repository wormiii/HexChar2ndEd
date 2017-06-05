﻿using System.Linq;

namespace HexMain
{
    public abstract class SpecialAbility
    {
        protected SpecialAbility(Character character)
        {
            Character = character;
        }

        public abstract string Name { get; }
        protected Character Character { get; private set; }
        public abstract string Description { get; }
        public abstract bool HasPool { get; }
        public abstract int Pool { get; }
        public abstract string PoolDescription { get; }
        public abstract void AlterCharacter();
    }

    public class FastLearner : SpecialAbility
    {
        public FastLearner(Character character) : base(character)
        {
        }

        public override string Name
        {
            get { return "Fast Learner"; }
        }

        public override string Description
        {
            get
            {
                return
                    "Increase your Experience awards by 10%. After you have succeeded in skill check actions for each of the 4 main skills (Combat, Piloting, Engineering, Science) you are in your groove for the rest of the campaign turn. Assist actions and Move actions such as Jet Moves will not trigger this bonus. Characters in the groove reduce the difficulty by 1 for all skill checks for the remainder of the campaign turn.";
            }
        }

        public override bool HasPool
        {
            get { return true; }
        }

        public override int Pool
        {
            get { return 4; }
        }

        public override string PoolDescription
        {
            get { return "Science, Engineering, Piloting, Combat"; }
        }

        public override void AlterCharacter()
        {
        }
    }

    public class EngineSpecialist : SpecialAbility
    {
        public EngineSpecialist(Character character) : base(character)
        {
        }

        public override string Name
        {
            get { return "Engine Specialist"; }
        }

        public override string Description
        {
            get
            {
                return
                    "You know how to manage an engine. You get a pool of rerolls to use when pumping an engine for power, transferring power, upgrading, or repairing an engine. Pool: Engineering x2";
            }
        }

        public override bool HasPool
        {
            get { return true; }
        }

        public override int Pool
        {
            get { return Character.Skills.Single(x => x.SkillType == SkillsEnum.Engineering).Value.BaseValue * 2; }
        }

        public override string PoolDescription
        {
            get { return ""; }
        }

        public override void AlterCharacter()
        {
        }
    }

    public class Resourceful : SpecialAbility
    {
        public Resourceful
            (Character character) : base(character)
        {
        }

        public override string Name
        {
            get { return "Resourcefull"; }
        }

        public override string PoolDescription
        {
            get { return ""; }
        }

        public override string Description
        {
            get
            {
                return
                    "You may spend from this pool to use Science or Engineering (whichever is higher) to substitute for any other skill check. You will get a professional reroll on the skill check. Pool: Engineering or Science (whichever is lower)";
            }
        }

        public override bool HasPool
        {
            get { return true; }
        }

        public override int Pool
        {
            get
            {
                var eng = Character.Skills.Single(x => x.SkillType == SkillsEnum.Engineering);
                var sci = Character.Skills.Single(x => x.SkillType == SkillsEnum.Science);
                if (sci.Value.BaseValue < eng.Value.BaseValue)
                    return sci.Value.BaseValue;
                return eng.Value.BaseValue;
            }
        }

        public override void AlterCharacter()
        {
        }
    }

    public abstract class NoPoolSpecialAbility : SpecialAbility
    {
        public NoPoolSpecialAbility(Character character) : base(character)
        {
        }

        public override bool HasPool
        {
            get { return false; }
        }

        public override int Pool
        {
            get { return 0; }
        }


        public override string PoolDescription
        {
            get { return string.Empty; }
        }
    }

    public class Strong : NoPoolSpecialAbility
    {
        public Strong(Character character) : base(character)
        {
        }

        public override string Name
        {
            get { return "Strong"; }
        }

        public override string Description
        {
            get { return "Add +10 Carry and +1 point of damage dealt with melee attacks."; }
        }

        public override bool HasPool
        {
            get { return false; }
        }

        public override int Pool
        {
            get { return 0; }
        }

        public override void AlterCharacter()
        {
            Character.CarryCapacity += 10;
        }
    }


    public abstract class NoChangeInCharacterSpecialAbility : NoPoolSpecialAbility
    {
        public NoChangeInCharacterSpecialAbility(Character character) : base(character)
        {
        }


        public override void AlterCharacter()
        {
        }
    }

    public class ToughSilicoid : NoPoolSpecialAbility
    {
        public ToughSilicoid(Character character) : base(character)
        {
        }

        public override string Name
        {
            get { return "Tough Silicoid"; }
        }

        public override string Description
        {
            get
            {
                return
                    "You get +1 hit point. When you roll your Silicoid damage reduction, roll an extra die and count the higher one.";
            }
        }


        public override void AlterCharacter()
        {
            Character.HitPoints.AddedValue += 1;
        }
    }

    public class Mobile : NoPoolSpecialAbility
    {
        public Mobile(Character character) : base(character)
        {
        }

        public override string Name
        {
            get { return "Mobile"; }
        }

        public override string Description
        {
            get
            {
                return
                    "Add +2 to your Move attribute. You may ignore OOC for movement. You also get a free reroll on any attempt to move extra squares. You may take this ability any number of times to gain +2 Move and a reroll for each time you take it.";
            }
        }


        public override void AlterCharacter()
        {
            Character.Species.Movement.AddedValue += 2;
        }
    }

    public class SpaceLegs : NoChangeInCharacterSpecialAbility
    {
        public SpaceLegs(Character character) : base(character)
        {
        }

        public override string Name
        {
            get { return "Space Legs"; }
        }

        public override string Description
        {
            get { return "You’ve got your bearings. You may ignore OOC entirely."; }
        }
    }


    public class ForeThinker : NoChangeInCharacterSpecialAbility
    {
        public ForeThinker(Character character)
            : base(character)
        {
        }

        public override string Name
        {
            get { return "Fore Thinker"; }
        }

        public override string Description
        {
            get { return "Roll your skill check before declaring an action"; }
        }
    }

    public class GreaseMonkey : NoChangeInCharacterSpecialAbility
    {
        public GreaseMonkey(Character character) : base(character)
        {
        }

        public override string Name
        {
            get { return "Grease Monkey"; }
        }

        public override string Description
        {
            get
            {
                return
                    "You may reroll a die on any skill check to repair, reconfigure or upgrade anything. You treat the two battlestations within the Science Bay, Sick Bay or";
            }
        }
    }

    public class Fated : NoChangeInCharacterSpecialAbility
    {
        public Fated(Character character) : base(character)
        {
        }

        public override string Name
        {
            get { return "Fated"; }
        }

        public override string Description
        {
            get
            {
                return
                    "You may choose the result of the first and last points of luck you use in a campaign turn instead of rerolling with it.";
            }
        }
    }

    public class Rocky : NoChangeInCharacterSpecialAbility
    {
        public Rocky(Character character) : base(character)
        {
        }

        public override string Name
        {
            get { return "Rocky"; }
        }


        public override string Description
        {
            get { return "Each time you would be dealt damage reduce it by 1d6."; }
        }
    }
}