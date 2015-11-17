﻿using System;

using KonturEdi.Api.Types.Common;
using KonturEdi.Api.Types.Messages;
using KonturEdi.Api.Types.Messages.BoxEvents;

namespace KonturEdi.Api.Client
{
    public interface IMessagesEdiApiClient : IBaseEdiApiClient
    {
        BoxDocumentsSettings GetBoxDocumentsSettings(string authToken, string boxId);
        MessageData GetMessage(string authToken, string boxId, string messageId);
        InboxMessageMeta GetInboxMessageMeta(string authToken, string boxId, string messageId);
        OutboxMessageMeta GetOutboxMessageMeta(string authToken, string boxId, string messageId);
        OutboxMessageMeta SendMessage(string authToken, string boxId, MessageData messageData);
        MessageBoxEventBatch GetEvents(string authToken, string boxId, string exclusiveEventId, uint? count = null);
        MessageBoxEventBatch GetEvents(string authToken, string boxId, DateTime fromDateTime, uint? count = null);
    }
}