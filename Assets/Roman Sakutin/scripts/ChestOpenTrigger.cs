using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Threading.Tasks;

namespace Assets.Roman_Sakutin.scripts
{
    public class ChestOpenTrigger: MonoBehaviour
    {
        [SerializeField] private global::ChestOpener _chest;

        private bool _isOpened = false;
        private bool _hasOpener;


        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<ChestOpener>()) 
                _hasOpener = true;
        }

        private void OnTrggerExit(Collider other)
        {
            if (other.GetComponent<ChestOpener>())
                _isOpened = false;
        }

        private void Update()
        {
            if (_isOpened)
                return;


            if (_hasOpener )    /* && Input.GetKeyDown(KeyCode.E)*/
            {
                _chest.Open();
                _isOpened = false;  
            }
        }


    }
}
