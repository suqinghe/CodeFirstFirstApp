using System.Collections.Generic;
using System.Data.Entity;

namespace CodeFirstFirstApp
{
    public class Initializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            //context.PayWays.AddRange(new List<PayWay>
            //{
            //    new PayWay{Name = "支付宝"},
            //    new PayWay{Name = "微信"},
            //    new PayWay{Name = "QQ红包"}
            //});

            base.Seed(context);
        }
    }
}