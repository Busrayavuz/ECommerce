using System;

namespace ECommerce.Core.Entity
{
    public interface IEntity
    {
        long  Id { get; set; }
        DateTime? CreatedDate { get; set; }
        DateTime? ModifiedDate{ get; set; }
        DateTime? DeletedDate { get; set; }
        bool IsDeleted { get; set; }
    }
}
