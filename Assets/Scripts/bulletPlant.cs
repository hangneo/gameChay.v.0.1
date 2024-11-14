using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletPlant : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Tự gán đối tượng
        Destroy(gameObject, 3f); //Khoảng thời gian tự biến mất sau khi được tạo ra. gameObject chính là đối tượng hiện tại
    }

    void Update()
    {
        rb.velocity = new Vector2(-5f, rb.velocity.y);
    }
}
  
