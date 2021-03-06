using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Chat.V2.Service.User 
{

    /// <summary>
    /// UserChannelResource
    /// </summary>
    public class UserChannelResource : Resource 
    {
        public sealed class ChannelStatusEnum : StringEnum 
        {
            private ChannelStatusEnum(string value) : base(value) {}
            public ChannelStatusEnum() {}

            public static readonly ChannelStatusEnum Joined = new ChannelStatusEnum("joined");
            public static readonly ChannelStatusEnum Invited = new ChannelStatusEnum("invited");
            public static readonly ChannelStatusEnum NotParticipating = new ChannelStatusEnum("not_participating");
        }

        private static Request BuildReadRequest(ReadUserChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Chat,
                "/v2/Services/" + options.PathServiceSid + "/Users/" + options.PathUserSid + "/Channels",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read UserChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserChannel </returns> 
        public static ResourceSet<UserChannelResource> Read(ReadUserChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<UserChannelResource>.FromJson("channels", response.Content);
            return new ResourceSet<UserChannelResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read UserChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserChannel </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<UserChannelResource>> ReadAsync(ReadUserChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<UserChannelResource>.FromJson("channels", response.Content);
            return new ResourceSet<UserChannelResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathUserSid"> The user_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserChannel </returns> 
        public static ResourceSet<UserChannelResource> Read(string pathServiceSid, string pathUserSid, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadUserChannelOptions(pathServiceSid, pathUserSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathUserSid"> The user_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserChannel </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<UserChannelResource>> ReadAsync(string pathServiceSid, string pathUserSid, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadUserChannelOptions(pathServiceSid, pathUserSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        ///
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<UserChannelResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<UserChannelResource>.FromJson("channels", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<UserChannelResource> NextPage(Page<UserChannelResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Chat,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<UserChannelResource>.FromJson("channels", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<UserChannelResource> PreviousPage(Page<UserChannelResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Chat,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<UserChannelResource>.FromJson("channels", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a UserChannelResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> UserChannelResource object represented by the provided JSON </returns> 
        public static UserChannelResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<UserChannelResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The service_sid
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// The channel_sid
        /// </summary>
        [JsonProperty("channel_sid")]
        public string ChannelSid { get; private set; }
        /// <summary>
        /// The member_sid
        /// </summary>
        [JsonProperty("member_sid")]
        public string MemberSid { get; private set; }
        /// <summary>
        /// The status
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public UserChannelResource.ChannelStatusEnum Status { get; private set; }
        /// <summary>
        /// The last_consumed_message_index
        /// </summary>
        [JsonProperty("last_consumed_message_index")]
        public int? LastConsumedMessageIndex { get; private set; }
        /// <summary>
        /// The unread_messages_count
        /// </summary>
        [JsonProperty("unread_messages_count")]
        public int? UnreadMessagesCount { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private UserChannelResource()
        {

        }
    }

}