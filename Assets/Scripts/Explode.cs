using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Explodes());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Explodes()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            Destroy(gameObject);
        }
    }
}
