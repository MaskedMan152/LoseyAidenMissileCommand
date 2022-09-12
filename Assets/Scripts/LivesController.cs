using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LivesController : MonoBehaviour
{
    PlayerControls pc;


    // Start is called before the first frame update
    void Start()
    {
        var player = GameObject.Find("Barrel");
        pc = player.GetComponent<PlayerControls>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Enemy"))
        {
            pc.LoseCondition();
            Destroy(gameObject);
        }
    }



}
