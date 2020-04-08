using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManagerCanvas : MonoBehaviour
{
    public ManagerWater managerWater;

    public TextMeshProUGUI argent;
    public TextMeshProUGUI taux;

    int nb_Facture;
    int nb_tauxFacture;
    int countTime = 5;

    // Start is called before the first frame update
    void Start()
    {
        nb_Facture = 1000;
        nb_tauxFacture = 100;
    }

    // Update is called once per frame
    void Update()
    {
        showFacture();

        showTauxFacture();
    }

    public void showFacture()
    {
        if(Time.time >= countTime)
        {
            countTime += 5;
            nb_Facture -= nb_tauxFacture;
        }
        argent.text = "" + nb_Facture +" $";
    }
    
    public void showTauxFacture()
    {
        if(!managerWater.robinet)
        {
            nb_tauxFacture = 0;
        }else
        {
            nb_tauxFacture = 100;
        }

        if(nb_tauxFacture <= 0 )
        {
            taux.text = "" + nb_tauxFacture + "$/s";

        }
        else
        {
            taux.text = "-" + nb_tauxFacture + "$/s";
        }
    }
}
