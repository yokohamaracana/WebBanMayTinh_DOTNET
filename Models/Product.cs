using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanMayTinh.Models
{
    public partial class Product
    {
        public Product()
        {
            Carts = new HashSet<Cart>();
            Coments = new HashSet<Coment>();
            OrderProducts = new HashSet<OrderProduct>();
            RateIdProductNavigations = new HashSet<Rate>();
            RateIdUserNavigations = new HashSet<Rate>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public int Brand { get; set; }
        public string ShortDesc { get; set; }
        public string Desc { get; set; }
        public int View { get; set; }
        public int Sold { get; set; }
        public int DiscountPrice { get; set; }

        public virtual Brand BrandNavigation { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Coment> Coments { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public virtual ICollection<Rate> RateIdProductNavigations { get; set; }
        public virtual ICollection<Rate> RateIdUserNavigations { get; set; }
    }
}
