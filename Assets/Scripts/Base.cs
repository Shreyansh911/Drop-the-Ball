using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    [Range(1, 10)] public float Speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * Speed);

        if(transform.position.y > 6)
        {
            Destroy(this.gameObject);
        }
    }
}
