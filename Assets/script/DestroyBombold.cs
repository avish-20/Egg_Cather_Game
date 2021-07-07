using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBombold : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Egg" || other.gameObject.tag == "Bomb"){
            Destroy(other.gameObject);

        }

            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
