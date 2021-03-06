using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Video.V1.Room 
{

    /// <summary>
    /// RoomRecordingResource
    /// </summary>
    public class RoomRecordingResource : Resource 
    {
        public sealed class StatusEnum : StringEnum 
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}

            public static readonly StatusEnum Processing = new StatusEnum("processing");
            public static readonly StatusEnum Completed = new StatusEnum("completed");
            public static readonly StatusEnum Deleted = new StatusEnum("deleted");
            public static readonly StatusEnum Failed = new StatusEnum("failed");
        }

        public sealed class TypeEnum : StringEnum 
        {
            private TypeEnum(string value) : base(value) {}
            public TypeEnum() {}

            public static readonly TypeEnum Audio = new TypeEnum("audio");
            public static readonly TypeEnum Video = new TypeEnum("video");
            public static readonly TypeEnum Data = new TypeEnum("data");
        }

        public sealed class FormatEnum : StringEnum 
        {
            private FormatEnum(string value) : base(value) {}
            public FormatEnum() {}

            public static readonly FormatEnum Mka = new FormatEnum("mka");
            public static readonly FormatEnum Mkv = new FormatEnum("mkv");
        }

        public sealed class CodecEnum : StringEnum 
        {
            private CodecEnum(string value) : base(value) {}
            public CodecEnum() {}

            public static readonly CodecEnum Vp8 = new CodecEnum("VP8");
            public static readonly CodecEnum H264 = new CodecEnum("H264");
            public static readonly CodecEnum Opus = new CodecEnum("OPUS");
            public static readonly CodecEnum Pcmu = new CodecEnum("PCMU");
        }

        private static Request BuildFetchRequest(FetchRoomRecordingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Video,
                "/v1/Rooms/" + options.PathRoomSid + "/Recordings/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch RoomRecording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RoomRecording </returns> 
        public static RoomRecordingResource Fetch(FetchRoomRecordingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch RoomRecording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RoomRecording </returns> 
        public static async System.Threading.Tasks.Task<RoomRecordingResource> FetchAsync(FetchRoomRecordingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathRoomSid"> The room_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RoomRecording </returns> 
        public static RoomRecordingResource Fetch(string pathRoomSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchRoomRecordingOptions(pathRoomSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathRoomSid"> The room_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RoomRecording </returns> 
        public static async System.Threading.Tasks.Task<RoomRecordingResource> FetchAsync(string pathRoomSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchRoomRecordingOptions(pathRoomSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadRoomRecordingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Video,
                "/v1/Rooms/" + options.PathRoomSid + "/Recordings",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read RoomRecording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RoomRecording </returns> 
        public static ResourceSet<RoomRecordingResource> Read(ReadRoomRecordingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<RoomRecordingResource>.FromJson("recordings", response.Content);
            return new ResourceSet<RoomRecordingResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read RoomRecording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RoomRecording </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<RoomRecordingResource>> ReadAsync(ReadRoomRecordingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<RoomRecordingResource>.FromJson("recordings", response.Content);
            return new ResourceSet<RoomRecordingResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pathRoomSid"> The room_sid </param>
        /// <param name="status"> The status </param>
        /// <param name="sourceSid"> The source_sid </param>
        /// <param name="dateCreatedAfter"> The date_created_after </param>
        /// <param name="dateCreatedBefore"> The date_created_before </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of RoomRecording </returns> 
        public static ResourceSet<RoomRecordingResource> Read(string pathRoomSid, RoomRecordingResource.StatusEnum status = null, string sourceSid = null, DateTime? dateCreatedAfter = null, DateTime? dateCreatedBefore = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadRoomRecordingOptions(pathRoomSid){Status = status, SourceSid = sourceSid, DateCreatedAfter = dateCreatedAfter, DateCreatedBefore = dateCreatedBefore, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pathRoomSid"> The room_sid </param>
        /// <param name="status"> The status </param>
        /// <param name="sourceSid"> The source_sid </param>
        /// <param name="dateCreatedAfter"> The date_created_after </param>
        /// <param name="dateCreatedBefore"> The date_created_before </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of RoomRecording </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<RoomRecordingResource>> ReadAsync(string pathRoomSid, RoomRecordingResource.StatusEnum status = null, string sourceSid = null, DateTime? dateCreatedAfter = null, DateTime? dateCreatedBefore = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadRoomRecordingOptions(pathRoomSid){Status = status, SourceSid = sourceSid, DateCreatedAfter = dateCreatedAfter, DateCreatedBefore = dateCreatedBefore, PageSize = pageSize, Limit = limit};
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
        public static Page<RoomRecordingResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<RoomRecordingResource>.FromJson("recordings", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<RoomRecordingResource> NextPage(Page<RoomRecordingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Video,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<RoomRecordingResource>.FromJson("recordings", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<RoomRecordingResource> PreviousPage(Page<RoomRecordingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Video,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<RoomRecordingResource>.FromJson("recordings", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a RoomRecordingResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> RoomRecordingResource object represented by the provided JSON </returns> 
        public static RoomRecordingResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<RoomRecordingResource>(json);
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
        /// The status
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RoomRecordingResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The source_sid
        /// </summary>
        [JsonProperty("source_sid")]
        public string SourceSid { get; private set; }
        /// <summary>
        /// The size
        /// </summary>
        [JsonProperty("size")]
        public int? Size { get; private set; }
        /// <summary>
        /// The type
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RoomRecordingResource.TypeEnum Type { get; private set; }
        /// <summary>
        /// The duration
        /// </summary>
        [JsonProperty("duration")]
        public int? Duration { get; private set; }
        /// <summary>
        /// The container_format
        /// </summary>
        [JsonProperty("container_format")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RoomRecordingResource.FormatEnum ContainerFormat { get; private set; }
        /// <summary>
        /// The codec
        /// </summary>
        [JsonProperty("codec")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RoomRecordingResource.CodecEnum Codec { get; private set; }
        /// <summary>
        /// The grouping_sids
        /// </summary>
        [JsonProperty("grouping_sids")]
        public object GroupingSids { get; private set; }
        /// <summary>
        /// The room_sid
        /// </summary>
        [JsonProperty("room_sid")]
        public string RoomSid { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private RoomRecordingResource()
        {

        }
    }

}