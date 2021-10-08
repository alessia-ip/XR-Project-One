using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visible : MonoBehaviour
{
   public GameObject canvas;
   
   GameObject card = null;
   
   private void Update()
   {
      card = GameObject.FindWithTag("Collection");
//      Debug.Log(card);
      if (card != null)
      {
         canvas.SetActive(true);
      }
      else
      {
         canvas.SetActive(false);
      }
   }
}
