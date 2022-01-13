/*using UnityEngine;

namespace DefaultNamespace
{
    public class InputController : MonoBehaviour
    {
        public ButtonDown LeftButton;
        public ButtonDown RightButton;
        public ButtonDown UpButton;
        public ButtonDown DownButton;
        
        public float LerpSpeed;
        public static Vector2 InputAxis;
        
        
        private void Update()
        {
            
            if (LeftButton.IsDown && !RightButton.IsDown)
            {
                InputAxis = Vector2.left;
            }
            else if (RightButton.IsDown && !LeftButton.IsDown)
            {
                InputAxis = Vector2.right;
            }
            else if (UpButton.IsDown && !DownButton.IsDown)
            {
                InputAxis = Vector2.up;
            }
            else if (DownButton.IsDown && !UpButton.IsDown)
            {
                InputAxis = Vector2.down;
            }
            else
            {
                InputAxis = Vector2.Lerp(InputAxis, Vector2.zero, Time.deltaTime * LerpSpeed);
            }
        }
    }
}*/