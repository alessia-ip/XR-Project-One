using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
   private void OnBecameInvisible()
   {
      Debug.Log("YOU CAN'T SEE ME");
   }
}
