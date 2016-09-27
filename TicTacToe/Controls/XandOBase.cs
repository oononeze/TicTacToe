using GameHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Controls
{
    public abstract class XandOBase : UserControl
    {
        #region Properties

        public string Identifier { get; set; }
        public Player Owner { get; set; }

        #endregion

        #region Methods

        public abstract void Draw();

        #endregion

    }
}
