﻿namespace Tfs.WebHook.UnitTest
{
    internal class TestHook
    {
        public static readonly string BuildCompleted = @"{
  ""subscriptionId"": ""00000000-0000-0000-0000-000000000000"",
  ""notificationId"": 84,
  ""id"": ""4a5d99d6-1c75-4e53-91b9-ee80057d4ce3"",
  ""eventType"": ""build.complete"",
  ""publisherId"": ""tfs"",
  ""message"": {
    ""text"": ""Build ConsumerAddressModule_20150407.2 succeeded"",
    ""html"": ""Build <a href=\""https://fabrikam-fiber-inc.visualstudio.com/web/build.aspx?pcguid=5023c10b-bef3-41c3-bf53-686c4e34ee9e&amp;builduri=vstfs%3a%2f%2f%2fBuild%2fBuild%2f3\"">ConsumerAddressModule_20150407.2</a> succeeded"",
    ""markdown"": ""Build [ConsumerAddressModule_20150407.2](https://fabrikam-fiber-inc.visualstudio.com/web/build.aspx?pcguid=5023c10b-bef3-41c3-bf53-686c4e34ee9e&builduri=vstfs%3a%2f%2f%2fBuild%2fBuild%2f3) succeeded""
  },
  ""detailedMessage"": {
    ""text"": ""Build ConsumerAddressModule_20150407.2 succeeded"",
    ""html"": ""Build <a href=\""https://fabrikam-fiber-inc.visualstudio.com/web/build.aspx?pcguid=5023c10b-bef3-41c3-bf53-686c4e34ee9e&amp;builduri=vstfs%3a%2f%2f%2fBuild%2fBuild%2f3\"">ConsumerAddressModule_20150407.2</a> succeeded"",
    ""markdown"": ""Build [ConsumerAddressModule_20150407.2](https://fabrikam-fiber-inc.visualstudio.com/web/build.aspx?pcguid=5023c10b-bef3-41c3-bf53-686c4e34ee9e&builduri=vstfs%3a%2f%2f%2fBuild%2fBuild%2f3) succeeded""
  },
  ""resource"": {
    ""uri"": ""vstfs:///Build/Build/2"",
    ""id"": 2,
    ""buildNumber"": ""ConsumerAddressModule_20150407.1"",
    ""url"": ""https://fabrikam-fiber-inc.visualstudio.com/DefaultCollection/71777fbc-1cf2-4bd1-9540-128c1c71f766/_apis/build/Builds/2"",
    ""startTime"": ""2015-04-07T18:04:06.83Z"",
    ""finishTime"": ""2015-04-07T18:06:10.69Z"",
    ""reason"": ""manual"",
    ""status"": ""succeeded"",
    ""dropLocation"": ""#/3/drop"",
    ""drop"": {
      ""location"": ""#/3/drop"",
      ""type"": ""container"",
      ""url"": ""https://fabrikam-fiber-inc.visualstudio.com/DefaultCollection/_apis/resources/Containers/3/drop"",
      ""downloadUrl"": ""https://fabrikam-fiber-inc.visualstudio.com/DefaultCollection/_apis/resources/Containers/3/drop?api-version=1.0&$format=zip&downloadFileName=ConsumerAddressModule_20150407.1_drop""
    },
    ""log"": {
      ""type"": ""container"",
      ""url"": ""https://fabrikam-fiber-inc.visualstudio.com/DefaultCollection/_apis/resources/Containers/3/logs"",
      ""downloadUrl"": ""https://fabrikam-fiber-inc.visualstudio.com/_apis/resources/Containers/3/logs?api-version=1.0&$format=zip&downloadFileName=ConsumerAddressModule_20150407.1_logs""
    },
    ""sourceGetVersion"": ""LG:refs/heads/master:600c52d2d5b655caa111abfd863e5a9bd304bb0e"",
    ""lastChangedBy"": {
      ""displayName"": ""Normal Paulk"",
      ""url"": ""https://fabrikam-fiber-inc.visualstudio.com/_apis/Identities/d6245f20-2af8-44f4-9451-8107cb2767db"",
      ""id"": ""d6245f20-2af8-44f4-9451-8107cb2767db"",
      ""uniqueName"": ""fabrikamfiber16@hotmail.com"",
      ""imageUrl"": ""https://fabrikam-fiber-inc.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=d6245f20-2af8-44f4-9451-8107cb2767db""
    },
    ""retainIndefinitely"": false,
    ""hasDiagnostics"": true,
    ""definition"": {
      ""batchSize"": 1,
      ""triggerType"": ""none"",
      ""definitionType"": ""xaml"",
      ""id"": 2,
      ""name"": ""ConsumerAddressModule"",
      ""url"": ""https://fabrikam-fiber-inc.visualstudio.com/DefaultCollection/71777fbc-1cf2-4bd1-9540-128c1c71f766/_apis/build/Definitions/2""
    },
    ""queue"": {
      ""queueType"": ""buildController"",
      ""id"": 4,
      ""name"": ""Hosted Build Controller"",
      ""url"": ""https://fabrikam-fiber-inc.visualstudio.com/DefaultCollection/_apis/build/Queues/4""
    },
    ""requests"": [
      {
        ""id"": 1,
        ""url"": ""https://fabrikam-fiber-inc.visualstudio.com/DefaultCollection/71777fbc-1cf2-4bd1-9540-128c1c71f766/_apis/build/Requests/1"",
        ""requestedFor"": {
          ""displayName"": ""Normal Paulk"",
          ""url"": ""https://fabrikam-fiber-inc.visualstudio.com/_apis/Identities/d6245f20-2af8-44f4-9451-8107cb2767db"",
          ""id"": ""d6245f20-2af8-44f4-9451-8107cb2767db"",
          ""uniqueName"": ""fabrikamfiber16@hotmail.com"",
          ""imageUrl"": ""https://fabrikam-fiber-inc.visualstudio.com/DefaultCollection/_api/_common/identityImage?id=d6245f20-2af8-44f4-9451-8107cb2767db""
        }
      }
    ]
  },
  ""resourceVersion"": ""1.0"",
  ""resourceContainers"": {
    ""collection"": {
      ""id"": ""c12d0eb8-e382-443b-9f9c-c52cba5014c2""
    },
    ""account"": {
      ""id"": ""f844ec47-a9db-4511-8281-8b63f4eaf94e""
    },
    ""project"": {
      ""id"": ""be9b3917-87e6-42a4-a549-2bc06a7a878f""
    }
  },
  ""createdDate"": ""2018-09-18T01:33:54.9325308Z""
}
";
    }
}