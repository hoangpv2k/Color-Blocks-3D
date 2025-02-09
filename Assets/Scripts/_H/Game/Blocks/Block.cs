using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField]
    private Vector2Int gridPos;

    [SerializeField]
    private LevelElementsData levelElementsData;

    [SerializeField]
    private LevelElement levelElement;

    [SerializeField]
    private BlocksData blocksData;

    [SerializeField]
    private Collider2D physicsCollider;

    [SerializeField]
    private Collider2D selectCollider;

    [SerializeField]
    private int type;

    [SerializeField]
    protected GridElement gridElement;

    [SerializeField]
    protected BlockGroup blockGroup;

    public int gridX => 0;

    public int gridY => 0;

    public Vector2Int GridPos => default(Vector2Int);

    public LevelElement LevelElement => null;

    public int Type => 0;

    public GridElement GridElement => null;

    public BlockGroup BlockGroup => null;
}
