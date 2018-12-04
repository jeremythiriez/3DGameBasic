using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour {

	public GameObject	spell;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		GameObject handspell = GameObject.FindGameObjectWithTag("HandSpell");
		if (Input.GetMouseButtonDown(0)){
			GameObject newSpell =  (GameObject)Instantiate(spell, handspell.transform.position, this.transform.rotation);
			newSpell.transform.parent = gameObject.transform;
		}
	}
}
