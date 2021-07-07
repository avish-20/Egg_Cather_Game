using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputkey : MonoBehaviour
{
    public GameObject bucket;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow) && bucket.transform.position.x < Screen.width)
        {
            bucket.transform.position += new Vector3(3,0,0);
        }
        else if(Input.GetKey(KeyCode.LeftArrow) && bucket.transform.position.x > 0.0f)
        {
             bucket.transform.position += new Vector3(-3,0,0);
        }
    }
}
