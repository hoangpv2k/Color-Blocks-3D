using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curtain : LevelElement
{
    [SerializeField]
    private GameObject lockIcon;
    private SkinnedMeshRenderer[] skinnedMeshRenderers;
    private Vector3 lockIconScale;
}
