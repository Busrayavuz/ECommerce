﻿using ECommerce.Core.Entity;
using System.Collections.Generic;

namespace ECommerce.Entities.Concrete.Entities
{
    public class Country:Entity
    {
        public string CountryName { get; set; }
        public virtual List<City> Cities { get; set; }
    }
}
