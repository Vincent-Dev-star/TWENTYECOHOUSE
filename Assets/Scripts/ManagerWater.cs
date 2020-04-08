using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerWater : MonoBehaviour
{
#pragma warning disable CS0108 // Un membre masque un membre hérité ; le mot clé new est manquant
    public ParticleSystem particleSystem;
    public ParticleSystem particleMoney;
#pragma warning restore CS0108 // Un membre masque un membre hérité ; le mot clé new est manquant

    public bool robinet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(robinet)
        {
            enableWater();
        }
        else
        {
            desableWater();
        }
    }

    public void enableWater()
    {
        particleSystem.Emit(1);

        //InvokeRepeating("DoEmit" , 2 , 2);
        particleMoney.Emit(1);
    }

    public void desableWater()
    {
        particleSystem.Emit(0);
        particleMoney.Stop();
    }

    void DoEmit()
    {
        particleMoney.Emit(1);
        particleMoney.Play();
    }
}
