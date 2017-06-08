using System.Reflection;
using System.Windows.Media;

namespace HexMain
{
    public class Skill
    {
        public Skill(SkillsEnum skillType)
        {
            SkillType = skillType;
            Value = new BaseAndAddedValue();


            var type = typeof(SkillsEnum);
            var memInfo = type.GetMember(skillType.ToString());
            var sca = (SkillColorAttribute)memInfo[0].GetCustomAttribute(typeof(SkillColorAttribute), false);
        

            SkillColor = new SolidColorBrush(Color.FromRgb(sca.Red, sca.Green, sca.Blue));
        }

        public SkillsEnum SkillType { get; private set; }
        public BaseAndAddedValue Value { get; set; }

        public Brush SkillColor { get; private set; }
    }
}