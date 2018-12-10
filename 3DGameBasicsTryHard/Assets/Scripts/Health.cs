using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class Health : MonoBehaviour {

	private Animator _animator;
	public const int maxHealth = 100;
	public int currentHealth = maxHealth;
	public RectTransform healthBar;
	private bool crit = false;
	
	// Use this for initialization
	void Start () {
		_animator = GetComponent<Animator>();
		FloatingTextController.Initialize();
	}
	
	// Update is called once per frame
	void Update () {
		_animator.SetBool("getHitBody", false);
		_animator.SetBool("getHitLeft", false);
		_animator.SetBool("getHitRight", false);
		crit = false;
	}
	
	
	public void TakeDamage(int amount, Collider other)
	{
		if (Random.Range(0, 3) % 3 == 0)
		{
			crit = true;
			amount *= 2;
		}
		FloatingTextController.CreateFloatingText(amount.ToString(), other, crit);
		currentHealth -= amount;
		
		if (other.CompareTag("MonsterBody"))
		{
			_animator.SetBool("getHitBody", true);
		}
		else if (other.CompareTag("MonsterArmLeft"))
		{
			print("JE RENTRE");
			_animator.SetBool("getHitLeft", true);
		}
		else if (other.CompareTag("MonsterArmRight"))
		{
			_animator.SetBool("getHitRight", true);
		}
		if (currentHealth <= 0)
		{
			currentHealth = 0;
			Debug.Log("Dead!");
			_animator.SetBool("dead", true);
		}
		healthBar.sizeDelta = new Vector2(currentHealth, healthBar.sizeDelta.y);
		
	}
}
