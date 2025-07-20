using UnityEngine;

namespace Code
{
    public class TypesToConsole : MonoBehaviour
    {
        private void Start()
        {
            PrintTypes();
        }
        
        private void PrintTypes()
        {
            int i = 15;
            float f = 4.123f;
            bool b =  true;
            
            Debug.LogError($"Int: {i}");
            Debug.LogError($"Float: {f}");
            Debug.LogError($"Bool: {b}");
        }
    }
}