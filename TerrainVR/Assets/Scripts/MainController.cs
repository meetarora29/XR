﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainController : MonoBehaviour
{
	
	public void LoadScene(String name = "Menu")
	{
		SceneManager.LoadScene(name);
	}
}
