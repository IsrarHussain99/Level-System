using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LockedLevels : MonoBehaviour {
	//Public variables
	public GameObject locksymbol;
	public GameObject playbutton;
	//public GameObject buynowbutton;
	public int Cost;
	public GameObject Options;
	public string ABC; // unique string must be set to each.
	public GameObject NotEnough;
	private bool NotE = false;
	public float WaitT = 1; 
	//AudioClip CoinClip;

	//private Variables.
	public int CoinsValueRetriever;
	private int Number;

	//checkers
	public bool CoinCheck = false;

	// Use this for initialization
	void Awake () {
		{
			playbutton.active = false;
			Options.active = false;
			NotEnough.active = false;
			CoinsValueRetriever = PlayerPrefs.GetInt ("CoinsPref");
			Number = PlayerPrefs.GetInt (ABC);
	
			if (Number == 1) {
				locksymbol.active = false;
				playbutton.active = true;
				//buynowbutton.active = false;
				Number = 2;
			}
		}
	}



	public void OnBuyButtonPressed () {

		if (CoinsValueRetriever >= Cost) {
			Options.active = true;
		} else {
			//leave options deactivated
			Options.active = false;
			//show user not enough diamonds.
			NotEnough.active = true;
			NotE = true;
			StartCoroutine (NotEnuf (WaitT));

			//NEED A METHOD TO STOP SCROLLER IF BUTTONS ARE ACTIVATED!

		}
		}
	public void No ()
	{
		Options.active = false;
	}

	public void Yes ()
	{
				Number = 1;
				CoinsValueRetriever -= Cost;
		//minus the coins.
		PlayerPrefs.SetInt ("CoinsPref", CoinsValueRetriever);
		//visual changes
			//GetComponent<AudioSource> ().PlayOneShot (CoinsClip);
		locksymbol.active = false;
		playbutton.active = true;
		//buynowbutton.active = false;
		Options.active = false;

		//saving the changes.
		PlayerPrefs.SetInt (ABC, Number);
		}

 // END OF PURCHASE.


		//activate this if NotE = true -- hence after coin check
	IEnumerator NotEnuf(float WaitT)
	{
		if(NotE)
		{
			yield return new WaitForSeconds(WaitT);
			NotEnough.active = false;
				NotE = false;
		}
	}
}

