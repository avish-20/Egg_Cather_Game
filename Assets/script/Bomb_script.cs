using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb_script : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject spawnBomb;
    public GameObject canvas; //parent
     public GameObject Bomb;
     private float cloneRate = 2f;//time gap between the clone formation
    private float nextClone = 0.0f; //timing of next clone
    void Start()
    {
        
    }

    // Update is called once per frame
   void Update()
    {
        Debug.Log(Time.time);
        if(Time.time > nextClone)
        {
            nextClone = Time.time + cloneRate;
            spawnBomb = Instantiate(Bomb,new Vector3(Random.Range(0,Screen.width),Screen.height,0),Quaternion.identity);
            spawnBomb.transform.SetParent(canvas.transform);
            
        }
        
    }
}
