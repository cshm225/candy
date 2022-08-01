using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    public CandyManager candyManager;
    public int reward;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Candy")
        {
            Destroy(other.gameObject);
            candyManager.AddCandy(reward);
        }
    }
}
