using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ParentChildInterchange : MonoBehaviour
{
    //public Transform cube;
    //public GameObject child;
    //public Transform parent;

    public void Start()
    {
        //child.transform.SetParent(cube);
        //child.gameObject.SetActive(false);
        //parent.transform.SetParent(child);
        // transform.SetParent(newParent,false);


        //cube=this.gameObject.transform.GetChild(0);
        //child= this.gameObject.transform.GetChild(0).GetChild(0).GetChild(0).gameObject;
        //child.SetActive(false);


        //Transform[] allchild = transform.GetComponentsInChildren<Transform>();
        //foreach (Transform i in allchild)
        //{
        //    if (i != transform)
        //    {
        //        Debug.Log("Found child: " + i.name);
        //        if (i.name == "Child (2)")
        //        {
        //            i.gameObject.SetActive(false);
        //        }



        //    }
        //}
        // GameObject.Find("Child (2)").SetActive(false);

       int index = transform.GetSiblingIndex();
        //GameObject.Find("transform.GetSiblingIndex()");
        //Debug.Log("Initial Sibling Index: " + index);

        //Set a new sibling index
        transform.SetSiblingIndex(2);
        Debug.Log("New Sibling Index: " + transform.GetSiblingIndex());

    }

}
