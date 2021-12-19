using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanMayTinh.Models
{
    public partial class Cart
    {
        public int Id { get; set; }
        public int IdUsers { get; set; }
        public int IdProduct { get; set; }
        public int Amount { get; set; }

        public virtual Product IdProductNavigation { get; set; }
        public virtual User IdUsersNavigation { get; set; }
    }
}
