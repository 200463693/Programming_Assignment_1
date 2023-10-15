using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMovement playerMovement = transform.Find("ChildObjectName").GetComponent<PlayerMovement>();
        if (collision != null)
        {
            Debug.Log("Collision with: " + collision.gameObject.name);
        }
        gameObject.GetComponent<PlayerMovement>().speed /= 4f;
        Debug.Log("speed slow down");


    }

    private void OnTriggerExit2D(Collider2D collison)
    {
        gameObject.GetComponent<PlayerMovement>().speed = 0.8f;
    }
}
