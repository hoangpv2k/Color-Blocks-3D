using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPart : MonoBehaviour
{
    public GridElement GridElement
    {

        get
        {
            return null;
        }
        private set
        {
        }
    }

    public Door Door
    {
        get
        {
            return null;
        }
        private set
        {
        }
    }

    public bool SetGridElementsWithRaycast()
    {
        return false;
    }

    public void SetDoor(Door door)
    {
    }
}
