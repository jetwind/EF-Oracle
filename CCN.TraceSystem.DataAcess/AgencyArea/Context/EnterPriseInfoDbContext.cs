using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using CCN.TraceSystem.Model;

namespace CCN.TraceSystem.DataAcess
{
    public class EnterPriseInfoDbContext:DbContext
    {
        //设置连接字符串
        public EnterPriseInfoDbContext() : base("name=MfTest") 
        { 
            
        }

       // public DbSet
        //定义此对象的集合
        public DbSet<ENTERPRISEIFO> EnterPriseInfos { get; set; }


        /// <summary>
        /// 对象开始创建时
        /// </summary>
        /// <param name="modelBuilder">DbModelBuilder is used to map CLR classes to a database schema.  This code     centric approach to building an Entity Data Model (EDM) model is known as 'Code First'.</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //配置有两种方式:Data Annotations ,Fluent API 
            //使用Data Annotations配置很简单，也可能是你想要的。但是Data Annotations只能获得一部分配置的功能。这时,Fluent API可以提供更多的功能,基于这个原因你可能会愿意用它.
            //这里我们采用Fluent API来控制,灵活,代码可控 Fluent API的基本思路是使用链方法调用程序代码，这样代码很容易被开发者所阅读。


            //设置对应的schema和表名,之前针对配置全部写在此处,先为了分工职责,代码干净整洁,放在了专用的配置信息中
            //modelBuilder.Entity<ENTERPRISEIFO>().ToTable("ENTERPRISEINFOES", "DEVELOP");

            //加载针对该对象的配置信息,
            modelBuilder.Configurations.Add(new AgencyArea.Configuration.EnterPriseInfo());
            modelBuilder.Configurations.Add(new AgencyArea.Configuration.ContactConfig());

            //定义复杂类型,地址定义为复杂类型(对象可以看作是两个,存储的时候在一个表中)
            modelBuilder.ComplexType<EnterPrise_Contact>();

            base.OnModelCreating(modelBuilder);

            
        }


    }
}
