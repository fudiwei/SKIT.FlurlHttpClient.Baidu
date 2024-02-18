namespace SKIT.FlurlHttpClient.Baidu.Push.Models
{
    /// <summary>
    /// <para>表示 [POST] /push/all 接口的请求。</para>
    /// </summary>
    public class PushAllRequest : BaiduPushRequest
    {
        public static class Types
        {
            public class Message : PushSingleDeviceRequest.Types.Message
            {
            }
        }

        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_type")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_type")]
        public int? MessageType { get; set; }

        /// <summary>
        /// 获取或设置消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public Types.Message? Message { get; set; }

        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extra_msg_type")]
        [System.Text.Json.Serialization.JsonPropertyName("extra_msg_type")]
        public int? ExtraMessageType { get; set; }

        /// <summary>
        /// 获取或设置消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extra_msg")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("extra_msg")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public Types.Message? ExtraMessage { get; set; }

        /// <summary>
        /// 获取或设置消息有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_expires")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_expires")]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// 获取或设置 iOS 应用部署状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deploy_status")]
        [System.Text.Json.Serialization.JsonPropertyName("deploy_status")]
        public int? DeployStatus { get; set; }

        /// <summary>
        /// 获取或设置通道类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_type")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_type")]
        public int? ChannelType { get; set; }
    }
}