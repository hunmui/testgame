using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
   
    // Start is called before the first frame update
    public GameObject baal;
    
    private void Awake()
    {
        
    }
   

    // Update is called once per frame
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
   
            
                baal.SetActive(!baal.activeSelf);
            
        }
       
    }
}
