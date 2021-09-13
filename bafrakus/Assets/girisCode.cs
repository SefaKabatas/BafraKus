using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class girisCode : MonoBehaviour
{
    public void giris()
    {
        SceneManager.LoadScene("Scenes/uygulama");
    }
    public void cıkıs()
    {
        Application.Quit();
    }
}
