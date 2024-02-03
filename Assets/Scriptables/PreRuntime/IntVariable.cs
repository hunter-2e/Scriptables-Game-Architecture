using UnityEngine;

[CreateAssetMenu]
public class IntVariable : ScriptableObject
{
    public IntChangedEvent onValueChanged;
    public int Value;
    private void OnValidate() {
        onValueChanged.Raise(Value);
    }
}
