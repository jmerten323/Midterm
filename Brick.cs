using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int hitsToKill;
    private int numberOfHits;
    // Use this for initialization
    void Start()
    {
        numberOfHits = 0;

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball") ;
        {
            numberOfHits++;
            if (numberOfHits == hitsToKill)
            {
                Destroy(this.gameObject);
                Debug.Log(hitsToKill);
                FindObjectOfType<Ball>().YouBrokeABrick();
            }
        }
    }

}

