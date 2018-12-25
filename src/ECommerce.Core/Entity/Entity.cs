using System;

namespace ECommerce.Core.Entity

{
    public class Entity : IEntity
    {
        public long Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
