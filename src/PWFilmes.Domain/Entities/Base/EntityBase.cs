﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWFilmes.Domain.Entities.Base
{
    public class EntityBase
    {
        public Guid Id { get; protected set; }
    }
}
