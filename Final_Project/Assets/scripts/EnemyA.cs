using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyA : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 2f;
    GameManager manager;
    void Start()
    {
        manager = GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "laser")
        {
           // Destroy(this.gameObject);
            Destroy(collision.gameObject);
            manager.UpdateScore();
        }
    }
}
