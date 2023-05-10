using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScore : MonoBehaviour
{
    [SerializeField] Text txtScore;
    int currentScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void AddScore()
    {
        currentScore++;
        txtScore.text = "Score " + currentScore;

    }

}
