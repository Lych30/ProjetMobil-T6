using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class candleScript : MonoBehaviour
{
    BoxCollider2D boxcol;
    [SerializeField]bool isactivated = false;
    public void OnMouseUpAsButton()
    {
        if(!isactivated)
        {
            boxcol = gameObject.AddComponent<BoxCollider2D>() as BoxCollider2D;
            boxcol.size = new Vector3(10, 10, 3);
            AstarPath.active.Scan();
            GetComponent<Animator>().SetTrigger("Off");
           /* foreach(Transform child in transform)
            {
                child.gameObject.SetActive(false);
            }*/
            isactivated = true;
        }
        
    }
}
