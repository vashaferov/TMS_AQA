namespace Pattern.Models;

public class Milestone
{
    public string MilestoneName { get; set; }
    public string References { get; set; }
    public string Parent { get; set; }
    public string Description { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public bool IsMilestoneCompleted { get; set; }
    public string PathFile { get; set; }
}