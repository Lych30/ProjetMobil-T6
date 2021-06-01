using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class biblioScipt : MonoBehaviour
{
    private void OnMouseUpAsButton()
    {
        if (GameManager.StaticMaxTrap > 0)
        {
        GetComponent<Animator>().SetTrigger("fall");
        GetComponent<BoxCollider2D>().offset = new Vector2(GetComponent<BoxCollider2D>().offset.x, -2.63f);
        GameManager.StaticMaxTrap--;
            GameObject.Find("GameManager").GetComponent<GameManager>().UpdateUiText();
            AstarPath.active.Scan();
        }

    }
}
