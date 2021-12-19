using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanMayTinh.Models
{
    public partial class Rate
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int IdUser { get; set; }
        public int Stars { get; set; }

        public virtual Product IdProductNavigation { get; set; }
        public virtual Product IdUserNavigation { get; set; }
    }
}
