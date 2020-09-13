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
    RealityShifter realityShifter;


    void Awake () {
        realityShifter = FindObjectOfType<RealityShifter>();
    }

    private void Update () {
        if (resetColor) {
            if (alphaValue < realityShifter.animationCurve.Evaluate((float)realityShifter.blipsCollected)) {
                alphaValue += Time.deltaTime / realityShifter.multiplier;
                rawImage.color = new Color(1, 1, 1, alphaValue);
            }
            if (alphaValue >= realityShifter.animationCurve.Evaluate((float)realityShifter.blipsCollected)) {
                Destroy(subjectiveBlip);
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter (Collider other) {
        rawImage.color = new Color(1, 1, 1, 0);
        alphaValue = 0;
        resetColor = true;
        realityShifter.UpdateBlips();
    }

}
