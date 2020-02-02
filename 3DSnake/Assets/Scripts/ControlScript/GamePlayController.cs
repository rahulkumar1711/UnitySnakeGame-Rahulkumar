using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlayController : MonoBehaviour
{
	public static GamePlayController instance;
	public GameObject fruitPickUp;
	public GameObject fruitPickUp1;
	private float min_X = -4f, max_X = 4f, min_Y = -2f, max_Y = 2f;
	private float z_pos = 5f;
	public Text GreenScore;
	public Text OrangeScore;
	public int gscoreCount;
	public int orscoreCount;
	private void Awake()
	{
		MakeInstance();
	}
	private void Start()
	{
		GreenScore = GameObject.Find("GreenFood").GetComponent<Text>();
		OrangeScore = GameObject.Find("OrangeFood").GetComponent<Text>();
		Invoke("StartSpawning", 0.5f);
	}
	void MakeInstance()
	{
		if (instance == null)
		{
			instance = this;
		}
	}
	void StartSpawning()
	{
		StartCoroutine(SpawnPickUps());
	}
	public void CancelSpawning()
	{
		CancelInvoke("StartSpawning");
	}
	IEnumerator SpawnPickUps()
	{
		yield return new WaitForSeconds(3f);
		if (Random.Range(0, 10) >= 3)
		{
			Instantiate(fruitPickUp,
				new Vector3(Random.Range(min_X, max_X), Random.Range(min_Y, max_Y), z_pos),
				Quaternion.identity);
			Instantiate(fruitPickUp1,
				new Vector3(Random.Range(min_X, max_X), Random.Range(min_Y, max_Y), z_pos),
				Quaternion.identity);
		}
		Invoke("StartSpawning", 0f);
	}
	public void IncreaseScore()
	{
		orscoreCount = 0;
		OrangeScore.text = "Score:" + orscoreCount;
		gscoreCount = gscoreCount + 15;
		GreenScore.text = "Score:" + gscoreCount;
	}
	public void IncreaseScore1()
	{
		gscoreCount = 0;
		GreenScore.text = "Score:" + gscoreCount;
		orscoreCount = orscoreCount + 20;
		OrangeScore.text = "Score:" + orscoreCount;
	}
}
