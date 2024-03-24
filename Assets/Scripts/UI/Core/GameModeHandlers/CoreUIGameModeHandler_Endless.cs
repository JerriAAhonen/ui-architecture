[GameMode(GameMode.Endless)]
public class CoreUIGameModeHandler_Endless : CoreUIGameModeHandlerBase
{
	public CoreUIGameModeHandler_Endless(CoreUIController controller) : base(controller)
	{
	}

	public override void Setup()
	{
		base.Setup();

		// start up sequence

		var greetingTexts = controller.GetView<UIViewGreetingTexts>();
		greetingTexts.SetVisible(true);
		greetingTexts.SetText("Endless");
	}

	public override void Exit()
	{
		base.Exit();
	}
}
