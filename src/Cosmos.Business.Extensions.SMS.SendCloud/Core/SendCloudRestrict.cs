﻿using System.Collections.Generic;
using Cosmos.Business.Extensions.SMS.Events.Restrict;

namespace Cosmos.Business.Extensions.SMS.SendCloud.Core {
    public sealed class SendCloudRestrict : SmsSendRestrictTemplate {
        private static readonly SendCloudRestrict _selfCache = new SendCloudRestrict();
        public static SendCloudRestrict Instance => _selfCache;

        private static Dictionary<SmsSendEventType, SmsSendEventRule> _legitimateSmsSendEventRules
            = new Dictionary<SmsSendEventType, SmsSendEventRule> {
                {SmsSendEventType.Code, new SmsSendEventRule()},
                {SmsSendEventType.Message, new SmsSendEventRule()}
            };

        private SendCloudRestrict() : base(_legitimateSmsSendEventRules, Constants.MaxReceivers) { }
    }
}