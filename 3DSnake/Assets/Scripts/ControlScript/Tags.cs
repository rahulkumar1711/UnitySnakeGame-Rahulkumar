﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tags : MonoBehaviour
{
	public static string WALL = "Wall";
	public static string FRUITGR = "FRUITGR";
	public static string FRUITOR = "FRUITOR";
	public static string BOMB = "Bomb";
	public static string TAIL = "Tail";
}
public class Metrics
{
	public static float NODE = 0.2f;
}
public enum PlayerDirection
{
	LEFT = 0,
	UP = 1,
	RIGHT = 2,
	DOWN = 3,
	COUNT = 4
}
