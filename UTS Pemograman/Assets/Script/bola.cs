using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bola : MonoBehaviour {
	public int force;
	Rigidbody2D rigid;
	public GameObject PanelSelesai; 
	Text txPemenang;
	public GameObject Panel;
	int Score;
	Text scoreUI;

	// Use this for initialization
	void Start (){ 
		rigid = GetComponent <Rigidbody2D > ();
		Vector2 arah = new Vector2 (0,-2).normalized;
		rigid .AddForce (arah*force);
		Score = 0;
		scoreUI= GameObject.Find ("Score").GetComponent <Text> ();
		PanelSelesai = GameObject.Find ("PanelSelesai");
		PanelSelesai.SetActive (false);
		Panel = GameObject.Find ("Restart");
		Panel.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnCollisionEnter2D ( Collision2D coll)
	{
		if (coll.gameObject.name == "Pemukul") {
			float sudut = (transform.position.x - coll.transform.position.x )* 2f;
			Vector2 arah = new Vector2 (rigid.velocity.y, sudut).normalized;
			rigid.AddForce (arah * force *2);
		}
			if (Score >=90)
			{
				PanelSelesai.SetActive (true);
				txPemenang = GameObject .Find ("PanelSelesai").GetComponent <Text >();
				Destroy (gameObject );
				return ;
			}
				
		if (coll.gameObject.name == "TepiBawah") {
			Panel.SetActive (true);
			ResetBall ();
			Destroy (gameObject);
			Vector2 arah = new Vector2 (0,0).normalized;
			rigid.AddForce (arah * force);
		}
	}

		void OnTriggerEnter2D(Collider2D other )
	{
		if (other.gameObject.CompareTag ("Pick Up")) {
			Destroy (other.gameObject);
			Score += 10;
			TampilkanScore ();
		}
		}
	void ResetBall ()
	{
		transform.localPosition = new Vector2 (0, 0);
		rigid.velocity = new Vector2 (0, 0);
	}
	void TampilkanScore ()
	{
		Debug.Log ("Score :" + Score);
		scoreUI.text = Score + "";
	}
}
