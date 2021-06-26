using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text counterText;
    public bool isGameOver = false;

    private int count = 0;

    private void Start()
    {
        count = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball") && isGameOver == false)
        {
            count += 1;
            counterText.text = "Count : " + count;
            isGameOver = true;
        }
    }
}
