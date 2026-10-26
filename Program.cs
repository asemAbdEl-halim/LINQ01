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

            //var result4 = Source.ProductList
            //    .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            //foreach (var p in result4)
            //{
            //    Console.WriteLine(p.ProductName + " - " + p.UnitPrice);
            //}

            #endregion

            #region Question05

            //var result5 = Source.ProductList
            //    .Where(p => p.UnitsInStock > 0 &&
            //                p.Category == "Condiments");

            //foreach (var p in result5)
            //{
            //    Console.WriteLine(p.ProductName);
            //}

            #endregion

            #region Question06

            //var result6 = Source.ProductList
            //   .Select(p => new
            //   {
            //       Name = p.ProductName,
            //       Price = p.UnitPrice,
            //       StockStatus = p.UnitsInStock > 0
            //           ? "Available"
            //           : "Out of Stock"
            //   });

            //foreach (var p in result6)
            //{
            //    Console.WriteLine(
            //        p.Name + " - " +
            //        p.Price + " - " +
            //        p.StockStatus
            //    );
            //}

            //Console.ReadKey();

            #endregion

            #region Question07

            //var result7 = Source.ProductList
            //  .Select((p, index) => new
            //  {
            //      Position = index + 1,
            //      Name = p.ProductName
            //  });

            //foreach (var p in result7)
            //{
            //    Console.WriteLine(p.Position + ". " + p.Name);
            //}

            #endregion

            #region Question08

            //var result8 = Source.ProductList
            //    .OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice);

            //foreach (var p in result8)
            //{
            //    Console.WriteLine(
            //        p.Category + " - " +
            //        p.ProductName + " - " +
            //        p.UnitPrice
            //    );
            //}

            #endregion

            #region Question09

            //var result9 = Source.ProductList
            //    .Where(p => p.Category == "Beverages")
            //    .OrderByDescending(p => p.UnitsInStock);

            //foreach (var p in result9)
            //{
            //    Console.WriteLine(
            //        p.ProductName + " - Stock: " +
            //        p.UnitsInStock
            //    );
            //}

            #endregion

            #region Question10

            var result10 =
                from c in Source.CustomerList
                from o in c.Orders
                where o.OrderDate.Year >= 1997
                select new
                {
                    CustomerID = c.CustomerID,
                    OrderDate = o.OrderDate
                };
               
            foreach (var order in result10)
            {
                Console.WriteLine(
                    order.CustomerID + " - " +
                    order.OrderDate
                );
            }

            #endregion
        }
    }
}
