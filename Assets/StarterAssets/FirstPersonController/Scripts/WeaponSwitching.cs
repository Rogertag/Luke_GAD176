using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    public int selectedWeapon = 0; // first weapon in order of arrangement

    // Start is called before the first frame update
    void Start()
    {
        SelectedWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SelectWeapon()// when given the choice to the player to enable the weapon wanted
    { 
        int i = 0;
          foreach (Transform weapon in transform)
          {
            if (i == selectedWeapon) // check is weapon is active
                 weapon.gameObject.SetActive(true); // do we want to active chosen weapon?
            else 
                 weapon.gameObject.SetActive(false); // check the i varible to enable and disable weapons
            i++;
          }
    }
}
