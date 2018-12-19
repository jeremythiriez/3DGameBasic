using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour {

	public SimpleHealthBar manaBar;
	public int manaMax;
	public int mana;

	public int spellCost;

	public GameObject	spell;

	// Use this for initialization
	void Start () {
		spellCost = 10;
		mana = 100;
		manaMax = mana;
	 	InvokeRepeating("manaRegen", 1f, 1f);
	}
	
	void manaRegen(){
		if (mana < 100){
			mana += 2;
		}
	}

	// Update is called once per frame
	void Update () {

		manaBar.UpdateBar( mana, manaMax );
		GameObject handspell = GameObject.FindGameObjectWithTag("HandSpell");
		if (Input.GetMouseButtonDown(0) && mana >= spellCost){
			mana -= spellCost;
			GameObject newSpell =  (GameObject)Instantiate(spell, handspell.transform.position, this.transform.rotation);
			newSpell.transform.parent = gameObject.transform;
		}
	}
}
