using System;
using UnityEngine;
using UnityEngine.UI;

public class MetaUINavigationSideBar : MonoBehaviour
{
	[SerializeField] private Button normalLevelsButton;
	[SerializeField] private Button hardLevelsButton;
	[SerializeField] private Button racingModesButton;
	[SerializeField] private Button endlessLevelsButton;

	private MetaUIController controller;

	public void Init(MetaUIController controller)
	{
		this.controller = controller;
		normalLevelsButton.onClick.AddListener(OnNormalLevels);
		hardLevelsButton.onClick.AddListener(OnHardLevels);
		racingModesButton.onClick.AddListener(OnRacingModes);
		endlessLevelsButton.onClick.AddListener(OnEndless);
	}

	private void OnNormalLevels()
	{
		controller.SwitchPage<MetaUIPage_NormalLevels>();
	}

	private void OnHardLevels()
	{
		controller.SwitchPage<MetaUIPage_HardLevels>();
	}

	private void OnRacingModes()
	{
		controller.SwitchPage<MetaUIPage_RacingModes>();
	}

	private void OnEndless()
	{
		controller.SwitchPage<MetaUIPage_Endless>();
	}
}
