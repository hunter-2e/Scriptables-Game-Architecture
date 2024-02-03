using UnityEngine;

[CreateAssetMenu]
public class BoolVariable : ScriptableObject
{
    public BoolChangedEvent onValueChanged;
    public bool Value;

    private void OnValidate() {
        onValueChanged.Raise(Value);
    }
}
