using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//hellloooo
public class Player : MonoBehaviour
{
    private float Horizontal,Verical;
    
    private float speed=6.0f;


    [SerializeField]
    private GameObject bulletPrefab;

    private float fireRate = 0.5f;
    private float canfire=0.0f;


    void Start()
    {
        transform.position = new Vector3(0,-3.5f,0);
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
        if (Input.GetKeyDown(KeyCode.Space)&&Time.time >= canfire)
        {
            bulletShooting();
        }

    }
     public void movePlayer()
    {
        float x = Input.GetAxis("Horizontal");
        float y =Input.GetAxis("Vertical");
        transform.Translate(new Vector3(x, y, 0)* speed * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -4.0f, 4.0f), Mathf.Clamp(transform.position.y, -3.5f, 5.5f),0);
    }

    public void bulletShooting() {
    canfire= Time.time+fireRate;
    Instantiate(bulletPrefab,transform.position,Quaternion.identity); 
    }

    
}