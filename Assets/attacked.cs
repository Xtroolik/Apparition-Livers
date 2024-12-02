using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attacked : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        while (collision.gameObject.name == "Triangle")
        {
            Debug.Log("Touched");
            
        }
    }
}
