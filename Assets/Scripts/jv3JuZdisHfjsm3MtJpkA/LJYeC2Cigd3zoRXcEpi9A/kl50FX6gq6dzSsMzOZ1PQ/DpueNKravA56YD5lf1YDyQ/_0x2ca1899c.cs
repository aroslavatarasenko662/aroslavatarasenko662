using UnityEngine;
using UnityEngine.UI;

public class _0x2ca1899c : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        this.Button.onClick.AddListener(() => _0xc2255145.Instance._0xae3b7fed(this.IsPhysicsRunOnClick));
    }

    public bool IsPhysicsRunOnClick;
    public Button Button;
}