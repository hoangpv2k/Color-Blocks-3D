using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BlocksData", menuName = "ScriptableObject/BlocksData")]
public class BlocksData : ScriptableObject
{
    [SerializeField]
    private List<BlockData> datas;

    [SerializeField]
    [Space]
    private Sticky stickyPrefab;

    [SerializeField]
    [Space]
    private Material movingBlockerMaterial;

    [SerializeField]
    private Color movingBlockerOutlineColor;

    [SerializeField]
    private BlockGroup blockGroup_1_prefab;

    public Sticky StickyPrefab => null;

    public Material MovingBlockerMaterial => null;

    public Color MovingBlockerOutlineColor => default(Color);

    public BlockGroup BlockGroup_1_prefab => null;

    public int DataCount => 0;

    public BlockData GetBlockData(int blockType)
    {
        return null;
    }
}