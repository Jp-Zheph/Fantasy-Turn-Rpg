using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D rigidbody;

    public float speedy;
    Vector2 movement;


    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + movement * speedy * Time.fixedDeltaTime);
    }
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
}
