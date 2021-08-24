using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public int soulsHeld;
    public int maxSoulsHeld;

    public int cultistsHealth;
    public int soulsRemained = 10;

    public int goodSoul;
    public int badSoul;

    private void Update()
    {
        if (Input.GetKeyDown("r"))
        {

            SceneManager.LoadScene(1);
        }
    }

    public void GotSouls(int q)
    {
        if (q == 1)
        {
            goodSoul += 1;
        }
        else
        {
            badSoul += q;
        }

        GameObject.Find("SoulBottle").GetComponent<SoulBottle>().SoulCnahge(0);
        GameObject.Find("Cultist").GetComponent<Cultist>().NomNom();
        GameObject.Find("OldGod").GetComponent<OldGod>().Eyes(badSoul, goodSoul, soulsRemained);
    }

    public void SoulPickedUp()
    {
        soulsRemained -= 1;

        if(soulsHeld < maxSoulsHeld)
        {
            soulsHeld += 1;
        }

        GameObject.Find("SoulBottle").GetComponent<SoulBottle>().SoulCnahge(soulsHeld);
    }

    public void Hurt()
    {
        cultistsHealth = cultistsHealth - 1; 
        GameObject.Find("SoulBottle").GetComponent<SoulBottle>().HealthChange(cultistsHealth);

        int rand = Random.Range(1, 3);

        GameObject.Find("SoulBottle").GetComponent<Animator>().Play("BottleShake");
        GameObject.Find("Main Camera").GetComponent<Animator>().Play("ScreenShake" + rand.ToString());
    }
}
;