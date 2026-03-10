using elevators.Application.ElevatorServices.MoveElevatorService;
using GitDemo.Application.Models;

namespace GitDemo.Application.MoveElevatorService;

public interface IMoveElevatorService
{
	public Task<ElevatorRequest> OperateElevator(MoveElevatorCommand command);
}