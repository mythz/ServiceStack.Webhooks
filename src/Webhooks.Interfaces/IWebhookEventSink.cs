﻿using System.Collections.Generic;

namespace ServiceStack.Webhooks
{
    public interface IWebhookEventSink
    {
        /// <summary>
        ///     Writes a new event with data
        /// </summary>
        void Write(string eventName, Dictionary<string, string> data);
    }
}