using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsScreen : MonoBehaviour
{
    
    public Toggle fullscreenTog, vsyncTog;

    public List<resItem> resulutions = new List<resItem>();

    private int selectedResolution;
    

    // Start is called before the first frame update
    void Start()
    {

        fullscreenTog.isOn = Screen.fullScreen;

        if (QualitySettings.vSyncCount == 0)
        {
            vsyncTog.isOn = false;
        }
        else
        {
            vsyncTog.isOn = true;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void ResLeft()
    {

    }

    public void ResRight()
    {

    }


    public void ApplyGraphics()
    {
        Screen.fullScreen = fullscreenTog.isOn;

        if (vsyncTog.isOn)
        {
            QualitySettings.vSyncCount = 1;
        }
        else
        {
            QualitySettings.vSyncCount = 0;
        }

    }
    [System.Serializable]
    public class resItem 
    {

        public int horizontal, vertical;

    }

}
