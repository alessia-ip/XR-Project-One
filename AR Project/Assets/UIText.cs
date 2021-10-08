using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIText : MonoBehaviour
{

    public int UINum = 0;
    
    public Text cardText;

    
    // Start is called before the first frame update
    void Start()
    {

        UpdateUIText();
    }

    public void ChangeUINum(int dir)
    {
        UINum = UINum + dir;
        if (UINum < 0)
        {
            UINum = 4;
        } else if (UINum > 4)
        {
            UINum = 0;
        }
        UpdateUIText();
    }
    
    void UpdateUIText()
    {
        Debug.Log(UINum);
        if (UINum == 0)
        {
            cardText.text =
                "Cetus is known as the sea monster. It is fierce, and not to be trifled with. It will devour all in its path.";
        } else if (UINum == 1)
        {
            cardText.text =
                "Aquarius is the water carrier of the sky. Bearing a cup, water flows forth at its whim.";
        }else if (UINum == 2)
        {
            cardText.text = "Capricorn is a creature no mortal shall lay their true eyes on. The sea goat watches with keen, fathomless eyes.";
        }else if (UINum == 3)
        {
            cardText.text = "Delphinus is a cunning dolphin. Fickle in its ways, it may hinder or help on a whim.";
        }else if (UINum == 4)
        {
            cardText.text = "This Hydra is far out of reach, its heads few from the lack of mortal blades that do not reach.";
        }
    }
}
