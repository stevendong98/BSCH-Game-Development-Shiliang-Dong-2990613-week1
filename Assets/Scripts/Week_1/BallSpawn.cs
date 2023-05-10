using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
   
    [SerializeField] GameObject ball;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown( KeyCode.Space))
        {
            var b = Instantiate(ball, transform.position, Quaternion.identity);
            b.SetActive(true);
        }
    }
}
