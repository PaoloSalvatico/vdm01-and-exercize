using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class Scene09_Window : EditorWindow
{
    public GameObject container;
    public Button button;

    private Object prefab;

    [MenuItem("Window/Tool")]
    public static void OpenWindow()
    {
        var window = GetWindow<Scene09_Window>();
        var title = new GUIContent("Scene09_Configurator");
        window.titleContent = title;
        window.minSize = Vector2.one * 300;
        window.position = new Rect(30, 30, 500, 500);
        window.Show();
    }

    private void OnGUI()
    {
        prefab = EditorGUILayout.ObjectField("prefab", prefab, typeof(Object), false);

        container = EditorGUILayout.ObjectField("Container", container, typeof(GameObject), true) as GameObject;

        if (GUILayout.Button("Generate"))
        {
            ButtonGenerate();
        }
    }

    public void ButtonGenerate()
    {
        Instantiate(prefab, container.transform);
    }
}
