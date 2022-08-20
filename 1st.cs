using System;
using System.Collections;

public partial class _Default : System.Web.UI.Page 
{
	protected void Button1_Click(object sender, EventArgs e)
	{
		string[] arr = new string[7];
		arr[0] = "Sunday";
		arr[1] = "Monday";
		arr[2] = "Tuesday";
		arr[3] = "Wednsday";
		arr[4] = "Thursday";
		arr[5] = "friday";
		arr[6] = "Saturday";
arr[7]= "Random";

		ListBox1.DataSource = arr;
		ListBox1.DataBind();
	}
}