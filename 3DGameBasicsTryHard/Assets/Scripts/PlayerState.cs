using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerState : MonoBehaviour {

	public SimpleHealthBar healthBar;
	public int 				hp;
	public int 				max;

	// Use this for initialization
	void Start () {
		hp = 100;
		max = 100;
	}
	
	// Update is called once per frame
	void Update () {
		healthBar.UpdateBar( hp, max );
		if (hp <= 0){
			SceneManager.LoadScene("LoseScreen", LoadSceneMode.Single);			
		}
	}

}
