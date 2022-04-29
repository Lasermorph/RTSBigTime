using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OptionsScreen : MonoBehaviour
{
    
    public Toggle fullscreenTog, vsyncTog;

    public List<resItem> resulutions = new List<resItem>();

    private int selectedResolution;


    public TMP_Text resulutionLabel;
    

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
        selectedResolution--;
        if(selectedResolution < 0)
        {
            selectedResolution = 0;
        }

        UpdateResLabel();
    }

    public void ResRight()
    {
        selectedResolution++;
        if(selectedResolution >resulutions.Count -1)
        {
            selectedResolution = resulutions.Count -1;

        } 
        UpdateResLabel();
    }

    public void UpdateResLabel()
    {

        resulutionLabel.text = resulutions[selectedResolution].horizontal.ToString()+ " x " + resulutions[selectedResolution].vertical.ToString(); 

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
