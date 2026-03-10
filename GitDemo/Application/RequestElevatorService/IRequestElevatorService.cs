using elevators.Application.ElevatorServices.RequestElevatorService;
using GitDemo.Application.Models;

namespace GitDemo.Application.RequestElevatorService;

public interface IRequestElevatorService
{
	public Task<ElevatorRequest> ReturnElevator(RequestElevatorCommand request);
}