namespace Pattern.Models;

public class Project
{
    public string ProjectName { get; set; }
    public string Announcement { get; set; }
    public bool ShowAnnouncementFlag { get; set; }
    public string ProjectType { get; set; }
    public bool EnableTestCaseApprovalsFlag { get; set; }
}