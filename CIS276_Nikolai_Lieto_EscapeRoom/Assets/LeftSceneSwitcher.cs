using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LeftSceneSwitcher : MonoBehaviour
{
public const string GAME_SCENE = "CenterScene";
    [SerializeField]
    private Button loadSceneButton;
    [SerializeField]
    private Button loadBooksButton;
    [SerializeField]
    private Button loadBearPuzzleButton;
    public InventoryUIView inventoryUIView;
    [SerializeField]
    private ItemData bearItemData;
    public InventoryController inventoryController;
    public GameTracker gameTracker;
    private void Start()
    {
        loadSceneButton.onClick.AddListener(LoadScene);
        loadBooksButton.onClick.AddListener(LoadBooks);
        loadBearPuzzleButton.onClick.AddListener(LoadBearPuzzle);
        inventoryUIView = InventoryUIView.FindObjectOfType<InventoryUIView>();
        inventoryController = InventoryController.FindObjectOfType<InventoryController>();
        gameTracker = GameTracker.FindObjectOfType<GameTracker>();
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(GAME_SCENE, LoadSceneMode.Additive);

    }
    public void LoadBooks()
    {
        SceneManager.LoadScene("BooksLeftScene");

    }
    public void LoadBearPuzzle(){
        if (gameTracker.bearUnlocked){
            SceneManager.LoadScene("BearPuzzleScene", LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync("LeftScene");
        }
        else {
            if (inventoryUIView.selectedButton != null){
            if(inventoryUIView.selectedButton.itemData == bearItemData){
                SceneManager.LoadScene("BearPuzzleScene", LoadSceneMode.Additive);
                SceneManager.UnloadSceneAsync("LeftScene");
                inventoryController.UseItem(inventoryUIView.selectedButton.itemData);
                gameTracker.UnlockBear();
                }
            } 
        }
        
    }
}
