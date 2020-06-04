using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

namespace childofthebeast.tutorial
{
    public class Tutorial1 : UdonSharpBehaviour
    {
        private GameObject GameObjectVar;
        private int intVar;
        private float floatVar;
        private bool boolVar;

        private Text TextVar;
        private InputField InputFieldVar;


        public GameObject Cube;
        private bool CubeActive;

        public override void Interact()
        {
            //CubeActive = Cube.activeSelf;

            Cube.SetActive(!Cube.activeSelf);

            /*
            if (CubeActive == true)
            {
                Cube.SetActive(false);
            }
            else
            {
                Cube.SetActive(true);
            }
            */
        }
    }
}

