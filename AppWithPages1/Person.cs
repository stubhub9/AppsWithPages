using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithPages1
{
    public class Person
    {
        string name;
        Color favoriteColor;

        public Person () { }
        public Person ( string name, Color favoriteColor )
        {
            this.name = name;
            this.favoriteColor = favoriteColor;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Color FavoriteColor
        {
            get { return this.favoriteColor; }
            set { this.favoriteColor = value; }
        }





    }
}
