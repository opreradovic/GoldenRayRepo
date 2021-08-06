﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Beast : Enemy
{


    // Start is called before the first frame updatesss
    protected override void Start() {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();

        if(nearestPlayer != null) {
            transform.position = MoveTowards(transform);
            LookTowards(transform);
        }
        
    }
    protected override void OnTriggerEnter2D(Collider2D collision) {
        base.OnTriggerEnter2D(collision);
    }
}
