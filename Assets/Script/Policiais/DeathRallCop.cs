﻿using UnityEngine;
using System.Collections;

public class DeathRallCop : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Application.LoadLevel("MainScene");
        }
    }
}
