using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanMayTinh.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public int Id { get; set; }
        public int IdUser { get; set; }
        public DateTime Time { get; set; }
        public int Status { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string OtherNote { get; set; }
        public string District { get; set; }

        public virtual User IdUserNavigation { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
