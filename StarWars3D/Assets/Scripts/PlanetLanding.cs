using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetLanding : MonoBehaviour
{

    [SerializeField]
    GameObject tatoine_spawnpoint;
    [SerializeField]
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        string currentPlanet  = PlayerPrefs.GetString("CurrentPlanet");

        if(currentPlanet == "tatoine")
        {
            player.transform.position = tatoine_spawnpoint.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {    
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerPrefs.SetString("CurrentPlanet", "");
    }
}
