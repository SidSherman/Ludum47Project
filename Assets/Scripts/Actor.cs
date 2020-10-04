﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{

    public float speed;
    protected Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void Movement()
    {

    }
    protected virtual void Attack()
    {
        
    }
     protected virtual void Rotation()
     {
         
     }
     public virtual void Death()
     {

     }

    

}
