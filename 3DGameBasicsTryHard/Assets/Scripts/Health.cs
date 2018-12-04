using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour {

	private Animator _animator;
	public const int maxHealth = 100;
	public int currentHealth = maxHealth;
	public RectTransform healthBar;
	
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
	}
	
	
	public void TakeDamage(int amount, Collider other)
	{
		FloatingTextController.CreateFloatingText(amount.ToString(), other.transform);
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
