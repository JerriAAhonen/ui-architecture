using System;

public class GameModeAttribute : Attribute
{
	public GameMode Mode { get; }

	public GameModeAttribute(GameMode mode)
	{
		Mode = mode;
	}
}
