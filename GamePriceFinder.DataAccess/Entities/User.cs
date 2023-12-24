using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePriceFinder.DataAccess.Entities
{
    [Table("users")]
    public class User : IdentityUser<int>, IBaseEntity
    {
        public string Username { get; set; }
        public string Email { get; set; }
        // Навигационное свойство
        public virtual ICollection<Review> Reviews { get; set; }
        [Key]
        public int Id { get; set; } // Основной ключ в базе данных

        public Guid ExternalId { get; set; } // Уникальный индекс (опционально)
        public DateTime ModificationTime { get; set; } // Время модификации (опционально)
        public DateTime CreationTime { get; set; } // Время создания (опционально)
    }
    public class UserRoleEntity : IdentityRole<int>
    {
    }
}
