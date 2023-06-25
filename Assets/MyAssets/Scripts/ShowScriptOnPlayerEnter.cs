using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowScriptOnPlayerEnter : MonoBehaviour
{
    public GameObject objectToActivate;
    public GameObject secoundObjectToActivate;
    public bool PlayerIsInPlayableArea;
    public bool tutorialLevel = true;
    public bool TVActive = true;

    void OnTriggerEnter(Collider other)
    {
        PlayerIsInPlayableArea = true;
        if (tutorialLevel)
        {
            objectToActivate.SetActive(true);

        }
    }

    void OnTriggerExit(Collider other)
    {
        PlayerIsInPlayableArea = false;
        if (tutorialLevel)
        {
            objectToActivate.SetActive(false);
        }
    }

            
    void Update()
    { 
        if(PlayerIsInPlayableArea == true){
                
                Debug.Log("special");

           
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                     if (TVActive)
                    {
                        secoundObjectToActivate.SetActive(false);
                        objectToActivate.SetActive(false);
                        Debug.Log("TV off");
                    }
                }
        }
        

    }

}

