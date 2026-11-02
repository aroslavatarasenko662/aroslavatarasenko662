using UnityEngine;
using UnityEngine.UI;

public class _0xa40dd46b : MonoBehaviour
{
    private int _0x1903bb5f;
    private Button _0x2f52265f;
    private void Start()
    {
        if (this._0x3142390b)
            this._0x2f52265f.onClick.AddListener(() => _0x559fb8c0.Instance._0xbc804e90());
        else
            this._0x2f52265f.onClick.AddListener(() => _0x559fb8c0.Instance._0x6fddb199(this._0x1903bb5f));
    }

    private void Awake()
    {
        if (this._0x2f52265f == null)
            if (!this.TryGetComponent(out this._0x2f52265f))
                this._0x2f52265f = this.GetComponentInChildren<Button>();
    }

    private bool _0x3142390b;
}