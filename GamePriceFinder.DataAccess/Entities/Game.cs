using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePriceFinder.DataAccess.Entities
{
    [Table("games")]
    public class Game : BaseEntity
    {
      
        public string Title { get; set; }
        public string Genre { get; set; }
        // Навигационное свойство
        public virtual ICollection<Review> Reviews { get; set; }
    }
}