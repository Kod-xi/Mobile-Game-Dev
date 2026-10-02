using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuStack : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] LifecycleGuard guard;

    readonly Stack<GameObject> stack = new();

    void Start()
    {
        // Game starts with no menu open.
        pauseMenu.SetActive(false);
    }

    void Update()
    {
        var kb = Keyboard.current;

        if (kb != null && kb.escapeKey.wasPressedThisFrame)
        {
            if (stack.Count == 0)
            {
                // No menu open -> open pause menu
                Open(pauseMenu);
            }
            else
            {
                // Menu already open -> go back
                Back();
            }
        }
    }

    public void Open(GameObject menu)
    {
        if (menu == null)
            return;

        if (stack.Count > 0)
            stack.Peek().SetActive(false);

        stack.Push(menu);
        menu.SetActive(true);

        guard.SetPaused(true);
    }

    public void Back()
    {
        if (stack.Count == 0)
            return;

        // Close current menu
        stack.Pop().SetActive(false);

        if (stack.Count > 0)
        {
            // Return to previous menu
            stack.Peek().SetActive(true);
        }
        else
        {
            // No menus left -> resume game
            guard.SetPaused(false);
        }
    }
}