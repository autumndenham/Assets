using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour {

	Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();  
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.D))
			anim.SetTrigger ("Walk");   
	}
}
