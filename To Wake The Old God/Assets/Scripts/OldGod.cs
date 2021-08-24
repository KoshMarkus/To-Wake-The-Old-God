using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldGod : MonoBehaviour
{
    GameMaster GameMaster;
    public int goodEyes;
    public int badEyes;

    void Start()
    {
        GameMaster = GameObject.Find("GameMaster").GetComponent<GameMaster>();
    }

    //Когда коллайдеры культиста и бога сталкиваются
    void OnTriggerEnter2D(Collider2D col)
    {
        CollectSalt();

        if (col.gameObject.CompareTag("Cultist") && GameMaster.soulsHeld > 0)
        {
            GameMaster.GotSouls(GameMaster.soulsHeld);
            GameMaster.soulsHeld = 0;
        }
    }

    public void Eyes(int bad, int good, int all)
    {
        if (bad == badEyes)
        {
            gameObject.GetComponent<Animator>().Play("SoulTakeGood");
        }
        else
        {
            gameObject.GetComponent<Animator>().Play("SoulTakeBad");
        }

        goodEyes = good;
        badEyes = bad;

        switch (goodEyes)
        {
            case 1:
                GameObject.Find("Eye1").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                break;
            case 2:
                GameObject.Find("Eye1").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye2").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                break;
            case 3:
                GameObject.Find("Eye1").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye2").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye3").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                break;
            case 4:
                GameObject.Find("Eye1").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye2").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye3").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye4").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                break;
            case 5:
                GameObject.Find("Eye1").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye2").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye3").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye4").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye5").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                break;
            case 6:
                GameObject.Find("Eye1").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye2").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye3").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye4").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye5").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye10").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                break;
            case 7:
                GameObject.Find("Eye1").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye2").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye3").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye4").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye5").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye10").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye9").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                break;
            case 8:
                GameObject.Find("Eye1").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye2").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye3").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye4").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye5").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye10").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye9").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye8").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                break;
            case 9:
                GameObject.Find("Eye1").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye2").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye3").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye4").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye5").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye10").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye9").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye8").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye7").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                break;
            case 10:
                GameObject.Find("Eye1").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye2").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye3").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye4").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye5").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye10").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye9").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye8").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye7").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                GameObject.Find("Eye6").GetComponent<SpriteRenderer>().color = new Color(20f / 255f, 175f / 255f, 125f / 255f, 1);
                break;
        }   

        switch (badEyes)
        {
            case 1:
                GameObject.Find("Eye6").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                break;
            case 2:
                GameObject.Find("Eye6").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye7").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                break;
            case 3:
                GameObject.Find("Eye6").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye7").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye8").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                break;
            case 4:
                GameObject.Find("Eye6").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye7").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye8").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye9").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                break;
            case 5:
                GameObject.Find("Eye6").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye7").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye8").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye9").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye10").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                break;
            case 6:
                GameObject.Find("Eye6").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye7").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye8").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye9").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye10").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye5").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                break;
            case 7:
                GameObject.Find("Eye6").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye7").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye8").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye9").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye10").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye5").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye4").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                break;
            case 8:
                GameObject.Find("Eye6").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye7").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye8").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye9").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye10").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye5").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye4").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye3").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                break;
            case 9:
                GameObject.Find("Eye6").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye7").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye8").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye9").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye10").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye5").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye4").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye3").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye2").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                break;
            case 10:
                GameObject.Find("Eye6").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye7").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye8").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye9").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye10").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye5").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye4").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye3").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye2").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                GameObject.Find("Eye1").GetComponent<SpriteRenderer>().color = new Color(175f / 255f, 20f / 255f, 20f / 255f, 1);
                break;
        }

        if (badEyes > 0)
        {
            if (badEyes + goodEyes >= 10)
            {
                Destroy(GameObject.Find("FieldOfView"));
                Destroy(GameObject.Find("SoulBottle"));
                GameObject.Find("HurtReciever").GetComponent<Collider2D>().enabled = false;
                GameObject.Find("Lose").GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                GameObject.Find("Cultist").GetComponent<Cultist>().Lose();
            }
        }
        else if (goodEyes == 10)
        {
            Destroy(GameObject.Find("FieldOfView"));
            Destroy(GameObject.Find("SoulBottle"));
            GameObject.Find("HurtReciever").GetComponent<Collider2D>().enabled = false;
            GameObject.Find("KindaWin").GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            GameObject.Find("Cultist").GetComponent<Cultist>().KindaWin();
        }
        //else if (all == 10)
        //{
        //    GameObject.Find("Lose").GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        //}
    }

    void CollectSalt()
    {
        GameObject[] salts = GameObject.FindGameObjectsWithTag("Salt");

        for (var i = 0; i < salts.Length; i++)
        {
            Destroy(salts[i]);
        }
    }
}