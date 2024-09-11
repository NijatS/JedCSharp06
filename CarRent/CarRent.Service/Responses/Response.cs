namespace CarRent.Responses;

public class Response
{
    public bool IsSuccess { get; set; }
    public object Item { get; set; }
    public ICollection<string> Errors { get; set; } = new List<string>();
}