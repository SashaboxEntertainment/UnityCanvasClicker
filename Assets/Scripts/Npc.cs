using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    [SerializeField] private int _health;

	private void OnEnable()
	{
		StartCoroutine(DoSomething());
	}

	private IEnumerator DoSomething()
	{
		yield return new WaitForSeconds(2);
	}

	private void OnDisable()
	{
		
	}
}
