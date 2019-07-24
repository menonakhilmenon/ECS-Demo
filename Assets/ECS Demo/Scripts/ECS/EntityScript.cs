﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Collections;
public class EntityScript : MonoBehaviour
{
    public GameObject entityPrefab;
    public int count = 10;
    // Start is called before the first frame update
    void Start()
    {
        InstantiateMore();
    }

    public void InstantiateMore()
    {
        EntityManager a = World.Active.EntityManager;

        Entity entity = GameObjectConversionUtility.ConvertGameObjectHierarchy(entityPrefab, World.Active);
        for (int i = 0; i < count; i++)
        {
            a.Instantiate(entity);
        }
    }
}