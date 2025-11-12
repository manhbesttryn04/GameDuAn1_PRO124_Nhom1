using UnityEngine;
using UnityEngine.EventSystems;

public class Key : MonoBehaviour
{
    public ScriptableObject item;
    public string name;
    public Sprite icon;

    private void Update()
    {
        name = item.name;
        icon = (item as Item).icon;
    }
    public Sprite Geticon()
    {
                return icon;
    }
    
}
