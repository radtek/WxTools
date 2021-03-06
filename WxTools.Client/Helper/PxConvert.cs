﻿using System.Windows;

namespace WxTools.Client.Helper
{
    public class PxConvert
    {
        //调试下的宽高
        public static Rect DebugPoint = new Rect(0, 0, 888, 625);

        public static Point To(Point p, int width,int height)
        {
            var x = width * p.X / DebugPoint.Width;
            var y = height * p.Y / DebugPoint.Height;
            return new Point(x, y);
        }

        public static Point To(int x, int y)
        {
            return To(new Point(x, y), Client.Common.Width, Client.Common.Height);
        }
    }
}
