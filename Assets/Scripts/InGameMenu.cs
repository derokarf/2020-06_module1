using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InGameMenu: MonoBehaviour
{
    public void StartAgain() {
        LoadingScreen.instance.LoadScene(SceneManager.GetActiveScene().name);
        // LoadingScreen.instance.LoadScene("Level1");
    }

    public void ExitToMenu() {
        LoadingScreen.instance.LoadScene("MainMenu");        
    }

    
}
