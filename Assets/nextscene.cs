﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextscene : MonoBehaviour
{
    // Start is called before the first frame update
    public int nextscenee;
    public void Start()
    {
        nextscenee = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void OnTriggerEnter2D(Collider2D collision){
        SceneManager.LoadScene(nextscenee);
    }
}
