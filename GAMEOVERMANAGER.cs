using UnityEngine;
using System.Collections;

public class GAMEOVERMANAGER : MonoBehaviour {

	public GameObject Buttons;
	public GameObject CatchButtons;
	public GameObject PauseGame1;
	public GameObject Player;

	public static bool  GameOver1 = false;
	public static bool  CatchPlayer = false;
	bool  CatchOver = false;
	static bool PauseGameHandler = false;

	void Start () {
		

		//PauseGameHandler = PauseGame.pauseGame;
	}

	void  Update (){
		{
			if (Player.activeInHierarchy == false)
			GameOver1 = true;

		}
		{
			if (GameOver1)
				Debug.Log("GM");
			CatchButtons.active = true;
			Buttons.active = true;
			PauseGame1.active = true;


		}
	}
}