using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public Vector2 GetTargetPosition => Helper.Get2DWorldMousePosition();
}
