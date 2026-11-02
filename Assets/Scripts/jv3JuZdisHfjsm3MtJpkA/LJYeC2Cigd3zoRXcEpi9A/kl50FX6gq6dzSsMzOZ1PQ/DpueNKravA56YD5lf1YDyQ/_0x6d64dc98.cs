using UnityEngine;
using UnityEngine.UI;

public class _0x6d64dc98 : MonoBehaviour
{
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0x4bed43e1.Instance._0x9f14b05a();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0x4bed43e1.Instance._0x004cceed());
        else
            this.Button.onClick.AddListener(() => _0x4bed43e1.Instance._0x8878fd5d(this.PopToShowIndex));
    }

    public bool IsHideAllPops;
    public int PopToShowIndex;
    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsShowLastPop;
}