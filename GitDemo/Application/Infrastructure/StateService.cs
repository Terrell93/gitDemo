using GitDemo.Application.Infrastructure.Interfaces;
using GitDemo.Application.Models;

namespace GitDemo.Application.Infrastructure;

public class StateService(ISaveCurrentStateService saveState, ILoadCurrentStateService loadState)
	: IStateService
{
	private readonly ISaveCurrentStateService _saveState = saveState ?? throw new ArgumentNullException(nameof(saveState));
	private readonly ILoadCurrentStateService _loadState = loadState ?? throw new ArgumentNullException(nameof(loadState));

	Task<bool> IStateService.SaveState(Elevator elevator)
	{
		return SaveState(elevator);
	}

	public void CreateInitialState(int numberOfElevators)
	{
		var elevators = InitCreateElevators(numberOfElevators);
		foreach (var elevator in elevators.Result)
		{
			SaveState(elevator);
		}
	}

	public Task<IEnumerable<Elevator>> LoadElevators()
	{
		return _loadState.LoadState();
	}

	Task<Elevator> IStateService.ReturnElevator(int number)
	{
		return ReturnElevator(number);
	}

	Task<IEnumerable<Elevator>> IStateService.LoadElevators()
	{
		return LoadElevators();
	}

	private Task<Elevator> ReturnElevator(int number)
	{
		var fileName = $"elevator_{number}_state.txt";
		var elevator = _loadState.FindElevator(fileName, number);
		return Task.FromResult(elevator.Result);
	}

	public Task<bool> SaveState(Elevator elevator)
	{
		bool successfulSave;
		try
		{
			_saveState.SaveState(elevator);
			successfulSave = true;
		}
		catch (Exception e)
		{
			throw new Exception(e.Message);
		}

		return Task.FromResult(successfulSave);
	}

	private static Task<List<Elevator>> InitCreateElevators(int numberOfElevators)
	{
		var elevators = new List<Elevator>();
		for (var i = 1; i < numberOfElevators + 1; i++) {
			elevators.Add(new Elevator(i));
		}

		return Task.FromResult(elevators);
	}
}