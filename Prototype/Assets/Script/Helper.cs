using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Helper
{
    public static IClickable GetClickable()
    {
        Collider2D collider2d = GetColliderUnderMouse(out Vector3 hitpoint);

        if (collider2d == null) return null;

        return collider2d.GetComponent<IClickable>();
    }

    private static Collider2D GetColliderUnderMouse(out Vector3 hitpoint)
    {
        Vector2 mousePosWorld2D = Get2DWorldMousePosition();
        // Raycast2d -> save hit
        RaycastHit2D hit = Physics2D.Raycast(mousePosWorld2D, Vector2.zero);
        hitpoint = hit.point;
        return hit.collider;
    }
    public static Vector2 Get2DWorldMousePosition()
    {
        Vector3 mousePosWorld = GetWorldMousePosition();
        // Transform coordinates from Screen Space to World Space 3d -> 2d
        return new Vector2(mousePosWorld.x, mousePosWorld.y);
    }

    private static Vector3 GetWorldMousePosition()
    {
        Camera mainCamera = Camera.main;
        // Read mouse position its vector3d
        Vector3 mousePos = Input.mousePosition;
        // Transform from screenspace to worldspace
        return mainCamera.ScreenToWorldPoint(mousePos);
    }
}
