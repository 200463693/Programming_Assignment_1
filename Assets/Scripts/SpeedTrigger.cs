using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.GetComponent<PlayerMovement>().speed *= 2.0f;
    }

    private void OnTriggerExit2D(Collider2D collison)
    {
        gameObject.GetComponent<PlayerMovement>().speed /= 2.0f;
    }
}
