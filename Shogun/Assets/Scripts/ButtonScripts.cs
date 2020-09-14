
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class ButtonScripts : MonoBehaviour
{
    private void OnMouseDown() 
    {
        SceneManager.LoadScene("Game1");
    }
    public void ButtonAttack() 
    {
        Debug.Log("Attack");
    }
    public void ButtonBlock() 
    {
        Debug.Log("Block");
    }
}
