using UnityEngine;

public abstract class CoreUIGameModeHandlerBase
{
	protected CoreUIController controller;

	public CoreUIGameModeHandlerBase(CoreUIController controller)
	{
		this.controller = controller;
	}

	public virtual void Setup()
	{
		Debug.Log($"[GameModeCoreUIHandlerBase] Setup: {this}");
	}

	public virtual void Exit()
	{
		Debug.Log($"[GameModeCoreUIHandlerBase] Exit: {this}");
	}
}
