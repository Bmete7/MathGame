using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class islemController : MonoBehaviour {


	public GameObject soru;
	public GameObject[] anlatim = new GameObject[4];
	public GameObject[] cevapButonlari = new GameObject[4];

	//anlatımlar arası gecis butonu
	public GameObject nButton, bButton;
	 
	public string[] sorularA = new string[]{"3 + 5","4 - 2","6 + 3","2 x 1","8 / 2","4 x 2","7 - 2," ,"8 + 1", "8 - 1", "3 x 3"};
	public string[] cevaplarA = new string[]{"8","2","9","2","4","8","5","9","7","9"};
	public string[] cevaplarB = new string[]{"3","1","8","1","0","1","3","10","6","33"};
	public string[] cevaplarC = new string[]{"2","3","7","21","1","7","10","8","8","1"};
	public string[] cevaplarD = new string[]{"1","9","6","3","8","6","2","1","1","3"};
	int[] soruSirasi = new int[5];



	// kazanma kosulu icin
	public int correctAnswers = 0;
	public int totalAnswers = 0;

	// tum konuları anlatınca soru butonu on yapar
	private int anlatimIndex = 0;
	public GameObject qStart;


	// Button oryantasyonu icin kullanıldı
	Vector3 tempA = new Vector3(-340.0f,0,0);
	Vector3 tempB = new Vector3(0,0,0);
	Vector3 tempC = new Vector3(-170.0f,0,0);
	Vector3 tempD = new Vector3(170.0f,0,0);
	Vector3 tempE = new Vector3(0,-50.0f,0);
	// Use this for initialization




	void Start () {
		anlatim [anlatimIndex].SetActive (true);
		qStart.SetActive (false);
		soru.SetActive (false);
		//sorular = 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void nextInfo(){
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

		soru.SetActive (true);
		for (int i = 0; i < 4; ++i) {
			cevapButonlari[i].transform.position += tempE;
		}
		soru.transform.position += tempE;
		//soru.transform.position += tempD;

		buttonsMixed ();



	}

	public void correctAnswer(){
		++correctAnswers;
		anAnswer ();
	}
	public void falseAnswer(){
		anAnswer ();
	}
	public void anAnswer(){
		++totalAnswers;
		if (totalAnswers == 5) {
			if (correctAnswers >= 3) {
				
				Debug.Log ("Kazandin");
			} 
			else {
				Debug.Log ("Kaybettin");
			}
		}

		buttonsMixed ();
	}

	public void buttonsMixed(){
		
		soru.GetComponentInChildren<Text> ().text = sorularA[soruSirasi[totalAnswers]];
		cevapButonlari [0].GetComponentInChildren<Text> ().text = cevaplarA[soruSirasi[totalAnswers]];
		cevapButonlari [1].GetComponentInChildren<Text> ().text = cevaplarB[soruSirasi[totalAnswers]];
		cevapButonlari [2].GetComponentInChildren<Text> ().text = cevaplarC[soruSirasi[totalAnswers]];
		cevapButonlari [3].GetComponentInChildren<Text> ().text = cevaplarD[soruSirasi[totalAnswers]];


			for (int i = 0; i < 4; ++i) {
				Vector3 tempBos = new Vector3(cevapButonlari[i].transform.position[0] * -1 ,0,0); 
				Vector3 tempBos2 = new Vector3(600.0f ,0,0); 
				cevapButonlari [i].transform.position += tempBos;
				cevapButonlari [i].transform.position += tempBos2;

			}

		
		/*
		for (int i = 0; i < 4; ++i) {
			if(cevapButonlari[i].transform.position[0])
		}*/
 


		bool[] butonYeri = new bool[4];
		int breaker = 0;
		int rand = 0;
		for (int i = 0; i < 4; ++i) {
			butonYeri [i] = false;
		}

		for (int i = 0; i < 4; ++i){
			do {
				rand = Random.Range (0, 4);
			} while(butonYeri [rand] && breaker < 200);
			butonYeri[rand] = true;
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

	}

}
