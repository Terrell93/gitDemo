namespace GitDemo.Application.Models;

public class Elevator(int number)
{
    public int Number { get; set; } = number + 1;
    public bool Open { get; set; } = false;
    public int CurrentFloor { get; set; } = 1;
    public int TargetFloor { get; set; }
    public int MaxWeight { get; set; } = 600;
    public bool Busy { get; set; } = false;
    public string StatusMessage { get; set; } = "";
    public string Age { get; set; } = "";
    public string Height { get; set; } = "";
}