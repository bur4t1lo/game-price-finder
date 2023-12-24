using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePriceFinder.DataAccess.Entities
{
    public interface IBaseEntity
    {
        public int Id { get; set; } // Основной ключ в базе данных

        public Guid ExternalId { get; set; } // Уникальный индекс (опционально)
        public DateTime ModificationTime { get; set; } // Время модификации (опционально)
        public DateTime CreationTime { get; set; } // Время создания (опционально)
    }
}
