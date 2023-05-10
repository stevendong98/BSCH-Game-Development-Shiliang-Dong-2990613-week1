using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] BallScore ballScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    bool isCollide = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.StartsWith("Target") && !isCollide)
        {
            isCollide = true;
            ballScore.AddScore();
            Destroy(gameObject, 3f);
        }
    }
}
