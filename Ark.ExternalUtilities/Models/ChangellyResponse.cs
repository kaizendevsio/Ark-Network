﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ark.ExternalUtilities.Models
{
   public class ChangellyResponse
    {
        public string jsonrpc { get; set; }
        public string id { get; set; }
        public ChangellyTransactionResponse result { get; set; }
    }
}
