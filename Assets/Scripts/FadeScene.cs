using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeScene : MonoBehaviour
{

    public Image blackFade;
    // Start is called before the first frame update
    void Start()
    {
        blackFade.canvasRenderer.SetAlpha(0.0f);

        fadeIn();
    }

    // Update is called once per frame
    void fadeIn()
    {
        blackFade.CrossFadeAlpha(1, 5, false);
    }
}
