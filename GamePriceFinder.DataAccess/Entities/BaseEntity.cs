using System;
using System.ComponentModel.DataAnnotations;

namespace GamePriceFinder.DataAccess.Entities
{
    public abstract class BaseEntity: IBaseEntity
    {
        [Key]
        public int Id { get; set; } // Основной ключ в базе данных

        public Guid ExternalId { get; set; } // Уникальный индекс (опционально)
        public DateTime ModificationTime { get; set; } // Время модификации (опционально)
        public DateTime CreationTime { get; set; } // Время создания (опционально)
    }
}
