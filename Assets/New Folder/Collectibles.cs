using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    public bool isCoins, isSpeedup;
    public float speedupDuration;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            NewBehaviourScript playerScript = other.GetComponent<NewBehaviourScript>();
            if (isCoins)
            {
                playerScript.score++;
                Destroy(gameObject);
            }
            if (isSpeedup) 
            {
                playerScript.moveSpeed *= 1.5f;
                Destroy(gameObject);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
