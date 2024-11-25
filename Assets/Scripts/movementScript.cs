using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class movementScript : MonoBehaviour
{
    // Zapisujemy zmienne do póŸniejszego u¿ytku
    Rigidbody2D body;
    float horizontal;
    float vertical;
    public float moveSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        // znajdujemy component rigidbody2d
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Znajdujemy input aby ruszyæ postaæ po axis
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        // Dajemy postaci prêdkoœæ 
        body.velocity = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);
    }
}
