using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour {

	public GameObject	spell;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other) {
		Spell tmp;

		if (other.tag == "Player"){
			tmp = other.gameObject.GetComponent<Spell>();
			tmp.spell = spell;
		}
	}
}
