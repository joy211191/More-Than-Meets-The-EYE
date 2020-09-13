using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PhaseShift : MonoBehaviour
{

    [SerializeField]
    GameObject subjectiveBlip;
    RealityShifter realityShifter;


    void Awake () {
        realityShifter = FindObjectOfType<RealityShifter>();
    }


    private void OnTriggerEnter (Collider other) {
        realityShifter.UpdateBlips();
        Destroy(subjectiveBlip);
        Destroy(gameObject);
    }

}
