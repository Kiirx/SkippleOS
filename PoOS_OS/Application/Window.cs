﻿namespace ProjectOrizonOS.Application
{
    public enum AppType
    {
        TextWindow,
        GraphicsWindow,
    }

    public abstract class Window
    {
        public string DisplayName;
        public int OffsetX = 50, OffsetY = 50;
        public int Width = 320, Height = 200;

        public void Draw()
        {
            DrawFrame(OffsetX, OffsetY);
            DrawContent(OffsetX, OffsetY + 20);
            DrawButtons(OffsetX, OffsetY);
        }

        protected abstract void DrawFrame(int x, int y);
        protected abstract void DrawContent(int x, int y);

        protected abstract void DrawButtons(int x, int y);
    }
}