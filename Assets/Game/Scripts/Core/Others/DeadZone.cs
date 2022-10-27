using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DeadZone : MonoBehaviour
{   
    public GameObject lose;
    public GameObject restart;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag(GameConstant.DEAD_TAG)){
            lose.SetActive(true);
            Time.timeScale = 0;
            restart.SetActive(true);
        }
    }
}
