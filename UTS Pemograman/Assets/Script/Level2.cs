using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2: MonoBehaviour {
	public GameObject Kembali;
	public GameObject Restart;



	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
	}
		
	public void KembaliClicked()
	{
		Application.LoadLevel ("MainMenu");
	}
	public void RestartClicked()
	{ 
		Application .LoadLevel ("Gameplay2");
			}
}
