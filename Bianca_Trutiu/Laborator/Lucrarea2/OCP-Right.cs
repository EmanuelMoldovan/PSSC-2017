namespace Examples.OCP
{
    public class CustomObjTotalGenerator
    {
        public int GetTotal(object[] customObjects)
        {
            var total = 0;

            foreach(object customObject in customObjects)
            {
				total+= customObject.formula();                
            }

            return total;
        }
    }
	
	public interface ICustomObject
	{
		int formula();
	}
	
	public class CustomType1 : ICustomObject
	{
		public int value1;
		public int value2;
		
		public int formula()
		{
			return value1 + value2 / 100;
		}
	}
	
	public class CustomType2 : ICustomObject
	{
		public int value1;
		public int value2;
		
		public int formula()
		{
			return value1 + value2 / 100 + 2000 + 500;
		}
	}
	
	public class CustomType3 : ICustomObject
	{
		public int value1;
		public int value2;
		
		public int formula()
		{
			return value1 + value2 / 100 + 2000 + 500;
		}
	}
}