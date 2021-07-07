using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neweggscript : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject spawnEgg; //copy of egg will be save here
    public GameObject canvas; //parent
    public GameObject Egg; //prefab Egg
    private float cloneRate = 2f;//time gap between the clone formation
    private float nextClone = 0.0f; //timing of next clone

    void Start()
    {
      Debug.Log(Time.time);  
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time);
        if(Time.time > nextClone)
        {
            nextClone = Time.time + cloneRate;
            spawnEgg = Instantiate(Egg,new Vector3(Random.Range(0,Screen.width),Screen.height,0),Quaternion.identity);
            spawnEgg.transform.SetParent(canvas.transform);
            
        }
        
    }
    
}
