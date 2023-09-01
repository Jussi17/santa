using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Home : MonoBehaviour
{
    public Image homeImage;
    public void OnHomeClick()
    {
        homeImage.color = Color.green;
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

}
