using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoreUIController : MonoBehaviour
{
	[SerializeField] private Button buttonBack; // TODO This should be in a EndScreen view instead of in this controller

	private Dictionary<Type, Component> views;
	private CoreUIGameModeHandlerBase currentHandler;

	public void Init()
	{
		views = TypeUtil.GetDerivedTypesAndInstances<CoreUIViewBase>(gameObject);

		foreach (var (type, instance) in views)
		{
			if (instance is CoreUIViewBase view)
				view.SetVisible(false);
		}

		buttonBack.onClick.AddListener(OnBack);
	}

	public void SetVisible(bool visible)
	{
		gameObject.SetActive(visible);
	}

	public void SetupGameMode(GameMode gameMode)
	{
		currentHandler = CoreUIHandlerFactory.CreateInstance(gameMode, this) as CoreUIGameModeHandlerBase;
		currentHandler.Setup();
	}

	public T GetView<T>() where T : Component => TypeUtil.GetInstanceOfType<T>(views);

	// TODO This should be in a EndScreen view instead of in this controller
	public void OnBack()
	{
		HideAll();
		GameManager.Instance.OpenMenu();
	}

	private void HideAll()
	{
		foreach (var (_, instance) in views)
			if (instance is CoreUIViewBase view)
				view.SetVisible(false);
	}
}
