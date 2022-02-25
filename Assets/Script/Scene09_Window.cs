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
    private Dropdown _dropdown;
    private bool griglia;
    private bool circle;
    private bool random;

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

        griglia = EditorGUILayout.DropdownButton(new GUIContent("Griglia"), FocusType.Passive);
        EditorGUI.BeginDisabledGroup(griglia);
        int column = EditorGUILayout.IntField("column", 5);
        EditorGUI.EndDisabledGroup();

        circle = EditorGUILayout.DropdownButton(new GUIContent("Circle"), FocusType.Passive);
        EditorGUI.BeginDisabledGroup(circle);
        EditorGUILayout.IntField(10);
        EditorGUI.EndDisabledGroup();

        random = EditorGUILayout.DropdownButton(new GUIContent("Random"), FocusType.Passive);
        EditorGUI.BeginDisabledGroup(random);
        EditorGUI.EndDisabledGroup();

    }

    public void ButtonGenerate()
    {
        Instantiate(prefab, container.transform);
    }
}
