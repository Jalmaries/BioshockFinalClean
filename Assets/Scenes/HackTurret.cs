using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackTurret : MonoBehaviour
{

    public float sec = 2f;
    public float secOne = 3f;
    public GameObject sec1;
    public GameObject sec2;
    public GameObject sec3;
    public GameObject sec4;


    void Update()
    {

        //if (Input.GetKeyDown(KeyCode.H) && GetComponent<vp_SecurityCamTurret>())
        //{
        //    Destroy(GetComponent<vp_SecurityCamTurret>());
        //}

        if (Input.GetKeyDown(KeyCode.H) && GetComponent<vp_SecurityCamTurret>())
        {
            sec1.SetActive(true);
            StartCoroutine(LateCall());

        }
    }

    IEnumerator LateCall()
    {

        yield return new WaitForSeconds(sec);

        sec1.SetActive(false);
        sec2.SetActive(true);

        yield return new WaitForSeconds(sec);

        sec2.SetActive(false);
        sec3.SetActive(true);

        yield return new WaitForSeconds(sec);

        sec3.SetActive(false);
        sec4.SetActive(true);
        Destroy(GetComponent<vp_SecurityCamTurret>());

        yield return new WaitForSeconds(secOne);

        sec4.SetActive(false);

    }

}

