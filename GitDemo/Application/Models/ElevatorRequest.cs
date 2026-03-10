namespace GitDemo.Application.Models;

public class ElevatorRequest
{
    public int ElevatorNumber { get; set; }
    public int MaxWeight { get; set; }
    public string Message { get; set; }
    public string Height { get; set; }
}