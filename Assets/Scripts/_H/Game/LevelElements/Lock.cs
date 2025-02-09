using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Lock : LevelElement
{
    [SerializeField]
    private GameObject lockMesh;

    [SerializeField]
    private GameObject chainParent;

    [SerializeField]
    private TextMeshProUGUI countText;

    [SerializeField]
    private GameObject particle;

    [SerializeField]
    private GameObject textParticle;

    [SerializeField]
    private Transform lockIron;

    private bool opened;
}
