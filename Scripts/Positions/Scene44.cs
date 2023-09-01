using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene44 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerPrefs.SetString("16", "16");
            PlayerPrefs.DeleteKey("1");
            PlayerPrefs.DeleteKey("2");
            PlayerPrefs.DeleteKey("3");
            PlayerPrefs.DeleteKey("4");
            PlayerPrefs.DeleteKey("5");
            PlayerPrefs.DeleteKey("6");
            PlayerPrefs.DeleteKey("7");
            PlayerPrefs.DeleteKey("8");
            PlayerPrefs.DeleteKey("9");
            PlayerPrefs.DeleteKey("10");
            PlayerPrefs.DeleteKey("11");
            PlayerPrefs.DeleteKey("12");
            PlayerPrefs.DeleteKey("13");
            PlayerPrefs.DeleteKey("14");
            PlayerPrefs.DeleteKey("15");
            PlayerPrefs.DeleteKey("17");
            PlayerPrefs.DeleteKey("18");
            PlayerPrefs.DeleteKey("19");
            PlayerPrefs.DeleteKey("20");
            PlayerPrefs.DeleteKey("21");
            PlayerPrefs.DeleteKey("22");
            PlayerPrefs.DeleteKey("23");
            PlayerPrefs.DeleteKey("24");
            PlayerPrefs.DeleteKey("25");
            PlayerPrefs.DeleteKey("26");
            PlayerPrefs.DeleteKey("27");
            PlayerPrefs.DeleteKey("28");
            PlayerPrefs.DeleteKey("29");
            PlayerPrefs.DeleteKey("30");
            PlayerPrefs.DeleteKey("31");
            PlayerPrefs.DeleteKey("32");
            PlayerPrefs.DeleteKey("33");
            PlayerPrefs.DeleteKey("34");
            PlayerPrefs.DeleteKey("35");
        }
    }
}
