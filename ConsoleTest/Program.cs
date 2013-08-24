using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCN.TraceSystem.DataAcess;
using CCN.TraceSystem.Model;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CCN.TraceSystem.Common;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //指定数据库模式
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EnterPriseInfoDbContext>());

                var dbContext = new EnterPriseInfoDbContext();
                var ep = new ENTERPRISEIFO()
                {
                    ENTERPRISE_ID="E0123511",
                    ENTERPRISE_NAME = "CCN11",
                    AREAID = "021",
                    PRODUCTION_PRODUCTS = "婴幼儿奶粉",
                    REG_ADDRESS = "陆家嘴"
                };

                //更新到数据库->先查询对象在更新
                //添加到EF管理容器中，并获取 实体对象 的伪包装类对象
                //DbEntityEntry<ENTERPRISEIFO> entry = dbContext.Entry<ENTERPRISEIFO>(ep);
                //entry.State = System.Data.EntityState.Unchanged;
                //entry.Property("ENTERPRISE_NAME").IsModified = true;

                dbContext.EnterPriseInfos.Add(ep);
                dbContext.SaveChanges();
                Console.WriteLine("成功了");

                //ENTERPRISEIFO q = dbContext.EnterPriseInfos.Where(e => e.ENTERPRISE_ID == "E01235").FirstOrDefault();
                    //from e in dbContext.EnterPriseInfos where e.ENTERPRISE_ID == "E01235" select e;
               // Console.WriteLine(JsonHelper.GetJson<ENTERPRISEIFO>(q));

                Console.ReadKey();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx) 
            {
                Console.WriteLine(dbEx.ToString());
            }
            
        }
    }
}
