using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMouseHover : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnMouseUp()
    {
        SceneManager.LoadScene("Labyrinth");
    }

    private void OnMouseEnter()
    {
        spriteRenderer.color = new Color(1, 1, 1);
    }

    private void OnMouseExit()
    {
        spriteRenderer.color = new Color(150f/255f, 69f/255f, 182f/255f);
    }
}
