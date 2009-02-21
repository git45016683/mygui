﻿/*!
	@file
	@author		Generate utility by Albert Semenov
	@date		01/2009
	@module
*/

using System;
using System.Runtime.InteropServices;

namespace MyGUI.Sharp
{

    public class HScrollBar : VScrollBar
    {

        #region HScrollBar

        public HScrollBar()
            : base()
        {
        }

        public HScrollBar(IntPtr _widget)
            : base(_widget)
        {
        }

        public HScrollBar(IntPtr _parent, WidgetStyle _style, string _skin, IntCoord _coord, Align _align, string _layer, string _name)
            : base(_parent, _style, _skin, _coord, _align, _layer, _name)
        {
        }

        protected override string GetWidgetType() { return "HScroll"; }

		#endregion
	
		
		//InsertPoint
		
    }

}
