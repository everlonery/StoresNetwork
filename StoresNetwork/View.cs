using StoresNetwork.ViewControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork
{
    internal class View
    {
        string title;
        List<string> options;
        OptionIndex selectedOption;
        const string menuKeysInfo = "Переміщення - стрілки вверх/вниз, вибрати - Enter, повернутися - ESC";
        public View(string title, List<string> options, OptionIndex selectedOption) { 
            this.title = title;
            this.options = new List<string>();
            foreach (string option in options)
                this.options.Add(option);
            this.selectedOption = selectedOption;
        }
        void Draw()
        {
            Clear();
            DrawTitle();
            DrawAllOptions();
            DrawMenuKeysInfo();
            SetSelection();
        }
        void DrawTitle()
        {
            TextColor.BlueText($"*** {title} ***");
        }
        void DrawOption(int index)
        {
            Console.SetCursorPosition(0, index + 1);
            TextColor.YellowText(options[index]);
        }
        void DrawAllOptions()
        {
            for (int i = 0; i < options.Count; i++)
                DrawOption(i);
        }
        void DrawMenuKeysInfo()
        {
            Console.SetCursorPosition(0, options.Count + 2);
            TextColor.BlueText(menuKeysInfo);
        }
        public ViewResult Show()
        {
            Draw();
            ConsoleKey key;
            while (true)
            {
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.Enter:
                        return ViewResult.Enter;
                    case ConsoleKey.Escape:
                        return ViewResult.Return;
                    case ConsoleKey.UpArrow:
                        MoveUp();
                        break;
                    case ConsoleKey.DownArrow:
                        MoveDown();
                        break;
                }
            }
        }
        void MoveUp()
        {
            if (!IsFirstOption())
            {
                RemoveSelection();
                GoPrevOption();
                SetSelection();
            }
        }
        void MoveDown()
        {
            if (!IsLastOption())
            {
                RemoveSelection();
                GoNextOption();
                SetSelection();
            }
        }
        void RemoveSelection()
        {
            SetCursorCurrentPosition();
            TextColor.YellowText(CurrentOption());
        }
        void SetSelection()
        {
            Console.CursorVisible = false;
            SetCursorCurrentPosition();
            TextColor.GreenText(CurrentOption());
        }
        void SetCursorCurrentPosition()
        {
            Console.SetCursorPosition(0, selectedOption.Index + 1);
        }
        string CurrentOption()
        {
            return options[selectedOption.Index];
        }
        bool IsFirstOption()
        {
            return selectedOption.Index == 0;
        }
        bool IsLastOption()
        {
            return selectedOption.Index == options.Count-1;
        }
        void GoNextOption()
        {
            selectedOption.Index++;
        }
        void GoPrevOption()
        {
            selectedOption.Index--;
        }
        public void Clear()
        {
            Console.Clear();
        }
    }
}
