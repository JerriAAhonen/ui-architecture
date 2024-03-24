[GameMode(GameMode.Cup)]
public class CoreUIGameModeHandler_Cup : CoreUIGameModeHandlerBase
{
	public CoreUIGameModeHandler_Cup(CoreUIController controller) : base(controller)
	{
	}

	public override void Setup()
	{
		base.Setup();

		// start up sequence

		var greetingTexts = controller.GetView<UIViewGreetingTexts>();
		greetingTexts.SetVisible(true);
		greetingTexts.SetText("Cup");
	}

	public override void Exit()
	{
		base.Exit();
	}
}
