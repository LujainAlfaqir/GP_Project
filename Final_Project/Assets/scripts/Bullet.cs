using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float bulletSpeed = 7.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up*bulletSpeed*Time.deltaTime);
        if (transform.position.y >= 6.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
