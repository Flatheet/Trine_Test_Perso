using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR;

public class GameManager : MonoBehaviour
{
    private string actualjoy;
    private string _joy1 = "Joy1_";
    private string _joy2 = "Joy2_";

    [SerializeField] private GameObject[] _character;
    
    
    [SerializeField] private bool _twoPlayer;

    [SerializeField] private bool isGood;
    
    
    // Start is called before the first frame update
    void Awake()
    {
        GameObject b = Instantiate(_character[0], new Vector3(1, 1, 1), Quaternion.identity);
        b.GetComponent<Player>().Actualjoy = _joy1;
        if (_twoPlayer)
        {
            GameObject c = Instantiate(_character[0], new Vector3(-1, 1 - 1), Quaternion.identity);
            c.GetComponent<Player>().Actualjoy = _joy2;
        }
    }
}
