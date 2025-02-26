using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject Turret;
    public Enemy Target;
    public float Range = 5.0f;

    private Path LevelPath;

    // Start is called before the first frame update
    void Start()
    {
        LevelPath = GameObject.Find("Path").GetComponent<Path>();
    }

    // Update is called once per frame
    void Update()
    {
        Enemy[] possibleTargets = GameObject.FindObjectsOfType<Enemy>();

        if (possibleTargets.Length == 0) return;

        //there may be no target
        Target = null;

        foreach (Enemy enemy in possibleTargets) {
            //check if this target is in range
            if (Vector3.Distance(transform.position, enemy.transform.position) <= Range)
            {
                if (Target == null) { 
                    Target = enemy;
                    continue; // move on to next iteration
                }

                if (LevelPath.GetDistanceRemaining(enemy.transform.position, enemy.currentDestination)
                    < LevelPath.GetDistanceRemaining(Target.transform.position, Target.currentDestination))
                {
                    Target = enemy;
                }
            }
        }
        Turret.transform.LookAt(Target.transform.position);

        //fire if target acquired
        if (Target != null)
        {
            Debug.Log("Bang!");
            //fire!
        }
    }
}
