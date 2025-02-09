using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GridManager : MonoBehaviour
{
    public UnityAction OnSequenceEnd;

    [Space]
    [SerializeField]
    private Vector2Int gridSize;

    [SerializeField]
    private Vector2 gridScaleSize;

    [SerializeField]
    private GridElement gridElementPrefab;

    [SerializeField]
    private Transform gridsParent;

    [SerializeField]
    private BlocksData blocksData;

    [SerializeField]
    private Vector2Int spaceCountRange;

    [Space]
    [SerializeField]
    private GameObject wallLeft;

    [SerializeField]
    private GameObject wallRight;

    [SerializeField]
    private GameObject wallTop;

    [SerializeField]
    private GameObject wallBottom;

    private readonly Vector2Int[] neigbourPositions;

    private Dictionary<BlockGroup, Vector2Int> nextBlocks;

    private LevelSystem __levelSystem;

    public Vector2Int GridSize => default(Vector2Int);
}
