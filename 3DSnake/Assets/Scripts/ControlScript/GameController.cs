using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	private static GameController instance;
	private Text topScore;
	private void Awake()
	{
		if (instance != null)
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
	}
	public void Ok()
	{
		int n = int.Parse(PlayerPrefs.GetString("scr"));
		PlayerPrefs.SetString("scr", (GamePlayController.instance.gscoreCount > 0) ?
			GamePlayController.instance.gscoreCount.ToString() : GamePlayController.instance.orscoreCount.ToString());
		SceneManager.LoadScene("MainScene");
		int n1 = int.Parse(PlayerPrefs.GetString("scr"));
		if (n1 > n)
		{
			PlayerPrefs.SetString("Hsr", (GamePlayController.instance.gscoreCount > 0) ?
			GamePlayController.instance.gscoreCount.ToString() : GamePlayController.instance.orscoreCount.ToString());
		}
	}
	public void StartGame()
	{
		SceneManager.LoadScene("GamplayScene");
	}
}
