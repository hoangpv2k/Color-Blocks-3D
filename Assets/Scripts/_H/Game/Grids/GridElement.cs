using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridElement : MonoBehaviour
{
    [SerializeField]
    private Vector2Int gridPos;

    [SerializeField]
    private GridManager gridManager;

    [SerializeField]
    private GameObject floor;

    // [SerializeField]
    // private ColorfulPathItem colorfulPathItem;

    [SerializeField]
    private Block block;

    [SerializeField]
    private Collider2D m_collider2D;

    private bool hasColor;

    private int colorType;

    public int gridX => 0;

    public int gridY => 0;

    public Vector2Int GridPos => default(Vector2Int);

    public GridManager GridManager => null;

    public Block Block => null;

    public bool HasColor => false;

    public int ColorType => 0;

    public bool HasBlock => false;

    public bool HasNotBlock => false;

    public bool HasDoor => false;
}
