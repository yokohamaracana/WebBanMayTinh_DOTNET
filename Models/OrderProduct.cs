using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanMayTinh.Models
{
    public partial class OrderProduct
    {
        public int Id { get; set; }
        public int IdOrder { get; set; }
        public int IdProduct { get; set; }
        public int IdUsers { get; set; }
        public int Quantity { get; set; }
        public int Amount { get; set; }

        public virtual Order IdOrderNavigation { get; set; }
        public virtual Product IdProductNavigation { get; set; }
        public virtual User IdUsersNavigation { get; set; }
    }
}
