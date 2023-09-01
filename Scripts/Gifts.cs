using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;


public class Gifts : MonoBehaviour
{
    public int gifts = 0;
    [SerializeField] public Text giftText;

    void Start()
    {
        gifts = PlayerPrefs.GetInt("gifts");
        giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("Gift1") && !PlayerPrefs.HasKey("HasPlayed1"))
        {    
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed1", "HasPlayed1");
        }
        if (PlayerPrefs.HasKey("Gift2") && !PlayerPrefs.HasKey("HasPlayed2"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed2", "HasPlayed2");
        }
        if (PlayerPrefs.HasKey("Gift3") && !PlayerPrefs.HasKey("HasPlayed3"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed3", "HasPlayed3");
        }
        if (PlayerPrefs.HasKey("Gift4") && !PlayerPrefs.HasKey("HasPlayed4"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed4", "HasPlayed4");
        }

        if (PlayerPrefs.HasKey("Gift5") && !PlayerPrefs.HasKey("HasPlayed5"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed5", "HasPlayed5");
        }
        if (PlayerPrefs.HasKey("Gift6") && !PlayerPrefs.HasKey("HasPlayed6"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed6", "HasPlayed6");
        }
        if (PlayerPrefs.HasKey("Gift7") && !PlayerPrefs.HasKey("HasPlayed7"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed7", "HasPlayed7");
        }
        if (PlayerPrefs.HasKey("Gift8") && !PlayerPrefs.HasKey("HasPlayed8"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed8", "HasPlayed8");
        }
        if (PlayerPrefs.HasKey("Gift9") && !PlayerPrefs.HasKey("HasPlayed9"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed9", "HasPlayed9");
        }
        if (PlayerPrefs.HasKey("Gift10") && !PlayerPrefs.HasKey("HasPlayed10"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed10", "HasPlayed10");
        }

        if (PlayerPrefs.HasKey("Gift11") && !PlayerPrefs.HasKey("HasPlayed11"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed11", "HasPlayed11");
        }
        if (PlayerPrefs.HasKey("Gift12") && !PlayerPrefs.HasKey("HasPlayed12"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed12", "HasPlayed12");
        }

        if (PlayerPrefs.HasKey("Gift13") && !PlayerPrefs.HasKey("HasPlayed13"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed13", "HasPlayed13");
        }
        if (PlayerPrefs.HasKey("Gift14") && !PlayerPrefs.HasKey("HasPlayed14"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed14", "HasPlayed14");
        }
        if (PlayerPrefs.HasKey("Gift15") && !PlayerPrefs.HasKey("HasPlayed15"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed15", "HasPlayed15");
        }
        if (PlayerPrefs.HasKey("Gift16") && !PlayerPrefs.HasKey("HasPlayed16"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed16", "HasPlayed16");
        }
        if (PlayerPrefs.HasKey("Gift17") && !PlayerPrefs.HasKey("HasPlayed17"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed17", "HasPlayed17");
        }
        if (PlayerPrefs.HasKey("Gift18") && !PlayerPrefs.HasKey("HasPlayed18"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed18", "HasPlayed18");
        }

        if (PlayerPrefs.HasKey("Gift19") && !PlayerPrefs.HasKey("HasPlayed19"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed19", "HasPlayed19");
        }
        if (PlayerPrefs.HasKey("Gift20") && !PlayerPrefs.HasKey("HasPlayed20"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed20", "HasPlayed20");
        }
        if (PlayerPrefs.HasKey("Gift21") && !PlayerPrefs.HasKey("HasPlayed21"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed21", "HasPlayed21");
        }
        if (PlayerPrefs.HasKey("Gift22") && !PlayerPrefs.HasKey("HasPlayed22"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed22", "HasPlayed22");
        }
        if (PlayerPrefs.HasKey("Gift23") && !PlayerPrefs.HasKey("HasPlayed23"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed23", "HasPlayed23");
        }
        if (PlayerPrefs.HasKey("Gift24") && !PlayerPrefs.HasKey("HasPlayed24"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed24", "HasPlayed24");
        }

        if (PlayerPrefs.HasKey("Gift25") && !PlayerPrefs.HasKey("HasPlayed25"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed25", "HasPlayed25");
        }
        if (PlayerPrefs.HasKey("Gift26") && !PlayerPrefs.HasKey("HasPlayed26"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed26", "HasPlayed26");
        }
        if (PlayerPrefs.HasKey("Gift27") && !PlayerPrefs.HasKey("HasPlayed27"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed27", "HasPlayed27");
        }
        if (PlayerPrefs.HasKey("Gift28") && !PlayerPrefs.HasKey("HasPlayed28"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed28", "HasPlayed28");
        }
        if (PlayerPrefs.HasKey("Gift29") && !PlayerPrefs.HasKey("HasPlayed29"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed29", "HasPlayed29");
        }
        if (PlayerPrefs.HasKey("Gift30") && !PlayerPrefs.HasKey("HasPlayed30"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed30", "HasPlayed30");
        }

        if (PlayerPrefs.HasKey("Gift31") && !PlayerPrefs.HasKey("HasPlayed31"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed31", "HasPlayed31");
        }
        if (PlayerPrefs.HasKey("Gift32") && !PlayerPrefs.HasKey("HasPlayed32"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed32", "HasPlayed32");
        }

        if (PlayerPrefs.HasKey("Gift33") && !PlayerPrefs.HasKey("HasPlayed33"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed33", "HasPlayed33");
        }
        if (PlayerPrefs.HasKey("Gift34") && !PlayerPrefs.HasKey("HasPlayed34"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed34", "HasPlayed34");
        }
        if (PlayerPrefs.HasKey("Gift35") && !PlayerPrefs.HasKey("HasPlayed35"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed35", "HasPlayed35");
        }
        if (PlayerPrefs.HasKey("Gift36") && !PlayerPrefs.HasKey("HasPlayed36"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed36", "HasPlayed36");
        }
        if (PlayerPrefs.HasKey("Gift37") && !PlayerPrefs.HasKey("HasPlayed37"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed37", "HasPlayed37");
        }
        if (PlayerPrefs.HasKey("Gift38") && !PlayerPrefs.HasKey("HasPlayed38"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed38", "HasPlayed38");
        }

        if (PlayerPrefs.HasKey("Gift39") && !PlayerPrefs.HasKey("HasPlayed39"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed39", "HasPlayed39");
        }
        if (PlayerPrefs.HasKey("Gift40") && !PlayerPrefs.HasKey("HasPlayed40"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed40", "HasPlayed40");
        }
        if (PlayerPrefs.HasKey("Gift41") && !PlayerPrefs.HasKey("HasPlayed41"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed41", "HasPlayed41");
        }
        if (PlayerPrefs.HasKey("Gift42") && !PlayerPrefs.HasKey("HasPlayed42"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed42", "HasPlayed42");
        }
        if (PlayerPrefs.HasKey("Gift43") && !PlayerPrefs.HasKey("HasPlayed43"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed43", "HasPlayed43");
        }
        if (PlayerPrefs.HasKey("Gift44") && !PlayerPrefs.HasKey("HasPlayed44"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed44", "HasPlayed44");
        }

        if (PlayerPrefs.HasKey("Gift45") && !PlayerPrefs.HasKey("HasPlayed45"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed45", "HasPlayed45");
        }
        if (PlayerPrefs.HasKey("Gift46") && !PlayerPrefs.HasKey("HasPlayed46"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed46", "HasPlayed46");
        }
        if (PlayerPrefs.HasKey("Gift47") && !PlayerPrefs.HasKey("HasPlayed47"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed47", "HasPlayed47");
        }
        if (PlayerPrefs.HasKey("Gift48") && !PlayerPrefs.HasKey("HasPlayed48"))
        {
            gifts++;
            PlayerPrefs.SetInt("gifts", gifts);
            giftText.text = PlayerPrefs.GetInt("gifts", gifts) + " / 48";
            PlayerPrefs.SetString("HasPlayed48", "HasPlayed48");
        }
        if (PlayerPrefs.HasKey("Gift1") && PlayerPrefs.HasKey("Gift2") && PlayerPrefs.HasKey("Gift3") && PlayerPrefs.HasKey("Gift4") && PlayerPrefs.HasKey("Gift5") && PlayerPrefs.HasKey("Gift6") && PlayerPrefs.HasKey("Gift7") && PlayerPrefs.HasKey("Gift8") && PlayerPrefs.HasKey("Gift9") && PlayerPrefs.HasKey("Gift10") && PlayerPrefs.HasKey("Gift11") && PlayerPrefs.HasKey("Gift12") && PlayerPrefs.HasKey("Gift13") && PlayerPrefs.HasKey("Gift14") && PlayerPrefs.HasKey("Gift15") && PlayerPrefs.HasKey("Gift16") && PlayerPrefs.HasKey("Gift17") && PlayerPrefs.HasKey("Gift18") && PlayerPrefs.HasKey("Gift19") && PlayerPrefs.HasKey("Gift20") && PlayerPrefs.HasKey("Gift21") && PlayerPrefs.HasKey("Gift22") && PlayerPrefs.HasKey("Gift23") && PlayerPrefs.HasKey("Gift24") && PlayerPrefs.HasKey("Gift25") && PlayerPrefs.HasKey("Gift26") && PlayerPrefs.HasKey("Gift27") && PlayerPrefs.HasKey("Gift28") && PlayerPrefs.HasKey("Gift29") && PlayerPrefs.HasKey("Gift30") && PlayerPrefs.HasKey("Gift31") && PlayerPrefs.HasKey("Gift32") && PlayerPrefs.HasKey("Gift33") && PlayerPrefs.HasKey("Gift34") && PlayerPrefs.HasKey("Gift35") && PlayerPrefs.HasKey("Gift36") && PlayerPrefs.HasKey("Gift37") && PlayerPrefs.HasKey("Gift38") && PlayerPrefs.HasKey("Gift39") && PlayerPrefs.HasKey("Gift40") && PlayerPrefs.HasKey("Gift41") && PlayerPrefs.HasKey("Gift42") && PlayerPrefs.HasKey("Gift43") && PlayerPrefs.HasKey("Gift44") && PlayerPrefs.HasKey("Gift45") && PlayerPrefs.HasKey("Gift46") && PlayerPrefs.HasKey("Gift47") && PlayerPrefs.HasKey("Gift48"))
        {
            giftText.color = Color.green;
            giftText.text = "x " + PlayerPrefs.GetInt("gifts", gifts);
        }

    }
}