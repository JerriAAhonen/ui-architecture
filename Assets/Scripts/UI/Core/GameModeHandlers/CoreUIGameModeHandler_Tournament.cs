[GameMode(GameMode.Tournament)]
public class CoreUIGameModeHandler_Tournament : CoreUIGameModeHandlerBase
{
	public CoreUIGameModeHandler_Tournament(CoreUIController controller) : base(controller)
	{
	}

	public override void Setup()
	{
		base.Setup();

		// start up sequence

		var carControls = controller.GetView<UIViewCarControls>();
		carControls.SetVisible(true);

		var greetingTexts = controller.GetView<UIViewGreetingTexts>();
		greetingTexts.SetVisible(true);
		greetingTexts.SetText("tournament");
	}
}
