using UnityEngine;
using UnityEngine.UI;

public class _0xf433c92f : MonoBehaviour
{
    public Button NextTutorialButton;
    public bool IsTutorialEndPanel;
    public Button TutorialEndButton;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x559fb8c0.Instance._0x6fddb199(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0xc2255145.Instance._0x5e13e328());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x559fb8c0.Instance._0x6fddb199(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x559fb8c0.Instance._0x6fddb199(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0xc2255145.Instance._0x5e13e328());
        }
    }

    public int NextTutorialPanelIndex;
    public int EndTutorialPanelIndex = 1;
}