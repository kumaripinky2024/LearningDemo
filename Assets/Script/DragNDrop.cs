using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DragNDrop : MonoBehaviour
{
    private Vector3 o;
    private float zc;
    void OnMouseDown()
    {
       zc = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        o = gameObject.transform.position - GetMouseWorldPos();
    }
    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + o;
       // Debug.Log(transform.position+"");
    }
    Vector3 GetMouseWorldPos()
    {
      //  Debug.Log("pt22");
        Vector3 mousePt=Input.mousePosition;
        mousePt.z = zc;
        return Camera.main.ScreenToWorldPoint(mousePt);
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            GetComponent<Collider>().enabled = false;
            //Destroy(collision.gameObject);
            Debug.Log("hi");
        }
    }
}
