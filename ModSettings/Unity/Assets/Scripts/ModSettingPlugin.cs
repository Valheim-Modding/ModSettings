using UnityEngine;
using UnityEngine.UI;

namespace ModSettings.GUI
{
    internal class ModSettingPlugin : MonoBehaviour
    {
        public Button Button;
        public Text Text;
        public RectTransform Content;

        public void Toggle()
        {
            Content.gameObject.SetActive(!Content.gameObject.activeSelf);
        }
    }
}
