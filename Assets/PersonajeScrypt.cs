using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonajeScrypt : MonoBehaviour
{
    int puntosPlayer=0;
    public Text texto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Contacto");
        PickupScript objeto;
        objeto = other.GetComponent<PickupScript>();
        if (objeto.esComida)
        {
            puntosPlayer += objeto.puntosItem;
            if (objeto.esComida)
            {
                Destroy(other.gameObject);
            }
            texto.text = ;
        }
    }

}
