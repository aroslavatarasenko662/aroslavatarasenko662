using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xf40249dd : MonoBehaviour
{
    public Button Button;
    public bool IsLoadCurrentScene;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0xc2255145.Instance._0x7e0b520e(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0xc2255145.Instance._0x7e0b520e(this.LoadSceneId));
    }

    public int LoadSceneId;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}