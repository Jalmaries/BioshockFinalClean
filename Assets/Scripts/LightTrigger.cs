using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightTrigger : MonoBehaviour
{
    public GameObject secondLight;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            secondLight.SetActive(true);
            
        }
    }

}
