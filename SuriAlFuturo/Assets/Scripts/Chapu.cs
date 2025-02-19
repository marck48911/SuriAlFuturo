﻿using UnityEngine;
using System.Collections;

public class Chapu : MonoBehaviour 
{
    public Animator Animator;

    NavMeshAgent _agent;

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    
    public void Embark()
    {
        _agent.enabled = false;
        gameObject.SetActive(false);
    }


    public void Disembark()
    {
        GameController c = GameObject.FindGameObjectWithTag(SuriAlFuturo.Tag.GameController).GetComponent<GameController>();
        transform.position = c.Suri.transform.position;

        _agent.enabled = true;
    }
}
