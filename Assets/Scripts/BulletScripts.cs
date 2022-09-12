using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScripts : MonoBehaviour
{
    public int speed = 6;
    public Rigidbody2D bullet;
    private Vector2 mouse;
    public GameObject explotion;
    public Transform bulletPosition;

    // Start is called before the first frame update
    void Start()
    {
       mouse = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        Vector2 cp = new Vector2(transform.position.x, transform.position.y);
        Vector2 direction = mouse - cp;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
        Quaternion angleAxis = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, angleAxis, Time.deltaTime * 50);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 bulletPos = new Vector2(transform.position.x, transform.position.y);

        if (transform.position.y < mouse.y)
        {
            bulletPos.y += Time.deltaTime * speed;
            transform.position = bulletPos;
        }

        if (transform.position.x < mouse.x)
        {
            bulletPos.x += Time.deltaTime * speed;
            transform.position = bulletPos;
        }

        else if (transform.position.x > mouse.x)
        {
            bulletPos.x -= Time.deltaTime * speed;
            transform.position = bulletPos;
        }

        if (mouse.y <= transform.position.y)
        {
            Instantiate(explotion, bulletPosition.position, bulletPosition.rotation);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      Destroy(gameObject);
    }
}
