using UnityEngine;
using UnityEngine.UI;

public class MetaUIPage_Endless : MetaUIPageBase
{
	[SerializeField] private Button startLevelButton;

	public override void Init(MetaUIController controller)
	{
		base.Init(controller);
		startLevelButton.onClick.AddListener(OnStartLevelClicked);
	}

	public override void Enter()
	{
		base.Enter();
	}

	public override void Exit()
	{
		base.Exit();
	}

	private void OnStartLevelClicked()
	{
		GameManager.Instance.StartLevel(GameMode.Endless);
	}
}
