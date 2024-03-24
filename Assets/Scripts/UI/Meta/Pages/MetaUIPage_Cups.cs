using UnityEngine;
using UnityEngine.UI;

public class MetaUIPage_Cups : MetaUIPageBase
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

		controller.BackButton.Request(this);
		controller.BackButton.OnClick += OnBack;
	}

	public override void Exit()
	{
		base.Exit();

		controller.PlayButton.RemoveRequester(this);
		controller.PlayButton.OnClick -= OnStartLevelClicked;

		controller.BackButton.RemoveRequester(this);
		controller.BackButton.OnClick -= OnBack;
	}

	private void OnStartLevelClicked()
	{
		GameManager.Instance.StartLevel(GameMode.Cup);
	}

	private void OnBack()
	{
		controller.SwitchPage<MetaUIPage_RacingModes>();
	}
}
