using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x42afe6b1 : MonoBehaviour
{
    private TMP_Text _0x24e0190e;
    private void _0x1878c063()
    {
        if (this._0x9b133e8e.canvasRenderer.GetColor() != this._0x24e0190e.canvasRenderer.GetColor())
            this._0x24e0190e.canvasRenderer.SetColor(this._0x9b133e8e.canvasRenderer.GetColor());
    }

    private Image _0x9b133e8e;
    private void Update()
    {
        this._0x1878c063();
    }
}