using System;

using SkbKontur.EdiApi.Client.Types.BoxEvents;

namespace SkbKontur.EdiApi.Client.Types.Messages.BoxEventsContents
{
    public class ProcessingTimesReportEventContent : IBoxEventContent
    {
        public string DocumentCirculationId { get; set; }
        public string SenderPartyId { get; set; }
        public string RecipientPartyId { get; set; }
        public string InitialMessageId { get; set; }
        public DocumentId InitialDocumentId { get; set; }
        public DocumentType DocumentType { get; set; }
        public DateTime DocumentCirculationStartTimestamp { get; set; }
        public DateTime DocumentCirculationCompletionTimestamp { get; set; }
        public ProcessingTimes ProcessingTimes { get; set; }
    }
}