using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScripts : MonoBehaviour
{

    public Rigidbody2D bullet;

    // Start is called before the first frame update
    void Start()
    {
        bullet.velocity = transform.up * 6;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      Destroy(gameObject);
    }
}
