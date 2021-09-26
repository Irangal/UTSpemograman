using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level: MonoBehaviour {
	public GameObject Level2;
	public GameObject Kembali;
	public GameObject Restart;



	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
	}

	public void Level2Clicked()
	{
		Application.LoadLevel ("Gameplay2");
	}
	public void KembaliClicked()
	{
		Application.LoadLevel ("MainMenu");
	}
	public void RestartClicked()
	{ 
		Application .LoadLevel ("Gameplay");
			}
}
