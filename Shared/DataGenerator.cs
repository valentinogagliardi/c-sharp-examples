using Bogus;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Faker
{

    class OrderDetail
    {
        public int Id { get; set; }
        public int OrderID { get; set; }
        public int ArticleID { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }

    }
    class CSVGenerator
    {
        static int OrderDetailIds = 0;
        static int OrderIds = 300;
        static int ArticleIds = 609;

        public static void GenerateOrderDetails(int quantity)
        {
            var prepare = new Faker<OrderDetail>()
            .StrictMode(true)
            .RuleFor(o => o.Id, f => OrderDetailIds++)
            .RuleFor(o => o.OrderID, f => OrderIds++)
            .RuleFor(o => o.ArticleID, f => ArticleIds++)
            .RuleFor(o => o.Price, f => f.Random.Number(1, 340))
            .RuleFor(o => o.Qty, f => f.Random.Int(1, 4));

            var generated = prepare.Generate(quantity);

            IEnumerable<string> query =
            from element in generated
            let line = $"{element.Id}, {element.OrderID}, {element.ArticleID}, {element.Price}, {element.Qty}"
            select line;

            //File.WriteAllText("order-details.csv", "id, order_id, article_id, price, qty\n");
            File.WriteAllLines("order-details.csv", query);
        }
    }
}