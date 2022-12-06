﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.App
{
    public class CheckNameWithQualResponse : SmartAppResponse<CheckNameWithQualResponseData>
    {
    }

    public class CheckNameWithQualResponseData
    {
        [Newtonsoft.Json.JsonProperty("checkResult")]
        [System.Text.Json.Serialization.JsonPropertyName("checkResult")]
        public int CheckResult { get; set; }
    }
}
