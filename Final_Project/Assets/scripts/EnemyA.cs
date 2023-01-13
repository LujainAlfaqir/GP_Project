using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyA : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 2f;
<<<<<<< HEAD
    [SerializeField]
   private GameManager manager;
    void Start()
    {
       // manager = GetComponent<GameManager>();
=======
    void Start()
    {
        
>>>>>>> parent of a2b5ac3 (gamemanager)
    }

    // Update is called once per frame
    void Update()
    {
        //test
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
<<<<<<< HEAD

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "laser")
        {
            manager.UpdateScore();
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
           
        }
    }
=======
>>>>>>> parent of a2b5ac3 (gamemanager)
}
