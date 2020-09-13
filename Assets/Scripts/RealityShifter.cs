using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RealityShifter : MonoBehaviour
{
    public AnimationCurve animationCurve;
    public int blipsCollected;
    public float multiplier;
    [SerializeField]
    RawImage rawImage;
    [SerializeField]
    bool resetColor;
    float alphaValue = 0;
    [SerializeField]
    float maxTime;
    float timer;

    private void Awake () {
        timer = maxTime;
    }

    public void UpdateBlips () {
        rawImage.color = new Color(1, 1, 1, 0);
        alphaValue = 0;
        blipsCollected++;
        resetColor = true;
        timer = maxTime;
    }



    private void Update () {
        if (resetColor) {
            timer -= Time.deltaTime;
            if (timer <= 0)
                resetColor = false;
        }
        if (timer<=0) {
            if (alphaValue < animationCurve.Evaluate((float)blipsCollected)) {
                alphaValue += Time.deltaTime / multiplier;
                rawImage.color = new Color(1, 1, 1, alphaValue);
            }
            if (alphaValue >= animationCurve.Evaluate((float)blipsCollected)) {
                resetColor = false;
            }
        }
    }
}
