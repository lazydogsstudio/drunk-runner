using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropCollistion : MonoBehaviour
{
    PlayerManager playerManager;
    void Start()
    {
        playerManager = GameObject.FindWithTag("Player").GetComponent<PlayerManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            if (gameObject.CompareTag("Milk"))
            {
                Destroy(gameObject);
                playerManager.SetDankLevelDown();
            }

            else if (gameObject.CompareTag("Beer"))
            {
                Destroy(gameObject);
                playerManager.SetDankLevelUp();
            }
        }
    }


}
