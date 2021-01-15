using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private string actualjoy;

    [SerializeField]private string message = "Help";

    public string Actualjoy
    {
        get => actualjoy;
        set => actualjoy = value;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton(actualjoy + "Fire1"))
            Debug.Log(message);
    }
}
