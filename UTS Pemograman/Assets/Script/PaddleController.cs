using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {
	public float kecepatan ;
	public string axis;
	public float batasKanan;
	public float batasKiri;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		float gerak = Input.GetAxis (axis) * kecepatan * Time.deltaTime;
		transform.Translate (gerak, 0 , 0);

	}
}

