using UnityEngine;

public enum GameMode
{
	NormalLevel = 0,
	//NormalLevelSecondRound = 1,
	//BonusLevel = 2,
	HardLevel = 3,
	Endless = 4,
	Tournament = 5,
	Cup = 6
}

public class LevelController : MonoBehaviour
{
	private GameMode currentMode;

	public void SetGameMode(GameMode newMode)
	{
		currentMode = newMode;
	}

	public void ShowStartSequence()
	{

	}

	public void ShowEndSequence()
	{

	}

	public void OnCarCrossedFinishline()
	{

	}


}
