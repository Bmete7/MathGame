using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class islemController : MonoBehaviour {
	public int questionCount = 10;
	public int anlatimCount = 4;
	public GameObject[] sorular = new GameObject[10];
	public GameObject[] anlatim = new GameObject[4];
	public GameObject[] cevapButonlari = new GameObject[4];
	public GameObject nButton, bButton;
	public GameObject qStart;

	private int anlatimIndex = 0;

	// Use this for initialization
	void Start () {
		anlatim [anlatimIndex].SetActive (true);
		qStart.SetActive (false);
		sorular [0].SetActive (false);
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
		for (int i = 0; i < 4; ++i) {
			anlatim [i].SetActive (false);
		}
		bButton.SetActive (false);
		nButton.SetActive (false);
		qStart.SetActive (false);
		bool[] secilenSoruIndex= new bool[10];
		int[] soruSirasi = new int[5];
		for (int i = 0; i < 10; ++i) {
			secilenSoruIndex [i] = false;
		}

		int rand = 0;
		int breaker = 0;
		for (int i = 0; i < 5; ++i) {
			do {
				rand = Random.Range (0, 10);
				++breaker;
			} while (secilenSoruIndex [rand] && breaker < 200); 

			secilenSoruIndex [rand] = true;
			soruSirasi [i] = rand;
		}

		sorular [0].SetActive (true);


		Vector3 tempA = new Vector3(-300.0f,-50.0f,0);
		Vector3 tempB = new Vector3(-100.0f,-50.0f,0);
		Vector3 tempC = new Vector3(100.0f,-50.0f,0);
		Vector3 tempD = new Vector3(300.0f,-50.0f,0);

		bool[] butonYeri = new bool[4];
		breaker = 0;
		rand = 0;
		for (int i = 0; i < 4; ++i) {
			butonYeri [i] = false;
		}

		for (int i = 0; i < 4; ++i){
			do {
				rand = Random.Range (0, 4);
			} while(butonYeri [rand] && breaker < 200);
			butonYeri[rand] = true;
			Debug.Log (rand);
			if (i == 0) {
				cevapButonlari[rand].transform.position += tempA;	
			}
			else if (i == 1) {
				cevapButonlari[rand].transform.position += tempB;
			}
			else if (i == 2) {
				cevapButonlari[rand].transform.position += tempC;
			}
			else if (i == 3){
				cevapButonlari[rand].transform.position += tempD;
			}
		}
		for (int i = 0; i < 4; ++i) {
			cevapButonlari [i].SetActive (true);
		}
		//cevapButonlari[0].GetComponentInChildren<Texture>().text
	}


}
