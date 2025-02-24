using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject Turret;
    public GameObject Target;
    public float Range = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] possibleTargets = GameObject.FindGameObjectsWithTag("Enemy");

        if (possibleTargets.Length == 0) return;

        Target = possibleTargets[0];

        foreach (GameObject o in possibleTargets) { 
            if (Vector3.Distance(transform.position, o.transform.position) < 
                Vector3.Distance(transform.position, Target.transform.position))
            {
                Target = o;
            }
        }
        Turret.transform.LookAt(Target.transform.position);
        if (Vector3.Distance(transform.position, Target.transform.position) <= Range)
        {
            Debug.Log("Bang!");
            //fire!
        }
    }
}
