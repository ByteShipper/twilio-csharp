using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Video.V1 
{

    /// <summary>
    /// FetchRecordingOptions
    /// </summary>
    public class FetchRecordingOptions : IOptions<RecordingResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchRecordingOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public FetchRecordingOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// ReadRecordingOptions
    /// </summary>
    public class ReadRecordingOptions : ReadOptions<RecordingResource> 
    {
        /// <summary>
        /// The status
        /// </summary>
        public RecordingResource.StatusEnum Status { get; set; }
        /// <summary>
        /// The source_sid
        /// </summary>
        public string SourceSid { get; set; }
        /// <summary>
        /// The grouping_sid
        /// </summary>
        public List<string> GroupingSid { get; set; }
        /// <summary>
        /// The date_created_after
        /// </summary>
        public DateTime? DateCreatedAfter { get; set; }
        /// <summary>
        /// The date_created_before
        /// </summary>
        public DateTime? DateCreatedBefore { get; set; }

        /// <summary>
        /// Construct a new ReadRecordingOptions
        /// </summary>
        public ReadRecordingOptions()
        {
            GroupingSid = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            if (SourceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("SourceSid", SourceSid.ToString()));
            }

            if (GroupingSid != null)
            {
                p.AddRange(GroupingSid.Select(prop => new KeyValuePair<string, string>("GroupingSid", prop.ToString())));
            }

            if (DateCreatedAfter != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedAfter", Serializers.DateTimeIso8601(DateCreatedAfter)));
            }

            if (DateCreatedBefore != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedBefore", Serializers.DateTimeIso8601(DateCreatedBefore)));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// DeleteRecordingOptions
    /// </summary>
    public class DeleteRecordingOptions : IOptions<RecordingResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteRecordingOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public DeleteRecordingOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}