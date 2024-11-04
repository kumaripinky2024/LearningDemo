using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsRacastTest : MonoBehaviour
{
    //public LayerMask lm;
    //public Ray r;
    void FixedUpdate()
    {
       // print(r.GetPoint(3));

        //Vector3 fw = transform.TransformDirection(Vector3.forward);
        //if (Physics.Raycast(this.transform.position,fw,50))
        //{
        //    Debug.DrawRay(this.transform.position, Vector3.right);// * h.distance, Color.red);
        //}
        //Ray r =new Ray(transform.position,transform.forward);
        //RaycastHit h;
        //if (Physics.Raycast(r, out h))//(this.transform.position, Vector3.right, out h, 50,lm))
        //{
        //   // Debug.Log(r.GetPoint(10));
        //    Debug.Log(h.collider.gameObject.name);
        //    Debug.DrawRay(this.transform.position, Vector3.right * h.distance, Color.red);

        //   //  Destroy(h.collider.gameObject);



        //}
        //else
        //{
        //    Debug.DrawRay(this.transform.position, Vector3.right * 50, Color.white);
        //}

        //28/10/24
        // raycaste in forward dir
        //Vector3 fr = transform.TransformDirection(Vector3.forward);
        //if (Physics.Raycast(transform.position, fr ,1000f))
        //{
        //    Debug.Log("game object detected");
        //}

        //distance b/w origin to detect collider
        //RaycastHit hit;
        //if (Physics.Raycast(transform.position,Vector3.right,out hit))
        //{
        //    print(hit.distance);
        //}

        //use Ray provides origin and dir
        //Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
        //if(Physics.Raycast(r,10))
        //{
        //    print("hi");
        //}

        //draw ray line where collision detected
        //Ray r=Camera.main.ScreenPointToRay(Input.mousePosition);
        //RaycastHit h;
        //if(Physics.Raycast(r,out h,10f))
        //{
        //   // Debug.DrawLine(r.origin, h.point,Color.red);
        //   Debug.DrawRay(r.origin,h.point, Color.yellow);
        //}
    }
    void Update()
    {
        ColorChange();
        //    RaycastHit hit;
        //    if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
        //        return;

        //    MeshCollider meshCollider = hit.collider as MeshCollider;
        //    if (meshCollider == null || meshCollider.sharedMesh == null)
        //        return;

        //    Mesh mesh = meshCollider.sharedMesh;
        //    Vector3[] normals = mesh.normals;
        //    int[] triangles = mesh.triangles;
        //    Vector3 n0 = normals[triangles[hit.triangleIndex * 3 + 0]];
        //    Vector3 n1 = normals[triangles[hit.triangleIndex * 3 + 1]];
        //    Vector3 n2 = normals[triangles[hit.triangleIndex * 3 + 2]];
        //    Vector3 baryCenter = hit.barycentricCoordinate;
        //    Vector3 interpolatedNormal = n0 * baryCenter.x + n1 * baryCenter.y + n2 * baryCenter.z;
        //    interpolatedNormal = interpolatedNormal.normalized;
        //    Transform hitTransform = hit.collider.transform;
        //    interpolatedNormal = hitTransform.TransformDirection(interpolatedNormal);
        //    Debug.DrawRay(hit.point, interpolatedNormal);
    }
    Renderer r;
    void ColorChange()
    {
        if(Input.GetKey(KeyCode.Space))
        {
        r = GetComponent<MeshRenderer>();
        r.material.color = Color.red;
        }
    }
    //private void Start()
    //{
    //    ColorChange();
    //}

}
