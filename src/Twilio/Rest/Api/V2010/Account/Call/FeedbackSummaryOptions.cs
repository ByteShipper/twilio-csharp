using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Api.V2010.Account.Call 
{

    /// <summary>
    /// CreateFeedbackSummaryOptions
    /// </summary>
    public class CreateFeedbackSummaryOptions : IOptions<FeedbackSummaryResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The start_date
        /// </summary>
        public DateTime? StartDate { get; }
        /// <summary>
        /// The end_date
        /// </summary>
        public DateTime? EndDate { get; }
        /// <summary>
        /// The include_subaccounts
        /// </summary>
        public bool? IncludeSubaccounts { get; set; }
        /// <summary>
        /// The status_callback
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// The status_callback_method
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }

        /// <summary>
        /// Construct a new CreateFeedbackSummaryOptions
        /// </summary>
        ///
        /// <param name="startDate"> The start_date </param>
        /// <param name="endDate"> The end_date </param>
        public CreateFeedbackSummaryOptions(DateTime? startDate, DateTime? endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (StartDate != null)
            {
                p.Add(new KeyValuePair<string, string>("StartDate", StartDate.Value.ToString("yyyy-MM-dd")));
            }

            if (EndDate != null)
            {
                p.Add(new KeyValuePair<string, string>("EndDate", EndDate.Value.ToString("yyyy-MM-dd")));
            }

            if (IncludeSubaccounts != null)
            {
                p.Add(new KeyValuePair<string, string>("IncludeSubaccounts", IncludeSubaccounts.Value.ToString()));
            }

            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", StatusCallback.AbsoluteUri));
            }

            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// FetchFeedbackSummaryOptions
    /// </summary>
    public class FetchFeedbackSummaryOptions : IOptions<FeedbackSummaryResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchFeedbackSummaryOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public FetchFeedbackSummaryOptions(string pathSid)
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
    /// DeleteFeedbackSummaryOptions
    /// </summary>
    public class DeleteFeedbackSummaryOptions : IOptions<FeedbackSummaryResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteFeedbackSummaryOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public DeleteFeedbackSummaryOptions(string pathSid)
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