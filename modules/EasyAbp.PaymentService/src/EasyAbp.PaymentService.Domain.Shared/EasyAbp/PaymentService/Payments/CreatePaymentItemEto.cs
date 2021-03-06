﻿using System;
using System.Collections.Generic;
using Volo.Abp.Data;

namespace EasyAbp.PaymentService.Payments
{
    [Serializable]
    public class CreatePaymentItemEto : IHasExtraProperties
    {
        public string ItemType { get; set; }
        
        public string ItemKey { get; set; }

        public decimal OriginalPaymentAmount { get; set; }
        
        public ExtraPropertyDictionary ExtraProperties { get; set; } = new ExtraPropertyDictionary();
    }
}