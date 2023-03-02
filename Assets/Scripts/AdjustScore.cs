using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustScore : MonoBehaviour
{
    int score = 0;

    public void incrementScore()
    {
        score++;
        Text myText = GetComponent<Text>();
        myText.text = score.ToString();
    }
}
