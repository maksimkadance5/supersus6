using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioToggler : MonoBehaviour
{
    public bool isOn; // ýòî ñâîéñòâî áóäåò óêàçûâàòü âêëþ÷åí ñåé÷àñ çâóê èëè íåò 

    private void Start()
    {

        isOn = true; // ïî óìîë÷àíèþ âêëþ÷åí 

//23
    }


    public void OnOffSounds() 
    {
        if (!isOn) // åñëè çâóê âûêë òîîîî âêë
        {
            AudioListener.volume = 1f; // ñâîéñòâî áóäåò âêë è âûêë çâóê â èãðå
            isOn = true;  
        }else if (isOn) //åñëè âêë òî âûêëþ÷àåì
         {
            AudioListener.volume = 0f; // âåñü çâóê áóäåò âûêë
            isOn = false;
         }

    }






}
