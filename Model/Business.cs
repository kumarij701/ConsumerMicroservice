﻿using System;

namespace ConsumerMicroservice.Model
{
    public partial class Business
    {
        public int BusinessId { get; set; }
        public string BusinessName { get; set; }
        public string BusinessType { get; set; }
        public int TotalEmployees { get; set; }
        public int BusinessMasterId { get; set; }
        public int ConsumerId { get; set; }

        public virtual BusinessMaster BusinessMaster { get; set; }
    }
}
