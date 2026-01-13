using UnityEngine;

public class GameController : MonoBehaviour
{
    public UIManager ui; 

    
    private void OnActionButtonClicked()
    {
       
        ui.UpdateLabel("Button geklikt! Tekst is aangepast 🎉");
    }
}
