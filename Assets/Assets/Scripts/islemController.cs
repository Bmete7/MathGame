using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class islemController : MonoBehaviour {
	public int questionCount = 10;
	public int anlatimCount = 4;
	public GameObject[] sorular = new GameObject[10];
	public GameObject[] anlatim = new GameObject[4];
	public GameObject qStart;
	private int anlatimIndex = 0;

	// Use this for initialization
	void Start () {
		anlatim [anlatimIndex].SetActive (true);
		qStart.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void nextInfo(){
		anlatim [anlatimIndex].SetActive (false);
		if (anlatimIndex == 2) {
			qStart.SetActive (true);
		}
		if (anlatimIndex == 3) {
			anlatimIndex = 0;
		} 
		else {
			anlatimIndex++;
		}

		anlatim [anlatimIndex].SetActive (true);
	}
	public void previousInfo(){
		anlatim [anlatimIndex].SetActive (false);
		if (anlatimIndex > 0) {
			anlatimIndex--;
		}
		anlatim [anlatimIndex].SetActive (true);

	}
	public void questionStart(){
	}


}
