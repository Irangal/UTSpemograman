using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Manager : MonoBehaviour {
	public GameObject MenuPanel;
	public GameObject CreditsPanel;
	public GameObject HowToPanel;


	// Use this for initialization
	void Start () {
		MenuPanel.SetActive (true);
		CreditsPanel.SetActive (false);
		HowToPanel.SetActive (false);


	}

	// Update is called once per frame
	void Update () {
	}
	public void PlayButtonClicked()
	{
		Application.LoadLevel ("Gameplay");
	}
	public void CreditsButtonClicked()
	{

		MenuPanel.SetActive (false);
		CreditsPanel.SetActive (true);
		HowToPanel.SetActive (false);
	}
	public void HowToButonClicked
()
	{
		MenuPanel.SetActive (false);
		CreditsPanel.SetActive (false);
		HowToPanel.SetActive (true);
	}
	public void Quit_Clicked()
	{
		Application.Quit ();

	}
	public void BackButtonClicked()
	{
		MenuPanel.SetActive (true);
		CreditsPanel.SetActive (false);
		HowToPanel.SetActive (false);







	}
}
