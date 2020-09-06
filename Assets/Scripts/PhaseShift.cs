using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PhaseShift : MonoBehaviour
{

    [SerializeField]
    RawImage rawImage;
    bool resetColor;
    float alphaValue=0;
    [SerializeField]
    GameObject subjectiveBlip;


    private void Update () {
        if (resetColor) {
            alphaValue += Time.deltaTime / 2;
            rawImage.color = new Color(1, 1, 1, alphaValue);
            if (alphaValue >= 1) {
                Destroy(subjectiveBlip);
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter (Collider other) {
        rawImage.color = new Color(1, 1, 1, 0);
        alphaValue = 0;
        resetColor = true;
    }

}
