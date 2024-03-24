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

	}

	public virtual void Exit()
	{

	}
}
