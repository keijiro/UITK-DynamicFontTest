using UnityEngine;
using UnityEngine.UIElements;

public sealed class TestUpdater : MonoBehaviour
{
    [field:SerializeField] public TextAsset _source { get; set; } = null;
    [field:SerializeField] public int _stride { get; set; } = 10;

    int _pos;

    void Update()
    {
        var label = GetComponent<UIDocument>().rootVisualElement.Q<Label>();
        label.text = _source.text.Substring(_pos, Mathf.Min(_source.text.Length - _pos, _stride));
        _pos = (_pos + _stride) % _source.text.Length;
    }
}
