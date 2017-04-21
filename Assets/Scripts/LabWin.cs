using UnityEngine;
using System.Collections;

public class LabWin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Application.LoadLevel("Win");

        }
    }
}