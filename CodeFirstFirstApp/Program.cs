using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFirstApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Database.SetInitializer(new Initializer());

            //using (var context = new Context())
            //{
            //    #region 1、创建记录

            //    var donators = new List<Donator>
            //    {
            //        new Donator
            //        {
            //          Name   = "陈志康",
            //          Amount = 50,
            //          DonateDate = new DateTime(2016, 4, 7)
            //        },
            //        new Donator
            //        {
            //            Name = "海风",
            //            Amount = 5,
            //            DonateDate = new DateTime(2016, 4, 8)
            //        },
            //        new Donator
            //        {
            //            Name = "醉千秋",
            //            Amount = 18.8m,
            //            DonateDate = new DateTime(2016, 4, 15)
            //        }
            //    };

            //    context.Donators.AddRange(donators);
            //    context.SaveChanges();

            //    Console.Write("DB has Created!");

            //    #endregion 1、创建记录
            //}

            //using (var context = new Context())
            //{
            //    #region 2、获取记录

            //    var getDonators = context.Donators;
            //    Console.WriteLine("Id\t\t姓名\t\t金额\t\t赞助日期");
            //    foreach (var donator in getDonators)
            //    {
            //        Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", donator.DonatorId, donator.Name, donator.Amount, donator.DonateDate.ToShortDateString());
            //    }

            //    Console.WriteLine("Data has write!");

            //    #endregion 2、获取记录
            //}

            //#region 3.0 更新记录

            //using (var context = new Context())
            //{
            //    var updateDonators = context.Donators;
            //    if (updateDonators.Any())
            //    {
            //        var toBeUpdatedDonator = updateDonators.First(d => d.Name == "醉千秋");
            //        toBeUpdatedDonator.Name = "醉、千秋";
            //        context.SaveChanges();
            //    }

            //    Console.WriteLine("Data has updated!");
            //}

            //#endregion 3.0 更新记录

            using (var context = new Context())
            {
                #region 6.0 一对多关系

                var donator = new Donator
                {
                    Amount = 6,
                    Name = "键盘里的鼠标",
                    DonateDate = DateTime.Parse("2016-4-13"),
                };
                donator.PayWays.Add(new PayWay { Name = "支付宝" });
                donator.PayWays.Add(new PayWay { Name = "微信" });
                context.Donators.Add(donator);
                context.SaveChanges();
                Console.WriteLine("一对多关系!");

                #endregion 6.0 一对多关系
            }

            Console.Read();
        }
    }
}