﻿namespace KonturEdi.Api.Types.Messages.BoxEvents
{
    public enum MessageBoxEventType
    {
        Unknown,
        NewOutboxMessage,
        NewInboxMessage,
        RecognizeMessage,
        NewOutboxDocument,
        MessageDelivered,
        MessageUndelivered,
        MessageReadByPartner,
        MessageCheckingOk,
        MessageCheckingFail,
        DraftOfDocumentPackagePostedIntoDiadoc,
        DraftOfDocumentPackageSignedByMe,
        DraftOfDocumentPackageSignedBySender,
        DraftOfDocumentPackageDeletedFromDiadoc,
        ReceivedDiadocRoamingError,
        NewInboxDocument,
        DiadocRevocationAccepted,
        DiadocRevocationAcceptedForBuyer,
        ProcessingTimesReport,
    }
}