//NibManagerTest - a test project for the JTNibManager library.
//© 2012, Dimitris Tavlikos - dimitris ( at ) tavlikos.com, http://software.tavlikos.com
//
//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:
//
//The above copyright notice and this permission notice shall be included in
//all copies or substantial portions of the Software.
//
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//THE SOFTWARE.

using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace NibManagerTest
{
	[Register("CustomCell")]
	public class CustomCell : UITableViewCell, ICellPopulator
	{
		public CustomCell (IntPtr handle) : base(handle)
		{
		}
		
		
		#region Outlets
		
		[Outlet("customTitleLabel")]
		public UILabel CustomTitleLabel
		{
			get;
			set;
		}//end UILabel CustomTitleLabel
		
		#endregion Outlets
		
		
		
		#region ICellPopulator implementation
		public void PopulateCell (string text, string subtitle)
		{
			
			this.CustomTitleLabel.Text = text;
			
		}
		#endregion
	}
}
