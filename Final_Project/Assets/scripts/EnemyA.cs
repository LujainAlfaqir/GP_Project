using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyA : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //test
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
