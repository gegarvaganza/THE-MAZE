using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KeySystem
{
    public class KeyItemController : MonoBehaviour
    {
        [SerializeField] private bool brownDoor = false;
        [SerializeField] private bool goldKey = false;

        [SerializeField] private KeyInventory _keyInventory = null;

        private KeyDoorController doorObject;

        private void Start()
        {
            if (brownDoor)
            {
                doorObject = GetComponent<KeyDoorController>();
            }
        }

        public void ObjectInteraction()
        {
            if (brownDoor)
            {
                doorObject.PlayAnimation();
            }

            else if (goldKey)
            {
                _keyInventory.hasGoldKey = true;
                gameObject.SetActive(false);
            }
        }
    }
}
