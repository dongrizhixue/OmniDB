using System.ComponentModel;

namespace OmniDB.Models.Tool
{
    public static class EnumExtensions
    {
        public static string GetDescription(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            if (field == null)
                return value.ToString();
            DescriptionAttribute? attribute = Attribute.GetCustomAttribute(
                field,
                typeof(DescriptionAttribute)) as DescriptionAttribute;
            return attribute?.Description ?? value.ToString();
        }
    }
}
