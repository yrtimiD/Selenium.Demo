using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.IE.Test
{
	class Program
	{
		static void Main(string[] args)
		{
			var driver = new OpenQA.Selenium.IE.InternetExplorerDriver();
			driver.Navigate().GoToUrl("https://http.cat/200");
		}
	}
}
