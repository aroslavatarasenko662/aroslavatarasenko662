using TMPro;
using UnityEngine;
using static _0xd931f97e;

public class _0x4d75d231 : MonoBehaviour
{
    public void _0xb3962664()
    {
        this.MoneyCountText.text = _0x0633db75._0x684309b9.ToString();
    }

    public TMP_Text MoneyCountText;
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x019c9a6d;
            if (this.gameObject.TryGetComponent(out _0x019c9a6d))
                this.MoneyCountText = _0x019c9a6d;
        }

        this._0xb3962664();
    }
}