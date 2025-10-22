using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public Button botao;                 // arraste o botão UI no Inspector
    private GameController gameController; // referência ao script GameController

    void Start()
    {
        
        // encontra o objeto que tem o script GameController
        gameController = FindObjectOfType<GameController>();
        
        // adiciona o listener ao botão
        botao.onClick.AddListener(OnButtonPressed);
    }

    void OnButtonPressed()
    {
        // chama a função StartGame do GameController
        gameController.StartGame();
    }
}
