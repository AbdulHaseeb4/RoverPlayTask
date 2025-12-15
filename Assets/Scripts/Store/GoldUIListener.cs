using UnityEngine;
using UnityEngine.UI;

public class GoldUIListener : MonoBehaviour
{
    public Text goldText;

    private void OnEnable()
    {
        GoldManager.OnGoldChanged += UpdateGoldUI;
        UpdateGoldUI(GoldManager.Instance.gold);
    }

    private void OnDisable()
    {
        GoldManager.OnGoldChanged -= UpdateGoldUI;
    }

    void UpdateGoldUI(int newGold)
    {
        goldText.text = newGold.ToString();
    }
}
