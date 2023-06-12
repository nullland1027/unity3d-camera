using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CInemachine : MonoBehaviour
{
    
    public GameObject front;
    public GameObject left;
    public GameObject behind;
    public GameObject right;
    public static int current_position;

    private bool isLock;

    void Start()
    {
        isLock = false;
        current_position = 0;  //0代表前面，1代表左边，2代表后面，3代表右边
    }

    // Update is called once per frame

    /**
    // void Update()
    // {
        
    //     if (Input.GetKeyDown(KeyCode.Q) && (current_position % 4 == 0)) {
    //         current_position++;
    //         StartCoroutine(ChangeDirOfCameraClockwise(current_position));
    //         front.SetActive(false);
    //         left.SetActive(true);
    //     }
    //     else if (Input.GetKeyDown(KeyCode.Q) && (current_position % 4 == 1)) {
    //         current_position++;
    //         left.SetActive(false);
    //         behind.SetActive(true);
    //     }
    //     else if (Input.GetKeyDown(KeyCode.Q) && (current_position % 4 == 2)) {
    //         current_position++;
    //         behind.SetActive(false);
    //         right.SetActive(true);
    //     }
    //     else if (Input.GetKeyDown(KeyCode.Q) && (current_position % 4 == 3)) {
    //         current_position++;
    //         right.SetActive(false);
    //         front.SetActive(true);
    //     }

    //     if (Input.GetKeyDown(KeyCode.E) && (current_position % 4 == 0)) {
    //         current_position += 3;
    //         front.SetActive(false);
    //         right.SetActive(true);
    //     }
    //     else if (Input.GetKeyDown(KeyCode.E) && (current_position % 4 == 1)){
    //         current_position += 3;
    //         left.SetActive(false);
    //         front.SetActive(true);
    //     }
    //     else if (Input.GetKeyDown(KeyCode.E) && (current_position % 4 == 2)){
    //         current_position += 3;
    //         behind.SetActive(false);
    //         left.SetActive(true);
    //     }
    //     else if (Input.GetKeyDown(KeyCode.E) && (current_position % 4 == 3)){
    //         current_position += 3;
    //         right.SetActive(false);
    //         behind.SetActive(true);
    //     }
    // }
    */
    void Update() {
        if (Input.GetKeyDown(KeyCode.Q) && (current_position % 4 == 0)) {
            StartCoroutine(ChangeDirOfCameraClockwise(current_position));
        }
        else if (Input.GetKeyDown(KeyCode.Q) && (current_position % 4 == 1)) {
            StartCoroutine(ChangeDirOfCameraClockwise(current_position));
        }
        else if (Input.GetKeyDown(KeyCode.Q) && (current_position % 4 == 2)) {
            StartCoroutine(ChangeDirOfCameraClockwise(current_position));
        }
        else if (Input.GetKeyDown(KeyCode.Q) && (current_position % 4 == 3)) {
            StartCoroutine(ChangeDirOfCameraClockwise(current_position));
        }

        if (Input.GetKeyDown(KeyCode.E) && (current_position % 4 == 0)) {
            StartCoroutine(ChangeDirOfCameraReverse(current_position));
        }
        else if (Input.GetKeyDown(KeyCode.E) && (current_position % 4 == 1)){
            StartCoroutine(ChangeDirOfCameraReverse(current_position));
        }
        else if (Input.GetKeyDown(KeyCode.E) && (current_position % 4 == 2)){
           StartCoroutine(ChangeDirOfCameraReverse(current_position));
        }
        else if (Input.GetKeyDown(KeyCode.E) && (current_position % 4 == 3)){
            StartCoroutine(ChangeDirOfCameraReverse(current_position));
        }
    }
    IEnumerator ChangeDirOfCameraClockwise(int currentP)
    {
        if (isLock)
            yield break;
        
        isLock = true;
        if (currentP % 4 == 0) {
            front.SetActive(false);
            left.SetActive(true);
            current_position++;
        } else if (currentP % 4 == 1) {
            left.SetActive(false);
            behind.SetActive(true);
            current_position++;
        } else if (currentP % 4 == 2) {
            behind.SetActive(false);
            right.SetActive(true);
            current_position++;
        } else if (currentP % 4 == 3) {
            right.SetActive(false);
            front.SetActive(true);
            current_position++;
        }
        yield return new WaitForSeconds(1f);
        isLock = false;
    }

    IEnumerator ChangeDirOfCameraReverse(int currentP)
    {
        if (isLock)
            yield break;
        
        isLock = true;
        if (currentP % 4 == 0) {
            front.SetActive(false);
            right.SetActive(true);
            current_position += 3;
        } else if (currentP % 4 == 1) {
            left.SetActive(false);
            front.SetActive(true);
            current_position += 3;
        } else if (currentP % 4 == 2) {
            behind.SetActive(false);
            left.SetActive(true);
            current_position += 3;
        } else if (currentP % 4 == 3) {
            right.SetActive(false);
            behind.SetActive(true);
            current_position += 3;
        }
        yield return new WaitForSeconds(1f);
        isLock = false;
    }
}
