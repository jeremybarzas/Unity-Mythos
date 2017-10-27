
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptables/Stats/Stat")]
public class Stat : ScriptableObject
{

    private void OnValidate()
    {
        name = Name;
    }

    public int Value;
    public string Name;
}
