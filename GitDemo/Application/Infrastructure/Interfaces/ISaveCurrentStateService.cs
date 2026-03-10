using GitDemo.Application.Models;

namespace GitDemo.Application.Infrastructure.Interfaces;

public interface ISaveCurrentStateService
{
	void SaveState(Elevator elevator);
}