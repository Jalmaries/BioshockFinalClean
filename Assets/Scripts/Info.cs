using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    public GameObject instructions;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            instructions.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            instructions.SetActive(false);
        }
    }
}
