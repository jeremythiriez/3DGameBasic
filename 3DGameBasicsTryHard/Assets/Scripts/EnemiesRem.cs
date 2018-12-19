using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemiesRem : MonoBehaviour {

	private GameObject[]		tmps;
	public	Text	text;
	public	string 	scene;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		tmps = GameObject.FindGameObjectsWithTag("MonsterBody");

		text.text = "Enemies Remainning : " + tmps.Length;

		if (tmps.Length <= 0){
			SceneManager.LoadScene(scene, LoadSceneMode.Single);
		}
	}
}
