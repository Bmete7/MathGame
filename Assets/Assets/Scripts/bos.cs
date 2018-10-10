using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bos : MonoBehaviour {


	public GameObject[] question = new GameObject[10];
	// Use this for initialization
	void Start () {
		randomQuestion ();
	}
	private void randomQuestion(){
		int index;

		index = Random.Range (1, question.Length);
		Debug.Log(index);
		question[index].SetActive(true);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
