using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState { Meta, Core }

public class GameManager : Singleton<GameManager>
{
	[SerializeField] private MetaUIController metaUIController;
	[SerializeField] private CoreUIController coreUIController;
	[SerializeField] private LevelController levelController;

	private void Start()
	{
		coreUIController.Init();
		metaUIController.Init();

		SwitchState(GameState.Meta);
	}

	public void StartLevel(GameMode gameMode)
	{
		// Show loading screen
		// Load level
		// Hide loading screen

		Debug.Log($"[GameManager] StartLevel: {gameMode}");

		SwitchState(GameState.Core);
		levelController.SetGameMode(gameMode);
		coreUIController.SetupGameMode(gameMode);
	}

	public void OpenMenu()
	{
		Debug.Log($"[GameManager] OpenMenu");
		SwitchState(GameState.Meta);
	}

	private void SwitchState(GameState gameState)
	{
		metaUIController.SetVisible(gameState == GameState.Meta);
		coreUIController.SetVisible(gameState == GameState.Core);
	}
}
