[GameMode(GameMode.HardLevel)]
public class CoreUIGameModeHandler_HardLevel : CoreUIGameModeHandlerBase
{
	public CoreUIGameModeHandler_HardLevel(CoreUIController controller) : base(controller)
	{
	}

	public override void Setup()
	{
		base.Setup();

		// start up sequence

		var greetingTexts = controller.GetView<UIViewGreetingTexts>();
		greetingTexts.SetVisible(true);
		greetingTexts.SetText("Hard Level");
	}

	public override void Exit()
	{
		base.Exit();
	}
}
