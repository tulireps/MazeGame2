﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour {

    public GameObject menu;

	// Use this for initialization
	void Start () {
        Time.timeScale = 0.0f;
	
	}
	
	// Update is called once per frame
	void Update () {
        Time.timeScale = 1.0f;

    }

    public void onStart()
    {
        menu.SetActive(false);
    }
}
