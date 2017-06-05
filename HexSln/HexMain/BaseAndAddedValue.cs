namespace HexMain
{
    public class BaseAndAddedValue
    {
        public int BaseValue { get; set; }
        public int AddedValue { get; set; }

        public int Value
        {
            get { return BaseValue + AddedValue; }
        }
    }
}