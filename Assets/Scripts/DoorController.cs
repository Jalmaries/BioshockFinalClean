using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{

    [SerializeField] private Animator myAnimationController;
    public GameObject instructions;
    public GameObject light;
    public Image blackFade;
    public GameObject blackImage;

    private void OnTriggerEnter(Collider other)
    {
        if( other.CompareTag("Player"))
        {
            instructions.SetActive(true);
            light.SetActive(true);
            myAnimationController.SetBool("OpenClose", true);
            blackImage.SetActive(true);
            blackFade.canvasRenderer.SetAlpha(0.0f);

            fadeIn();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            light.SetActive(false);
            instructions.SetActive(false);
        }
    }

    void fadeIn()
    {
        blackFade.CrossFadeAlpha(1, 4, false);
    }
}
