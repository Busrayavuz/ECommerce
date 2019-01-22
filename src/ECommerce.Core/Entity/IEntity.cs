using System;

namespace ECommerce.Core.Entity
{
    public interface IEntity
    {
        long  Id { get; set; }
        long CreationUserId { get; set; }
        DateTime CreationDate { get; set; }
        long LastModifierUserId { get; set; }
        DateTime LastModifierDate { get; set; }
        bool IsDeleted { get; set; }
    }
}
