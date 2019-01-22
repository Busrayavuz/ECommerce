using System;

namespace ECommerce.Core.Entity

{
    public abstract class Entity : IEntity
    {
        public long Id { get; set; }
        public long CreationUserId { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;
        public long LastModifierUserId { get; set; }
        public DateTime LastModifierDate { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;
    }
}
