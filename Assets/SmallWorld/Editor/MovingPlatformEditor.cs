using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MovingPlatform)), CanEditMultipleObjects]
public class MovingPlatformEditor : Editor
{
    protected virtual void OnSceneGUI()
    {
        MovingPlatform example = (MovingPlatform)target;

        EditorGUI.BeginChangeCheck();
        Vector3 newPosition1 = Handles.PositionHandle(example.position1, Quaternion.identity);
        Vector3 newPosition2 = Handles.PositionHandle(example.position2, Quaternion.identity);
        if (EditorGUI.EndChangeCheck())
        {
            Undo.RecordObject(example, "moved position");
            example.position1 = newPosition1;
            example.position2 = newPosition2;
        }
    }
}
