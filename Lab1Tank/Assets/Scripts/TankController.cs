using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 5.0f;
    public float rotationSpeed = 200.0f;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            fire();
        }
    }

    void fire()
    {
        //Create the bullet
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        //Add velocity
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.up * 6;

        //Destroy the bullet after 5 seconds.
        Destroy(bullet, 5f);

    }
}
