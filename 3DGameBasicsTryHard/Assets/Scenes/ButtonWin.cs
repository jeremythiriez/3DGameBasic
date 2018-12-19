using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonWin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Menu(){
			SceneManager.LoadScene("Menu", LoadSceneMode.Single);
	}

	public void Play(){
			SceneManager.LoadScene("Stage1", LoadSceneMode.Single);
	}
}
