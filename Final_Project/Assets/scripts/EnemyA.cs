using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyA : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 2f;

    [SerializeField]
   private GameManager manager;

    void Update()
    {
        //test
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "laser")
        {
            manager.UpdateScore();
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
           
        }
    }

}
