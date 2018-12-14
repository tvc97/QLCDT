﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLCDT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class HDDK
    {
        [DisplayName("Mã hợp đồng")]
        public int ID { get; set; }
        [DisplayName("Khách hàng")]
        public virtual KHACHHANG KHACHHANG { get; set; }
        [DisplayName("SIM")]
        public string IDSIM { get; set; }
        [Browsable(false)]
        public int IDKH { get; set; }
        [DisplayName("Cước đăng ký")]
        public decimal CUOCDK { get; set; }

        [Browsable(false)]
        public virtual THONGTINSIM THONGTINSIM { get; set; }
        [Browsable(false)]
        public System.DateTime NGAYBD { get; set; }
        [Browsable(false)]
        public System.DateTime NGAYKT { get; set; }

        [DisplayName("Ngày bắt đầu")]
        public virtual string NgayBD
        {
            get { return NGAYBD.ToString("dd/MM/yyyy"); }
        }

        [DisplayName("Hạn hợp đồng")]
        public virtual string NgayKT
        {
            get { return NGAYKT.ToString("dd/MM/yyyy"); }
        }

    }
}
