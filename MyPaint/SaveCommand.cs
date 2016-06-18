﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace MyPaint
{
    public class SaveCommand : Command
    {

        private CanvasState itemMenu;

        public SaveCommand(CanvasState iMenu)
        {
            itemMenu = iMenu;
        }

        public override void Execute(ref Canvas drawingCanvas, ref Thumb canvasResizerRightBottom)
        {
            itemMenu.Save(ref drawingCanvas,ref canvasResizerRightBottom) ;
        }

       
    }
}