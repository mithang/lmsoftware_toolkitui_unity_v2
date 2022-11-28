using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlainButton : Button
{
    public new class UxmlFactory: UxmlFactory<PlainButton,UxmlTraits> { }

    public PlainButton() {
        RemoveFromClassList("unity-button");
    }
}
