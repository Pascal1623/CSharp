using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace my1130
{
    class DisplayUtil //
    {
        public void Display(Form mf, MouseEventArgs e) //Mainform을 Form으로 해도 된다.
        {
            Graphics g = mf.CreateGraphics(); //Form안에 CreateGraphics가 있다. 객체지향프로그래밍을 할 때는 클래스가 아니라 객체를 봐야 한다.
            g.DrawRectangle(new Pen(Color.Red), e.X, e.Y, 50, 50);
        }
    }
}
