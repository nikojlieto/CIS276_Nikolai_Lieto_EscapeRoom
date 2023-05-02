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
    private void Start()
    {
        loadSceneButton.onClick.AddListener(LoadScene);
        loadBooksButton.onClick.AddListener(LoadBooks);
        loadBearPuzzleButton.onClick.AddListener(LoadBearPuzzle);
        inventoryUIView = InventoryUIView.FindObjectOfType<InventoryUIView>();
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(GAME_SCENE);

    }
    public void LoadBooks()
    {
        SceneManager.LoadScene("BooksLeftScene");

    }
    public void LoadBearPuzzle(){
        if (inventoryUIView.selectedButton.itemData == bearItemData){
            SceneManager.LoadScene("BearPuzzleScene");
        }
    }
}
