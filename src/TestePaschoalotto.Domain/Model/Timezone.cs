﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePaschoalotto.Domain.Model
{
    public class Timezone
    {
        public Guid Id { get; set; }
        public string Offset { get; set; }
        public string Description { get; set; }
    }
}