using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Trunking.V1.Trunk 
{

    /// <summary>
    /// FetchOriginationUrlOptions
    /// </summary>
    public class FetchOriginationUrlOptions : IOptions<OriginationUrlResource> 
    {
        /// <summary>
        /// The trunk_sid
        /// </summary>
        public string PathTrunkSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchOriginationUrlOptions
        /// </summary>
        ///
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchOriginationUrlOptions(string pathTrunkSid, string pathSid)
        {
            PathTrunkSid = pathTrunkSid;
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
    /// DeleteOriginationUrlOptions
    /// </summary>
    public class DeleteOriginationUrlOptions : IOptions<OriginationUrlResource> 
    {
        /// <summary>
        /// The trunk_sid
        /// </summary>
        public string PathTrunkSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteOriginationUrlOptions
        /// </summary>
        ///
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="pathSid"> The sid </param>
        public DeleteOriginationUrlOptions(string pathTrunkSid, string pathSid)
        {
            PathTrunkSid = pathTrunkSid;
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
    /// CreateOriginationUrlOptions
    /// </summary>
    public class CreateOriginationUrlOptions : IOptions<OriginationUrlResource> 
    {
        /// <summary>
        /// The trunk_sid
        /// </summary>
        public string PathTrunkSid { get; }
        /// <summary>
        /// The weight
        /// </summary>
        public int? Weight { get; }
        /// <summary>
        /// The priority
        /// </summary>
        public int? Priority { get; }
        /// <summary>
        /// The enabled
        /// </summary>
        public bool? Enabled { get; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// The sip_url
        /// </summary>
        public Uri SipUrl { get; }

        /// <summary>
        /// Construct a new CreateOriginationUrlOptions
        /// </summary>
        ///
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="weight"> The weight </param>
        /// <param name="priority"> The priority </param>
        /// <param name="enabled"> The enabled </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="sipUrl"> The sip_url </param>
        public CreateOriginationUrlOptions(string pathTrunkSid, int? weight, int? priority, bool? enabled, string friendlyName, Uri sipUrl)
        {
            PathTrunkSid = pathTrunkSid;
            Weight = weight;
            Priority = priority;
            Enabled = enabled;
            FriendlyName = friendlyName;
            SipUrl = sipUrl;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Weight != null)
            {
                p.Add(new KeyValuePair<string, string>("Weight", Weight.Value.ToString()));
            }

            if (Priority != null)
            {
                p.Add(new KeyValuePair<string, string>("Priority", Priority.Value.ToString()));
            }

            if (Enabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Enabled", Enabled.Value.ToString()));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (SipUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("SipUrl", SipUrl.AbsoluteUri));
            }

            return p;
        }
    }

    /// <summary>
    /// ReadOriginationUrlOptions
    /// </summary>
    public class ReadOriginationUrlOptions : ReadOptions<OriginationUrlResource> 
    {
        /// <summary>
        /// The trunk_sid
        /// </summary>
        public string PathTrunkSid { get; }

        /// <summary>
        /// Construct a new ReadOriginationUrlOptions
        /// </summary>
        ///
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        public ReadOriginationUrlOptions(string pathTrunkSid)
        {
            PathTrunkSid = pathTrunkSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// UpdateOriginationUrlOptions
    /// </summary>
    public class UpdateOriginationUrlOptions : IOptions<OriginationUrlResource> 
    {
        /// <summary>
        /// The trunk_sid
        /// </summary>
        public string PathTrunkSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The weight
        /// </summary>
        public int? Weight { get; set; }
        /// <summary>
        /// The priority
        /// </summary>
        public int? Priority { get; set; }
        /// <summary>
        /// The enabled
        /// </summary>
        public bool? Enabled { get; set; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The sip_url
        /// </summary>
        public Uri SipUrl { get; set; }

        /// <summary>
        /// Construct a new UpdateOriginationUrlOptions
        /// </summary>
        ///
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="pathSid"> The sid </param>
        public UpdateOriginationUrlOptions(string pathTrunkSid, string pathSid)
        {
            PathTrunkSid = pathTrunkSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Weight != null)
            {
                p.Add(new KeyValuePair<string, string>("Weight", Weight.Value.ToString()));
            }

            if (Priority != null)
            {
                p.Add(new KeyValuePair<string, string>("Priority", Priority.Value.ToString()));
            }

            if (Enabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Enabled", Enabled.Value.ToString()));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (SipUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("SipUrl", SipUrl.AbsoluteUri));
            }

            return p;
        }
    }

}