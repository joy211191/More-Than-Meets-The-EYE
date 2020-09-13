using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RealityShifter : MonoBehaviour
{
    public AnimationCurve animationCurve;
    public int blipsCollected;
    public RawImage rawImage;
    public float multiplier;

    public void UpdateBlips () {
        blipsCollected++;
        rawImage.color = new Color(1, 1, 1, animationCurve.Evaluate((float)blipsCollected));
    }
}
