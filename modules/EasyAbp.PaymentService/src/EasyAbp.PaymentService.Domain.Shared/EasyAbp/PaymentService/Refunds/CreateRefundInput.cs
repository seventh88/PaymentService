﻿using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Volo.Abp.Data;

namespace EasyAbp.PaymentService.Refunds
{
    [Serializable]
    public class CreateRefundInput : IHasExtraProperties
    {
        public Guid PaymentId { get; set; }
        
        [CanBeNull]
        public string DisplayReason { get; set; }

        [CanBeNull]
        public string CustomerRemark { get; set; }
        
        [CanBeNull]
        public string StaffRemark { get; set; }
        
        // Todo: should not be a big object.
        public ExtraPropertyDictionary ExtraProperties { get; set; } = new ExtraPropertyDictionary();

        public List<CreateRefundItemInput> RefundItems { get; set; } = new List<CreateRefundItemInput>();
    }
}