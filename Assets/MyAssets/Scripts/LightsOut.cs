using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOut : MonoBehaviour
{

   
    public bool StartShower = false;
    public GameObject[] objectArray; 

   

    // Start is called before the first frame update
    void Start()
    {
        if(StartShower == true){
        InvokeRepeating("GenerateWater", 1f, 3f);
        }
    }

    public void GenerateWater(){
        Debug.Log("SpawningWata");
        for (int i = 0; i < 250; i++)
        {
            int randomIndex = Random.Range(0, objectArray.Length);
            Instantiate(objectArray[randomIndex], transform.position, Quaternion.identity);
           // Debug.Log(i);
        }
    }


 void OnTriggerEnter(Collider other)
    {
        StartShower = true;
        InvokeRepeating("GenerateWater", 1f, 3f);
    }

 void OnTriggerExit(Collider other)
    {
        StartShower = false;
        CancelInvoke("GenerateWater");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
