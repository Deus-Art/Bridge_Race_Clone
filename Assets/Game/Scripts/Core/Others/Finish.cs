using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
   public GameObject win;
   public GameObject lose;
   public GameObject restart;
   private void OnTriggerEnter(Collider other) {

        if(other.CompareTag(GameConstant.BLUE_TAG)){
            win.SetActive(true);
            restart.SetActive(true);
            Invoke("TimeScaleIsZero", 2f);
        }

        if(other.CompareTag(GameConstant.RED_TAG) || other.CompareTag(GameConstant.GREEN_TAG) || other.CompareTag(GameConstant.YELLOW_TAG)){
            lose.SetActive(true);
            restart.SetActive(true);
            Invoke("TimeScaleIsZero", 1f);

        }
   }
   

   private void TimeScaleIsZero(){
        Time.timeScale = 0;
   }
}
