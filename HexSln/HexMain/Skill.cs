namespace HexMain
{
    public class Skill
    {
        public Skill(SkillsEnum skillType)
        {
            SkillType = skillType;
            Value = new BaseAndAddedValue();
        }

        public SkillsEnum SkillType { get; private set; }
        public BaseAndAddedValue Value { get; set; }
    }
}