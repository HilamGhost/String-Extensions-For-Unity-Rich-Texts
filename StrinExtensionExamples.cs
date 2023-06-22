using UnityEngine;


namespace HilamGhostPrototypes
{
    public class StrinExtensionExamples : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            DebugObject();
        }

        [ContextMenu("Debug Object")]
        void DebugObject()
        {
            Debug.Log($"This Debug is Italic!".SetItalic());
            Debug.Log($"This Debug is Bold!".SetBold());
            Debug.Log($"This Debug is Bold Italic!".SetBoldItalic());
            Debug.Log($"{"This".SetItalic()} {"Debug".SetBold()} is {"not".SetBoldItalic()} normal! ");

            Debug.Log("-------------------------------------------------");
            
            Debug.Log($"This Debug is Fully Aqua!".AddColor(RichTextColors.Aqua));
            Debug.Log($"This Debug is Fully Red!".AddColor(Color.red));
            Debug.Log("This Debug is Fully Telemagenta! (#CF3476)".AddColor("#CF3476"));
            Debug.Log($"{"This".AddColor(Color.blue)} {"Debug".AddColor(RichTextColors.Purple)} is {"Colorful".AddColor("#924E7D")}");
            
            Debug.Log("-------------------------------------------------");
            
            Debug.Log($"{"This".ChangeFontSize(12.5f)} {"Debug".ChangeFontSize(13f)} {"is".ChangeFontSize(13.5f)} {"getting".ChangeFontSize(14f)} {"bigger!".ChangeFontSize(14.5f)}");
            Debug.Log($"{"This".ChangeFontSize(12.5f)} {"Debug".ChangeFontSize(12f)} {"is".ChangeFontSize(11.5f)} {"getting".ChangeFontSize(11f)} {"smaller!".ChangeFontSize(10.5f)}");
            
            Debug.Log("-------------------------------------------------");
            Debug.Log($"{"This".ChangeFontSize(12.5f).AddColor(Color.magenta).SetItalic()} {"Debug".ChangeFontSize(13f).AddColor(Color.blue).SetBoldItalic()} {"is".ChangeFontSize(13.5f)} {"getting".ChangeFontSize(14f).SetBoldItalic()} {"weird!".AddColor(Color.yellow).ChangeFontSize(14.5f)}");
            
        }
    }
}
