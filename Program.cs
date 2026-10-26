using LINQ01.DataSources;

namespace LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //var result1 = Source.ProductList
            //        .Where(p => p.Category == "Seafood");

            //foreach (var p in result1)
            //{
            //    Console.WriteLine(p.ProductName + " - " + p.UnitPrice);
            //}
            #endregion

            #region Question02

            //var result2 = Source.ProductList
            //   .Select(p => p.ProductName);

            //foreach (var name in result2)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion

            #region Question03

            //var result3 = Source.ProductList
            //    .OrderBy(p => p.UnitPrice);

            //foreach (var p in result3)
            //{
            //    Console.WriteLine(p.ProductName + " - " + p.UnitPrice);
            //}


            #endregion

            #region Question04

            var result4 = Source.ProductList
                .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            foreach (var p in result4)
            {
                Console.WriteLine(p.ProductName + " - " + p.UnitPrice);
            }

            #endregion
        }
    }
}
