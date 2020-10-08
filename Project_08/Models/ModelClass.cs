using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_08.Models
{
    public  class OrderDetail
    {
        public int Id { get; set; }
        public Nullable<int> QTY { get; set; }
        public Nullable<int> CarId { get; set; }
        public Nullable<int> CarOrderId { get; set; }

        public virtual CarOrder CarOrder { get; set; }
        public virtual Car Car { get; set; }
    }

    public  class CarType
    {
       
        public int Id { get; set; }
        public string Cartype1 { get; set; }

      public virtual ICollection<Car> Cars { get; set; }
    }



    public  class CarOrder
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }



    public class Car
    {
      
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public Nullable<decimal> price { get; set; }
      
        public Nullable<bool> IsAvailable { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<int> CarTypeId { get; set; }

        public virtual CarType CarType { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }

    public class CarOrderDetails
    {
        public IEnumerable<Car> Cars { get; set; }
        public IEnumerable<OrderDetail> OrderDetails { get; set; }
        public IEnumerable<CarOrder> CarOrders { get; set; }
    }

    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);

            return value == null ? default(T) :
                JsonConvert.DeserializeObject<T>(value);
        }
    }

}
