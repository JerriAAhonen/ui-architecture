using UnityEngine;
using UnityEngine.UI;

public class MetaUIPage_RacingModes : MetaUIPageBase
{
	[SerializeField] private Button cupsButton;
	[SerializeField] private Button tournamentsButton;

	public override void Init(MetaUIController controller)
	{
		base.Init(controller);
		cupsButton.onClick.AddListener(OnCups);
		tournamentsButton.onClick.AddListener(OnTournaments);
	}

	public override void Enter()
	{
		base.Enter();
	}

	public override void Exit()
	{
		base.Exit();
	}

	public void OnCups()
	{
		controller.SwitchPage<MetaUIPage_Cups>();
	}

	public void OnTournaments()
	{
		controller.SwitchPage<MetaUIPage_Tournaments>();
	}
}
