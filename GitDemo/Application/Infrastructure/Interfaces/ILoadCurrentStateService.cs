using GitDemo.Application.Models;

namespace GitDemo.Application.Infrastructure.Interfaces;

public interface ILoadCurrentStateService
{
	Task<IEnumerable<Elevator>> LoadState();
	Task<Elevator> FindElevator(string fileName, int number);
}