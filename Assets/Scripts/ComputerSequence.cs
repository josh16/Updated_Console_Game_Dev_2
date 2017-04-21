using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerSequence : MonoBehaviour {

    public bool active;
    float timer = 0;
    bool timerCheck = false;
    float timerSec = 0;
    public GameObject ComputerL;
    public GameObject ComputerMid;
    public GameObject ComputerR;
    public GameObject ComputerMain;
  
    public GameObject ScreenOn;


    // Use this for initialization
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

        if (timerCheck)
        {
            timer += Time.deltaTime;
        }
    }


    void OnTriggerEnter(Collider other)
    {
        timerCheck = true;
        if(timer >= 10)
        {
            timer = 10;
            ScreenOn.SetActive(true);
        }

    }

   
    void OnTriggerExit(Collider other)
    {
        timerCheck = false;
        timer = 0;
        
    }

    public IEnumerator CountD()
    {
        yield return new WaitForSeconds(10);
       
    }
}