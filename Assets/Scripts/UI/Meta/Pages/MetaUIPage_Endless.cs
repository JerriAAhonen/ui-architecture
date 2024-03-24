using UnityEngine;
using UnityEngine.UI;

public class MetaUIPage_Endless : MetaUIPageBase
{
	public override void Init(MetaUIController controller)
	{
		base.Init(controller);
	}

	public override void Enter()
	{
		base.Enter();

		controller.PlayButton.Request(this);
		controller.PlayButton.OnClick += OnStartLevelClicked;
	}

	public override void Exit()
	{
		base.Exit();

		controller.PlayButton.RemoveRequester(this);
		controller.PlayButton.OnClick -= OnStartLevelClicked;
	}

	private void OnStartLevelClicked()
	{
		GameManager.Instance.StartLevel(GameMode.Endless);
	}
}
