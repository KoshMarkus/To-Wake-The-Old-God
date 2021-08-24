using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salt : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Cultist"))
        {
            gameObject.tag = "Salt";
        }
    }
}
