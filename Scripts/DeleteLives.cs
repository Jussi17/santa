using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteLives : MonoBehaviour
{
   public void OnDeleteClick()
    {
        PlayerPrefs.DeleteKey("LifeYes");
        PlayerPrefs.DeleteKey("NinetyNine");
        PlayerPrefs.DeleteKey("Note");
    }
}
