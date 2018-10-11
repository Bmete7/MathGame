using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bos : MonoBehaviour {


	public GameObject[] question = new GameObject[10];
	public GameObject studyScene;
	private bool questionTurns = false;
	private int f=2,t=1,i=1,x=1;
	// Use this for initialization
	void Start () {
			study ();
	}
	private void randomQuestion(){
		int index;

		index = Random.Range (1, question.Length);
		Debug.Log(index);
		question[index].SetActive(true);
	}
	private void study(){
		studyScene.SetActive (true);
	}
	public void questionT(){
		questionTurns = true;
	}
	public void trueAnswer(){
		t++;
		Debug.Log ("t =");
		Debug.Log (t);
		i++;
	}
	public void wrongAnswer(){
		f--;
		Debug.Log ("f =");
		Debug.Log (f);
		i++;
	}
	// Update is called once per frame
	void Update () {
		if (t <= 3 && f > 0) {
			if (questionTurns && i== x ) {
				randomQuestion ();
				x++;
			} else {
				
			}
		} else {
		}

	}
}
