using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    [SerializeField] private float dogInstanceDelay = 1.0f, currentTime = 0;//Bonus variables

    // Update is called once per frame
    void Update()
    {        
        if(currentTime > dogInstanceDelay){//Bonus step 9
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                currentTime = 0;//Bonus step 9
            }
        }        

        currentTime += Time.deltaTime;//Bonus step 9
    }
}
