using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab01_Samsonova
{
    class Figure
    {
        public float pos_x, pos_y;
        public bool selected;
        protected string nameGlob;
        protected string nameLoc;
        protected int index;

        virtual public bool test(float x, float y) // check for hitting a point in a shape
        {
            return false;
        }

        virtual public void draw(Graphics g) // figure drawing
        {

        }

        virtual public void Set(float r)
        {

        }

        virtual public string GiveGlobName(int i)
        {
            return nameGlob;
        }

        virtual public string GiveName(int i)
        {
            return nameLoc;
        }

        virtual public string GetName()
        {
            return nameLoc;
        }

        virtual public int GetIndex()
        {
            return index;
        }

    }
}
