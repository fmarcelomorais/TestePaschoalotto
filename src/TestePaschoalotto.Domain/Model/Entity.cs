﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePaschoalotto.Domain.Model
{
    public class Entity
    {
        public Guid Identificado { get; set; }

        public Entity()
        {
            Identificado = Guid.NewGuid();
        }
    }

}
