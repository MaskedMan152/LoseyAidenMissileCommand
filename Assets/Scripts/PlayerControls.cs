using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour
{
    public bool canShoot;
    public GameObject bullet;
    public Transform playerPosition;
    public int lives = 6;
    

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(Shoot());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && (canShoot))
        {
            Instantiate(bullet, playerPosition.position, playerPosition.rotation);
            canShoot = false;
        }
    }

   public void LoseCondition()
    {
        --lives;
        Debug.Log(lives);
        if(lives < 1)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }


    IEnumerator Shoot()
    {
        while (true)
        {
            canShoot = true;
            yield return new WaitForSeconds(0.5f);
        }
    }
}
