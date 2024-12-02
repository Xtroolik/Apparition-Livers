using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Hitbox;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Touched");
        while (collision.gameObject.name == "Enemy(Clone)")
        {
            Debug.Log("Touched");
        }
    }

}
