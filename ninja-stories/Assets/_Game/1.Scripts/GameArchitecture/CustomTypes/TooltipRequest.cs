/// <summary>
/// 
/// </summary>
[System.Serializable]
public class TooltipRequest
{
    public string title;
    public string description;

    public TooltipRequest(string title, string description)
    {
        this.title = title;
        this.description = description;
    }
}