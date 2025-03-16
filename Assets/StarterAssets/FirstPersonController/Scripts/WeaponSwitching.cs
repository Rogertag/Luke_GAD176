using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    public int selectedWeapon = 0; // first weapon in order of arrangement

    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();
    }

    // needed for input to change weapons
    void Update()
    {

      int previousSelectedWeapon = selectedWeapon;

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
          // if we have 2 children we are going to check if selected weapon is greater than or = to 2
          if (selectedWeapon >= transform.childCount - 1)// to make sure this won't scroll infinitely
               selectedWeapon = 0;
          else
             selectedWeapon++;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f) // this will hhappen in the opposite direction of the scrollwheel
        {
          if (selectedWeapon <= 0)
              selectedWeapon = transform.childCount - 1;
          else
             selectedWeapon--; // reverseing the process going back to the previous weapon
        }
        if (previousSelectedWeapon != selectedWeapon)
        {
          SelectWeapon(); // to enable and diaable corrisponding objects
        }
    }

// if the weapon matches the number enable, if not disable it
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
