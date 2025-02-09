using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scissors : LevelElement
{
    [SerializeField]
    private GameObject model;

    [SerializeField]
    private BlocksData blocksData;

    [SerializeField]
    private MeshRenderer m_renderer1;

    [SerializeField]
    private MeshRenderer m_renderer2;

    [SerializeField]
    private GameObject particle;

    [SerializeField]
    private Outline outline;

    public GameObject Model => null;
}
