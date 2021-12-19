using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanMayTinh.Models
{
    public partial class Coment
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int IdUser { get; set; }
        public string Content { get; set; }

        public virtual Product IdProductNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
