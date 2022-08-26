using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncontrarElementoArray : MonoBehaviour
{

    public GameObject[] arrayDeMesas;
    // Start is called before the first frame update
    void Start()
    {
        arrayDeMesas = GameObject.FindGameObjectsWithTag("Mesa");
        AsignarScriptMesa();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Alpha0))
        {
            DestroyDestructible();
        }
        
    }

 

    void DeactivateObjectsInArray()
    {
        for (int i = 0; i < arrayDeMesas.Length; i++)
        {
            arrayDeMesas[i].SetActive(false);
        }
    }

    void AsignarScriptMesa()
    {
        foreach (GameObject go in arrayDeMesas)
        {
            go.AddComponent<Mesa>();
            int random = UnityEngine.Random.Range(0, 2);
            if(random == 0)
            {
                go.GetComponent<Mesa>().destructible = true;
            }
        }
    }

    void DestroyDestructible()
    {
        foreach(GameObject go in arrayDeMesas)
        {
            Destroy(go.GetComponent<Mesa>().destructible = true);
        }
    }
}

/* 
 * 5_Crear una funcion que asigne a todos los elementos del array el script mesa.
 Establecer el valor de la variable "desctructible" aleatoriamente

   6_Crear una funcion que destruya el elemento del array que contenga un script "mesa" cuya vairable booleana
   "destructible" sea true.
 
     
     */