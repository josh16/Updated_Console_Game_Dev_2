using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BlinkingLights : MonoBehaviour
{

    public Material LightOn;
    public Material LightOff;
    public float offSetTime = 1;
    public List<Transform> theLightObjects;

    // Use this for initialization
    void Start()
    {
        theLightObjects = new List<Transform>();
        foreach (Transform child in transform)
        {
            theLightObjects.Add(child);
        }
        theLightObjects.OrderBy(wp => wp.name);
        StartCoroutine(Blink());


    }

    IEnumerator Blink()
    {
        while (true)
        {
            for (int i = 0; i < theLightObjects.Count; i++)
            {
                theLightObjects[i].GetComponent<Renderer>().material = LightOn;
                theLightObjects[i].GetChild(0).GetComponent<Light>().enabled = true;
                yield return new WaitForSeconds(offSetTime);
                theLightObjects[i].GetComponent<Renderer>().material = LightOff;
                theLightObjects[i].GetChild(0).GetComponent<Light>().enabled = false;

            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}