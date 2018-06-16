using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    class SquareCommand : ICommand
    {
        private Point _point;
        private Bitmap _bitmap;
        private Graphics _graprics;
        private Color _color;

        public SquareCommand(Bitmap bitmap, Color color, int x, int y)
        {
            _bitmap = bitmap;
            _graprics = Graphics.FromImage(_bitmap);
            _color = color;
            _point = new Point(x, y);
        }


        public void Do()
        {
            throw new NotImplementedException();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
