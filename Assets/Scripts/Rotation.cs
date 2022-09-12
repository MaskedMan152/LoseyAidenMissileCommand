using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       Vector3 gunAim = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        gunAim.z = 0;

        float gunAngle = Mathf.Atan2(gunAim.y, gunAim.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, gunAngle + -90));
    }
}
