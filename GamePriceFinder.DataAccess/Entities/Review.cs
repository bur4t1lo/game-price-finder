using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePriceFinder.DataAccess.Entities
{
    [Table("reviews")]
    public class Review : BaseEntity
    {
        public int UserId { get; set; }
        public int GameId { get; set; }
        public string Content { get; set; }
        public User User { get; set; }
        public Game Game { get; set; }
        public int UserID { get; set; }
        public int GameID { get; set; }
    }
}