//JTNibManager - a library for caching NIBs in MonoTouch
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
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace JTNibManager
{
	
	public interface INibManaged
	{
		
		void LoadFromNib(string nibName, NSBundle bundle);
		NibManager Manager { get; }
		
	}//end interface INibManaged
	
	
	
	[Register("NibManagedController")]
	public abstract class NibManagedController : UIViewController, INibManaged
	{
		
		#region Constructors
		
		public NibManagedController (string nibName, NibManager nibManager, NSBundle bundle)
		{
			this.Manager = nibManager;
			this.LoadFromNib(nibName, bundle);
			this.ViewDidLoad();
		}
		
		#endregion Constructors
		
		
		
		
		#region INibManaged implementation
		public virtual void LoadFromNib (string nibName, NSBundle bundle)
		{
			this.Manager.LoadController<NibManagedController>(this, nibName, bundle);
		}

		
		
		public NibManager Manager { get; private set; }
		#endregion
	}
}

