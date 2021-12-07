using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
	public static Singleton Instance;
	public Object[] GameConfig;

	private void Awake()
	{
		if (Instance == null)
			Instance = this;
		else
			Destroy(this);

		DontDestroyOnLoad(this);

		LoadGameConfig();
	}

	private void LoadGameConfig()
	{
		GameConfig = Resources.LoadAll("GameConfigs");
	}
}
