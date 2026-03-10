using GitDemo.Application.Models;

namespace GitDemo.Application.Infrastructure.Interfaces;

public interface IStateService
{
	public Task<IEnumerable<Elevator>> LoadElevators();
	public Task<Elevator> ReturnElevator(int number);
	public Task<bool> SaveState(Elevator elevator);
	public void CreateInitialState(int numberOfElevators);
}