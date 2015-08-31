using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace SlackIntegration
{
    //This class serializes into the Json payload required by Slack Incoming WebHooks
    public class Payload
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("icon_emoji")]
        public string IconEmoji { get; set; }

        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        public Payload()
        {
            Channel = "";
            Username = "";
            Text = "";
        }
        public Payload(string channel, string text)
        {
            Channel = channel;
            Text = text;
        }
        public Payload(string channel, string username, string text)
        {
            Channel = channel;
            Username = username;
            Text = text;
        }
    }
}
