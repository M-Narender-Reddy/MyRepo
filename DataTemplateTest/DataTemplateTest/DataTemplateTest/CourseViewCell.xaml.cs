using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataTemplateTest
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CourseViewCell : ViewCell
	{
		public CourseViewCell ()
		{
			InitializeComponent ();
            this.CourseFrame.Margin = new Thickness(28, 16, 28, 0);
        }
	}
}