using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    int score = 0;

    public GameObject textUI;
    void OnCollisionEnter2D(Collision2D other)
    {
        score++;
        Text myText = GetComponent<Text>();
        myText.text = score.ToString();
    }
}
