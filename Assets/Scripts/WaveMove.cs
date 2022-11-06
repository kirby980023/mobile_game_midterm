using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMove : MonoBehaviour
{
    public float speed = 1;
    public Rigidbody rb;
    public Transform target, target2;
    public bool faceleft;
    public float targety, target2y;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        targety = target.position.y;
        target2y = target2.position.y;

        Destroy(target.gameObject);
        Destroy(target2.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        move();
        // 2.MoveTo（target,trTargetPosition.position,2f);
    }

    void move()
    {

      if (faceleft)
      {
        rb.velocity = new Vector2(-speed, rb.velocity.x);
        
        if (transform.position.y < targety)
        {
            faceleft = false;
        }
      }

      else
      {
        rb.velocity = new Vector2(speed, rb.velocity.x);
        
        if (transform.position.y > target2y)
        {
            faceleft = true;
        }
      }
    }
}
