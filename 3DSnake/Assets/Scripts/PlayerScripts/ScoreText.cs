using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
	private void Update()
	{
		this.GetComponent<Text>().text = PlayerPrefs.GetString("Hsr");
	}
}
