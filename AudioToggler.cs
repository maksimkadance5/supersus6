using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioToggler : MonoBehaviour
{
    public bool isOn; // это свойство будет указывать включен сейчас звук или нет 

    private void Start()
    {

        isOn = true; // по умолчанию включен 


    }


    public void OnOffSounds() 
    {
        if (!isOn) // если звук выкл тоооо вкл
        {
            AudioListener.volume = 1f; // свойство будет вкл и выкл звук в игре
            isOn = true;  
        }else if (isOn) //если вкл то выключаем
         {
            AudioListener.volume = 0f; // весь звук будет выкл
            isOn = false;
         }

    }






}
