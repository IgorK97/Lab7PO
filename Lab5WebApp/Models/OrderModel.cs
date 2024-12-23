﻿using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5WebApp.Models
{
    public class OrderModel
    {
        public OrderModel()
        {

        }
        [Key]
        public int Id { get; set; }

        //public int clientId { get; set; }
        //public int? courierId { get; set; }

        public decimal final_price { get; set; }

        public string address_del { get; set; }

        public decimal weight { get; set; }
        public DateTime? ordertime { get; set; }
        public DateTime? deliverytime { get; set; }

        public string delstatus { get; set; }
        public string? comment { get; set; }

        public List<OrderLineModel> listedlines { get; set; }


        //public OrderModel(Order o)
        //{
        //    Id = o.Id;
        //    clientId = o.ClientId;
        //    courierId = o.CourierId;
        //    final_price = o.FinalPrice;
        //    address_del = o.AddressDel;
        //    weight = o.Weight;
        //    ordertime = o.Ordertime;
        //    deliverytime = o.Deliverytime;
        //    delstatusId = o.DelstatusId;
        //    comment = o.Comment;
        //    order_linesIds = o.OrderLines.Select(i => i.Id).ToList();
        //}
    }
}
