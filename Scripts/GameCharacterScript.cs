using System.Collections;
using UnityEngine;

public class GameCharacterScript : MonoBehaviour {
	Animator anim;


	void Start ()
	{
		anim = GetComponent<Animator> ();  
	}

	void Update ()
	{
		float move = Input.GetAxis ("Vertical");
		anim.SetFloat ("Speed", move);
	}
}
