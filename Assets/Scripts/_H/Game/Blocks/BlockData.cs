using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BlockData", menuName = "Block Data", order = 1)]
public class BlockData : ScriptableObject
{
    [SerializeField]
    private Material material;

    [SerializeField]
    private Color outlineColor;

    [SerializeField]
    private Material gateMaterial;

    [SerializeField]
    private Material gateArrowMaterial;

    [SerializeField]
    private GameObject explodeParticle;

    [SerializeField]
    private Material ropeMaterial;

    [SerializeField]
    private Material pathMaterialIn;

    public Material Material => null;

    public Color OutlineColor => default(Color);

    public Material GateMaterial => null;

    public Material GateArrowMaterial => null;

    public GameObject ExplodeParticle => null;

    public Material RopeMaterial => null;

    public Material PathMaterialIn => null;
}
