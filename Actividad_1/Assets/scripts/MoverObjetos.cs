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
    void Update(){

      
            

            if (Input.GetKeyDown("z"))
            {

                objetos[0].transform.position += Vector3.right;


            }
            else if (Input.GetKeyDown("x"))
            {


                objetos[1].transform.position += Vector3.right;



            }
            else if (Input.GetKeyDown("c"))
            {
                objetos[2].transform.position += Vector3.right;


            }
            else if (Input.GetKeyDown("v"))
            {

                objetos[3].transform.position += Vector3.right;



            }
            else if (Input.GetKeyDown("b"))
            {

                objetos[4].transform.position += Vector3.right;


            }
            else if (Input.GetKeyDown("q"))
            {

                objetos[0].transform.position += Vector3.left;


            }
            else if (Input.GetKeyDown("w"))
            {

                objetos[1].transform.position += Vector3.left;


            }
            else if (Input.GetKeyDown("e"))
            {

                objetos[2].transform.position += Vector3.left;


            }
            else if (Input.GetKeyDown("r"))
            {

                objetos[3].transform.position += Vector3.left;


            }
            else if (Input.GetKeyDown("t"))
            {

                objetos[4].transform.position += Vector3.left;


            }
            else if (Input.GetKeyDown("a"))
            {

                objetos[0].transform.position += Vector3.up;


            }
            else if (Input.GetKeyDown("s"))
            {

                objetos[1].transform.position += Vector3.up;


            }
            else if (Input.GetKeyDown("d"))
            {

                objetos[2].transform.position += Vector3.up;


            }
            else if (Input.GetKeyDown("f"))
            {

                objetos[3].transform.position += Vector3.up;


            }
            else if (Input.GetKeyDown("g"))
            {

                objetos[4].transform.position += Vector3.up;


            }
            else if (Input.GetKeyDown("space"))
            {

                objetos[0].transform.position = Vector3.zero;
                objetos[1].transform.position = Vector3.zero;
                objetos[2].transform.position = Vector3.zero;
                objetos[3].transform.position = Vector3.zero;
                objetos[4].transform.position = Vector3.zero;

            }else if (objetos[3].transform.position.x > 4 || objetos[3].transform.position.x < -4){

            objetos[3].transform.position = Vector3.zero;


            }else if (objetos[4].transform.position.x > 4 || objetos[4].transform.position.x < -4){


            objetos[4].transform.position = Vector3.zero;


            }

    }

    }

