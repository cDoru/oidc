﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenIdConnectServer.ViewModels.AuthorizationViewModels
{
    public class DeviceCodeFlowViewModel
    {
        [JsonProperty("verification_uri")]
        public string VerificationUri { get; set; }

        [JsonProperty("user_code")]
        public string UserCode { get; set; }

        [JsonProperty("device_code")]
        public string DeviceCode { get; set; }

        [JsonProperty("interval")]
        public int Interval { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }
    }
}
