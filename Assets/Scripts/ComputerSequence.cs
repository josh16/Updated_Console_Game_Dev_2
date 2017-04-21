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

    public bool win = false;

    public GameObject ScreenOnMid;
    public GameObject ScreenOnL;
    public GameObject ScreenOnR;
    public GameObject ScreenOnMain;
    public GameObject Gate1;
    public GameObject Gate2;


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
        if (timer >= 5)
        {

            ScreenOn.SetActive(true);
        }
        if (ScreenOnR.activeSelf&& ScreenOnL.activeSelf && ScreenOnMid.activeSelf && ScreenOnMain.activeSelf)
        {
            win = true;
            Destroy(Gate1);
            Destroy(Gate2);
        }
        
    }


    void OnTriggerEnter(Collider other)
    {
        timerCheck = true;
    }

   
    void OnTriggerExit(Collider other)
    {
        timerCheck = false;
        timer = 0;
        
    }

    public IEnumerator CountD()
    {
        yield return new WaitForSeconds(5);
       
    }
}