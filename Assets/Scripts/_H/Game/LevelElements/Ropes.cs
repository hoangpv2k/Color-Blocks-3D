using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ropes : LevelElement
{
    [SerializeField]
    private List<Rope> ropes;

    [SerializeField]
    private TextMeshProUGUI countText;

    [SerializeField]
    private GameObject textParticle;

    [SerializeField]
    private GameObject particle;

    [SerializeField]
    private GameObject tagParent;

    private bool opened;

    public bool Completed => false;
}
