using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Inventory : MonoBehaviour
{
    private UIDocument uIDocument;

    private void Awake()
    {
        uIDocument= GetComponent<UIDocument>();
    }

    // Start is called before the first frame update
    void Start()
    {
        VisualElement root = uIDocument.rootVisualElement;
        Button button = root.Q<Button>();
        button.clicked += () => Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
