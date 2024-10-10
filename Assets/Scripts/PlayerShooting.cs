using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public GameObject normalBullet;
    public GameObject specialBullet;
    public GameObject shootPoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(normalBullet, transform.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Instantiate(specialBullet, transform.position, transform.rotation);
        }
    }

    /*public void OnFire(InputValue value)
    {
        GameObject clone = Instantiate(normalBullet);

        clone.transform.position = shootPoint.transform.position;
        clone.transform.rotation = shootPoint.transform.rotation;
    }*/
}
