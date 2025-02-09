using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : LevelElement
{
    [SerializeField] private GameObject keyMesh;
    [SerializeField] private Outline outline;
    public GameObject KeyMesh => keyMesh;
}
