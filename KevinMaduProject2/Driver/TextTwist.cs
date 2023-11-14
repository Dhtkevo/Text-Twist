using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KevinMaduProject2.Driver
{
    public class TextTwist
    {
        public List<char> letters; 

        public TextTwist()
        {
            letters = new List<char>();

            PopulateLetters();
        }

        private void PopulateLetters()
        {
            // add 11 e's to letters
            for (var i = 0; i < 11; i++)
            {
                letters.Add('e');
            }

            // add 9 t's
            for (var i = 0; i < 9; i++)
            {
                letters.Add('t');
            }

            // add 8 o's
            for (var i = 0; i < 8; i++)
            {
                letters.Add('o');
            }

            // add 6 a,i,n,s
            for (var i = 0; i < 6; i++)
            {
                letters.Add('a');
                letters.Add('i');
                letters.Add('n');
                letters.Add('s');
            }

            // add 5 h,r
            for (var i = 0; i < 5; i++)
            {
                letters.Add('h');
                letters.Add('r');
            }

            // add 4 l's
            for (var i = 0; i < 4; i++)
            {
                letters.Add('l');
            }

            // add 3 d,u,w,y
            for (var i = 0; i < 3; i++)
            {
                letters.Add('d');
                letters.Add('u');
                letters.Add('w');
                letters.Add('y');
            }

            // add 2 b,c,f,g,m,p,v
            for (var i = 0; i < 2; i++)
            {
                letters.Add('b');
                letters.Add('c');
                letters.Add('f');
                letters.Add('g');
                letters.Add('m');
                letters.Add('p');
                letters.Add('v');
            }

            // add 1 j,k,q,x,z
            for (var i = 0; i < 1; i++)
            {
                letters.Add('j');
                letters.Add('k');
                letters.Add('q');
                letters.Add('x');
                letters.Add('z');
            }
        }
    }
}
