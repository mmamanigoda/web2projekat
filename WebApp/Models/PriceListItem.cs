﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class PriceListItem
    {
        public int Id { get; set; }
        public int PriceList_Id { get; set; }
        public int Item_Id { get; set; }
        public int Price { get; set; }
    }
}