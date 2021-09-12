using System;

namespace HexMain
{
    public enum SkillsEnum
    {
        [SkillColor(0x55, 0x55, 0x55)] Athletics,
        [SkillColor(0x00, 0xff, 0x00)] Science,
        [SkillColor(0x00, 0x00, 0xff)] Engineering,
        [SkillColor(0xff, 0x00, 0x00)] Combat,
        [SkillColor(0xff, 0xff, 0x00)] Piloting
    }

    public enum ProfessionEnum
    {
        [ProfessionToSkill(SkillsEnum.Combat)] Fighter,
        [ProfessionToSkill(SkillsEnum.Engineering)] Engineer,
        [ProfessionToSkill(SkillsEnum.Science)] Scientist
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class SkillColorAttribute : Attribute
    {
        public SkillColorAttribute(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public byte Red { get; private set; }
        public byte Green { get; private set; }
        public byte Blue { get; private set; }
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class ProfessionToSkillAttribute : Attribute
    {
        public ProfessionToSkillAttribute(SkillsEnum skill)
        {
            Skill = skill;
        }

        public SkillsEnum Skill { get; private set; }
    }
}