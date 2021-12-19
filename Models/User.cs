using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanMayTinh.Models
{
    public partial class User
    {
        public User()
        {
            Carts = new HashSet<Cart>();
            Coments = new HashSet<Coment>();
            OrderProducts = new HashSet<OrderProduct>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Coment> Coments { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
