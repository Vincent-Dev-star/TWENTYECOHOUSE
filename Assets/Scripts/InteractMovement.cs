using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractMovement : MonoBehaviour
{
    RaycastHit hit;

    public LineRenderer line;

    public GameObject player;

    public int indexPoint;

    public GameObject point1;
    public GameObject point2;
    public GameObject point3;

    public ManagerWater managerWater;

    // Start is called before the first frame update
    void Start()
    {
        indexPoint = 1;
    }

    // Update is called once per frame
    void Update()
    {
        PointMovement();
        DesablePoint();
        EnableRobinet();
    }

    public void PointMovement()
    {

        point1.SetActive(true);
        point2.SetActive(true);
        point3.SetActive(true);

        line.SetPosition(0, this.transform.position);

        if(Physics.Raycast(this.transform.position, this.transform.forward, out hit, 100f))
        {
            if(hit.point != null)
            {
                //ligne qui point la cible
                line.SetPosition(1, hit.transform.position);

                if (hit.transform.tag == "point" && (Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") >0.1f)||Input.GetKeyDown(KeyCode.A))
                {       
                    player.transform.position = hit.transform.position + new Vector3(0,0.7f,0);

                    if(hit.transform.name == "Point1")
                    {
                        indexPoint = 1;
                    }else if(hit.transform.name == "Point2")
                    {
                        indexPoint = 2;
                    }else if(hit.transform.name == "Point3")
                    {
                        indexPoint = 3;
                    }
                }
            }
        }
        else
        {
            //Ligne qui point droit devant la manette
            line.SetPosition(1, (this.transform.forward*10) + this.transform.position);
        }


    }

    public void DesablePoint()
    {
        if(indexPoint == 1)
        {
            point1.SetActive(false);
        }
        else if(indexPoint == 2)
        {
            point2.SetActive(false);
        }
        else if(indexPoint == 3)
        {
            point3.SetActive(false);
        }
    }

    public void EnableRobinet()
    {
        line.SetPosition(0, this.transform.position);

        if (Physics.Raycast(this.transform.position, this.transform.forward, out hit, 100f))
        {
            if (hit.point != null)
            {
                //ligne qui point la cible
                line.SetPosition(1, hit.transform.position);

                if (hit.transform.name == "Robinet" && (Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.1f) || Input.GetKeyDown(KeyCode.A))
                {
                    managerWater.robinet = !managerWater.robinet;
                }
            }
        }
        else
        {
            //Ligne qui point droit devant la manette
            line.SetPosition(1, (this.transform.forward * 10) + this.transform.position);
        }
    }


}
