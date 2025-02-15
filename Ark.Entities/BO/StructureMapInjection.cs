﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ark.Entities.BO
{
   public class StructureMapInjection
    {
        public string Class { get; set; }
        public List<StructureMapInjectionKey> BinarySponsorDataArray { get; set; }
        public List<StructureMapInjectionKey> DirectSponsorDataArray { get; set; }
    }
}
