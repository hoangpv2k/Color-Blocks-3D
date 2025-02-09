using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILevelController
{
    void LoadLevel(ILevel level, ILevelController iPreviousLevelController);
}
