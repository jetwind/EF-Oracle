using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCN.TraceSystem.Model;

//add
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CCN.TraceSystem.DataAcess.AgencyArea.Configuration
{
    public class EnterPriseInfo:EntityTypeConfiguration<ENTERPRISEIFO>
    {
        public EnterPriseInfo() 
        {
            //配置数据库映射的表
            ToTable("ENTERPRISEINFOES", "DEVELOP");

            //指定主键,以及组件的约束
            this.HasKey(d => d.ENTERPRISE_ID).Property(d => d.ENTERPRISE_ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            
            //配置并发时间戳
            this.Property(d => d.ROWVERSION).IsRowVersion();

            //配置并发非时间戳字段,既需要修改的时候要验证的字段
            this.Property(d => d.ENTERPRISE_ID).IsConcurrencyToken();

            //配置decimal字段,设置有效位和小数位
            //HasPrecision(8, 2);

            //配置字段验证
            this.Property(d => d.ENTERPRISE_NAME).IsRequired();
        }
    
    }
}
