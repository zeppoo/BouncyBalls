using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateCounter : MonoBehaviour
{
    public Text scoreText;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + " Collisions";
    }

    public void AddPoint()
    {
        score++;
        scoreText.text = score.ToString() + " Collisions";
    }
}
