using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//add
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CCN.TraceSystem.Model;

namespace CCN.TraceSystem.DataAcess.AgencyArea.Configuration
{

    /// <summary>
    /// 注意此处的继承,继承为"ComplexTypeConfiguration"类型
    /// </summary>
    public class ContactConfig:ComplexTypeConfiguration<EnterPrise_Contact>
    {
        public ContactConfig() 
        {
            
            this.Property(d => d.Contact_Man).HasMaxLength(50);
        }
    }
}
