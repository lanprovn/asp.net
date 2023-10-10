using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebsiteBanHang.Context;

namespace WebsiteBanHang.Models
{
    public class HomeModel
    {
        public List<tb_Product> ListProduct { set; get; }
        public List<tb_Category> ListCategory { set; get; }
    }
}