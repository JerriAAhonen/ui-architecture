using System;
using System.Linq;

public static class CoreUIHandlerFactory
{
	public static object CreateInstance(GameMode mode, CoreUIController controller)
	{
		var type = typeof(CoreUIHandlerFactory).Assembly.GetTypes()
			.FirstOrDefault(t => t.GetCustomAttributes(typeof(GameModeAttribute), false)
			.OfType<GameModeAttribute>()
			.Any(attr => attr.Mode == mode));

		if (type == null)
			throw new InvalidOperationException($"No class found for GameMode: {mode}");

		return Activator.CreateInstance(type, new object[] { controller });
	}
}
