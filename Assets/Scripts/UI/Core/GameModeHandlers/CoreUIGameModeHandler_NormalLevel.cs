[GameMode(GameMode.NormalLevel)]
public class CoreUIGameModeHandler_NormalLevel : CoreUIGameModeHandlerBase
{
	public CoreUIGameModeHandler_NormalLevel(CoreUIController controller) : base(controller)
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
		greetingTexts.SetText("Normal Level");
	}

	public override void Exit()
	{
		base.Exit();
	}
}
