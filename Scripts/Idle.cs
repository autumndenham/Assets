using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : MonoBehaviour {

	Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();  
	}

	void Update () {
		if (Input.anyKeyDown)
			anim.SetTrigger ("Idel");   
	}
}
