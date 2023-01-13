using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float Horizontal,Verical;
    [SerializeField]
    private float speed;
    [SerializeField]


    private GameObject boomPrefab;
    private float boomSpeed = 10f;

    void Start()
    {
        transform.position = new Vector3(0,-3.5f,0);
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
        if (Input.GetKeyDown("Space"))
        {
            boomShooting();
        }

    }
     public void movePlayer()
    {
        float x = Input.GetAxis("Horizontal");
        float y =Input.GetAxis("Vertical");
        transform.Translate(new Vector3(x, y, 0)* speed * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -4.0f, 4.0f), Mathf.Clamp(transform.position.y, -3.5f, 5.5f),0);
    }

    public void boomShooting() {
    Instantiate(boomPrefab,transform.position,Quaternion.identity); 
    transform.Translate(new Vector3(0,1,0)*boomSpeed*Time.deltaTime);

    }


}
