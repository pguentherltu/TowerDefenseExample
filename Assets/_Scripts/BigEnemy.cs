using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigEnemy : Enemy
{
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    protected override void Update()
    {
        //move like Enemy
        base.Update();

        //target the nearest tower
        //if it's range, shoot at it
        Debug.Log("Shoot at tower!");
    }
}
