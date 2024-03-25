using System.Text.Json.Serialization;

namespace NativeSingleton.Models.Homework;

public class Project
{
    [JsonPropertyName("name")] public string ProjectName { get; set; }
    [JsonPropertyName("id")] public int ID { get; set; }
    [JsonPropertyName("announcement")] public string Announcement { get; set; }
    [JsonPropertyName("show_announcement")] public bool IsShowAnnouncement  { get; set; }
    [JsonPropertyName("is_completed")] public bool IsCompleted { get; set; }
    [JsonPropertyName("completed_on")] public int CompletedOn { get; set; }
    [JsonPropertyName("suite_mode")] public int SuiteMode { get; set; }
    [JsonPropertyName("default_role_id")] public int DefaultRoleId { get; set; }
    [JsonPropertyName("case_statuses_enabled")] public bool IsCaseStatusesEnabled { get; set; }
    [JsonPropertyName("url")] public string URL { get; set; }
    [JsonPropertyName("users")] public Uesr[] Users { get; set; }
    [JsonPropertyName("groups")] public Group[] Groups { get; set; }

    public class Uesr
    {
        [JsonPropertyName("id")] public int ID { get; set; }
        [JsonPropertyName("global_role_id")] public int GlobalRoleId { get; set; }
        [JsonPropertyName("global_role")] public string GlobalRole { get; set; }
        [JsonPropertyName("project_role_id")] public int ProjectRoleId { get; set; }
        [JsonPropertyName("project_role")] public string ProjectRole { get; set; }
    }
    
    public class Group
    {
        [JsonPropertyName("id")] public int ID { get; set; }
        [JsonPropertyName("role_id")] public int RoleId { get; set; }
        [JsonPropertyName("role")] public string Role { get; set; }
    }
}