using System.Collections.Generic;

namespace Examples.OCP
{
    public class CustomObjTotalGenerator
    {
        public int GetTotalOCP(List<ICustomType> customObjects)
        {
            var total = 0;
            foreach(ICustomType customType in customObjects)
            {
                total += customType.GetValue();
            }

            return total;
        }
    }
}
