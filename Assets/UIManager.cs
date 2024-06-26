using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class UIManager : MonoBehaviour
{
    public Animator startButton;
    public Animator settingsButton;
    public Animator dialog;
    public Animator contentPanel;
    public Animator gearImage;

    // Start is called before the first frame update

    public void StartGame() 
    {
        SceneManager.LoadScene("RocketMouse");
    }

    public void OpenSettings()
    {
        startButton.SetBool("isHidden", true);
        settingsButton.SetBool("isHidden", true);
        //..skipped..

        dialog.SetBool("isHidden", false);
    }

    public void CloseSettings()
    {
        startButton.SetBool("isHidden", false);
        settingsButton.SetBool("isHidden", false);
        dialog.SetBool("isHidden", true);
    }

    public void ToggleMenu() 
    {
        bool isHidden = contentPanel.GetBool("isHidden");
        contentPanel.SetBool("isHidden", !isHidden);
        //..skipped..

        gearImage.SetBool("isHidden", !isHidden);
    }

    // Update is called once per frame


}
