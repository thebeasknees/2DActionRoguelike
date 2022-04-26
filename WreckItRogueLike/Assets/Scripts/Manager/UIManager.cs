using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    [Header("Settings")]
    [SerializeField] private Image healthBar;
    [SerializeField] private Image shieldBar;
    [SerializeField] private TMPro.TextMeshProUGUI currentHealthTMP;
    [SerializeField] private TMPro.TextMeshProUGUI currentShieldTMP;

    private float playerCurrentHealth;
    private float playerMaxHealth;
    private float playerCurrentShield;
    private float playerMaxShield;

    private void Update()
    {
        InternalUpdate();
    }

    public void UpdateHealth(float currentHealth, float maxHealth, float currentShield, float maxShield)
    {
        playerCurrentHealth = currentHealth;
        playerMaxHealth = maxHealth;
        playerCurrentShield = currentShield;
        playerMaxShield = maxShield;
    }

    private void InternalUpdate()
    {
        healthBar.fillAmount = Mathf.Lerp(healthBar.fillAmount, playerCurrentHealth / playerMaxHealth, 10f * Time.deltaTime);
        currentHealthTMP.text = playerCurrentHealth.ToString() + "/" + playerMaxHealth.ToString();

        shieldBar.fillAmount = Mathf.Lerp(shieldBar.fillAmount, playerCurrentShield / playerMaxShield, 10f * Time.deltaTime);
        currentShieldTMP.text = playerCurrentShield.ToString() + "/" + playerMaxShield.ToString();
    }

}
