using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Manager : MonoBehaviour
{
    public Transform pointOfFire;
    public float speed;
    public float bulletVelocity;

    public GameObject bullet;
    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal2");
        float moveVertical = Input.GetAxis("Vertical2");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            GameObject clone;
            clone = Instantiate(bullet, pointOfFire.position, transform.rotation);

            // Give the cloned object an initial velocity along the current
            // object's Z axis
            clone.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * bulletVelocity);
        }
    }
}
