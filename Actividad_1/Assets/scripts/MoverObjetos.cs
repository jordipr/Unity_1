using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverObjetos : MonoBehaviour { 


    public Transform[] objetos;
    public Vector3[] posicion;

    // Start is called before the first frame update
    void Start()
    {
        posicion = new Vector3[]{
            Vector3.right,
            Vector3.right,
            Vector3.right,
            Vector3.right
        };

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z"))
        {

            objetos[0].transform.position += Vector3.right;


        }else if (Input.GetKeyDown("x"))
        {


            objetos[1].transform.position += Vector3.right;



        }else if (Input.GetKeyDown("c"))
        {
            objetos[2].transform.position += Vector3.right;
        
        
        }else if (Input.GetKeyDown("v"))
        {

            objetos[3].transform.position += Vector3.right;



        }else if (Input.GetKeyDown("b"))
        {

            objetos[4].transform.position += Vector3.right;


        }


        
    }
}
