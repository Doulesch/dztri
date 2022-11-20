using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    [SerializeField] private GameObject enemy;
    [SerializeField] private bool key;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.transform.position;
        //Debug.Log(position.x);
        //float distance = Vector3.Distance(gameObject.transform.position, enemy.transform.position);
        //Vector3.
        
        
        
        
        //Debug.Log(distance);

       
        
            //Vector3 direction = enemy.transform.position - transform.position;
            //Quaternion rotation = Quaternion.LookRotation(direction);
            //transform.rotation = rotation;

       
            

    }

    // Update is called once per frame
    void Update()
    {

        /*if (Input.GetKey(KeyCode.W))
        {
           Vector3 position = gameObject.transform.position;
            position.z += 0.01f;
            gameObject.transform.position = position; 
        }*/
        
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(Vector3.forward*Time.deltaTime*5f);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up*Time.deltaTime*100f);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up*Time.deltaTime*-100f);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(Vector3.forward*Time.deltaTime*-5f);
        }
        
        
          
        //if (Input.GetKey(KeyCode.W))
       // {
         //   gameObject.transform.position =
         //  Vector3.MoveTowards(transform.position, enemy.transform.position, 2 * Time.deltaTime);
        //}


       //transform.rotation = Quaternion.FromToRotation(Vector3.up, Vector3.right);
       
       
       //transform.Rotate(Vector3.up*Time.deltaTime);

        //transform.LookAt(enemy.transform);

    }

    private void OnTriggerEnter(Collider other)
    {
        /*if (other.tag.Equals("BOMB"))
        {
            Debug.Log("BOOM!");
            other.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            gameObject.SetActive(false);
        }*/

        if (other.tag.Equals("DOOR"))
        {
            if (key)
            {
                Vector3 rotation = other.gameObject.transform.eulerAngles;
                rotation.y = -90;
                other.gameObject.transform.eulerAngles = rotation;
            }
            


        }
        
        if (other.tag.Equals("KEY"))
        {
            key = true;
            other.gameObject.SetActive(false);

        }
        
        if (other.tag.Equals("BULLET"))
        {
            gameObject.SetActive(false);
            other.gameObject.SetActive(false);
        }
        
        
    }

    //
    //
    //private void OnTriggerExit(Collider other)
    //{
    //    Debug.Log("Exit");
    //}


    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("Enter");
    //}
}
