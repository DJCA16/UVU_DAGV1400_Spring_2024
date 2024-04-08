using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float fireRate = 1; 
    private float nextFire = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog after certain amount of time has passed
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate; //reset fireRate as soon as dog is fired
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
