using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Data;

namespace HexMain.ValueConverters
{
    public class ProfessionToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                var profession = (ProfessionEnum) value;



                var type = typeof(ProfessionEnum);
                var memInfo = type.GetMember(profession.ToString());
                var ptsa = (ProfessionToSkillAttribute)memInfo[0].GetCustomAttribute(typeof(ProfessionToSkillAttribute), false);

                var skill = new Skill(ptsa.Skill);
                return skill.SkillColor;
            }
            catch
            {
                return new List<object>();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}