using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class ShakeTrigger : MonoBehaviour
{   
    public CameraShake cameraShake;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J)) {
            StartCoroutine(cameraShake.Shake(0.15f, 0.4f));
            //CameraShaker.Instance.ShakeOnce(4f, 4f, 0.1f, 1f);
        }
    }
}
