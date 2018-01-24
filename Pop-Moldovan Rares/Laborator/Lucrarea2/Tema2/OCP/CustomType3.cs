namespace Examples.OCP
{
    public class CustomType3 : ICustomType
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }

        public int GetValue()
        {
            return Value1 + Value2 / 100 + 2000 + 500;
        }
    }
}