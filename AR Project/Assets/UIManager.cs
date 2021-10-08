using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Animator anim;

    private bool panelUp = false;
    
    public void MovePanel()
    {
        panelUp = !panelUp;
        anim.SetBool("PanelUp", panelUp);
    }
}
