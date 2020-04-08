using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerTablette : MonoBehaviour
{
    public GameObject Play;
    public GameObject Facture;
    public GameObject Restart;

    // Start is called before the first frame update
    void Start()
    {
        //Play.SetActive(true);
        //Facture.SetActive(false);
        //Restart.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartTheGame()
    {
        //Play.SetActive(false);
        //Facture.SetActive(true);
    }

    public void GameOver()
    {
        //Facture.SetActive(false);
        //Restart.SetActive(true);
    }
}
