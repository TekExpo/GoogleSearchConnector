

using Newtonsoft.Json;

namespace GoogleDriveSearchConnector.Models
{
    public class Acl {
      [JsonProperty]
      public const string IdentitySource = "Azure Active Directory";
      public string AccessType { get; set; }
      public string Type { get; set; }
      public string Value { get; set; }
    }
}