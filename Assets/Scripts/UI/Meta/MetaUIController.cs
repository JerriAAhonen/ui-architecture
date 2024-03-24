using System;
using System.Collections.Generic;
using UnityEngine;

public class MetaUIController : MonoBehaviour
{
	[SerializeField] private MetaUINavigationSideBar sideMenu;

	private Dictionary<Type, Component> pages;
	private MetaUIPageBase currentPage;

	public void Init()
	{
		// Fetch all main menu pages and initialize them
		pages = TypeHelper.GetDerivedTypesAndInstances<MetaUIPageBase>(gameObject);
		foreach (var (type, instance) in pages)
		{
			// Perform operations with the type and instance
			Debug.Log($"Type: {type.Name}, Instance: {instance.name}");

			if (instance is MetaUIPageBase view)
			{
				view.Init(this);
			}
		}

		// Initialize side bar navigation
		sideMenu.Init(this);

		// Switch to landing page
		SwitchPage<MetaUIPage_NormalLevels>();
	}

	public void SetVisible(bool visible)
	{
		gameObject.SetActive(visible);
	}

	public void SwitchPage<T>() where T : MetaUIPageBase
	{
		if (pages == null)
			throw new Exception("MetaUIController not initialized!");

		Debug.Log($"Switch page from {currentPage} to ");

		if (currentPage)
			currentPage.Exit();
		currentPage = TypeHelper.GetInstanceOfType<T>(pages);
		Debug.Log($"{currentPage}");
		currentPage.Enter();
	}
}
