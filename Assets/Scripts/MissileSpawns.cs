using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileSpawns : MonoBehaviour
{
    public int timing;
    public int target;
    public List<GameObject> targets;
    public Transform creationPlace1;
    public Transform creationPlace2;
    public Transform creationPlace3;
    public Transform creationPlace4;
    public Transform creationPlace5;
    public Transform creationPlace6;
    public GameObject enemyMissile;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(timing + 1);
            target = Random.Range(0, 6);
            if(target == 0)
            {
                Instantiate(enemyMissile, creationPlace1.position, creationPlace1.rotation);
            }
            else if (target == 1)
            {
                Instantiate(enemyMissile, creationPlace2.position, creationPlace2.rotation);
            }
            else if (target == 2)
            {
                Instantiate(enemyMissile, creationPlace3.position, creationPlace3.rotation);
            }
            else if (target == 3)
            {
                Instantiate(enemyMissile, creationPlace4.position, creationPlace4.rotation);
            }
            else if (target == 4)
            {
                Instantiate(enemyMissile, creationPlace5.position, creationPlace5.rotation);
            }
            else if (target == 5)
            {
                Instantiate(enemyMissile, creationPlace6.position, creationPlace6.rotation);
            }
        }
    }
}
