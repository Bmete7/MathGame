using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class gameController : MonoBehaviour {

	public GameObject chicken , turtle ;
	float speed =100;
	void Start () {
		 	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void startClick (){
		
		Debug.Log(chicken.transform.rotation.eulerAngles.y);
		while (chicken.transform.rotation.eulerAngles.y >= 145) {
			chicken.transform.Rotate (Vector3.down * Time.deltaTime * speed);
			turtle.transform.Rotate (Vector3.up * Time.deltaTime * speed);
		}
		//turtle.transform.rotation.y = 45;
	
	}
}
