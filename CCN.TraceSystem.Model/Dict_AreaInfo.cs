﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成
//     如果重新生成代码，将丢失对此文件所做的更改。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace CCN.TraceSystem.Model
{
    /// <summary>
    /// 新增区域信息
    /// </summary>
    public class Dict_AreaInfo
    {
        [Key]
        public virtual object AreaID
        {
            get;
            set;
        }

        public virtual object AreaName
        {
            get;
            set;
        }

    }

}
