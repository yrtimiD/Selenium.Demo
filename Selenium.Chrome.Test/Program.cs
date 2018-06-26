using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Chrome.Test
{
	class Program
	{
		static void Main(string[] args)
		{
			var driver = new OpenQA.Selenium.Chrome.ChromeDriver();
			driver.Navigate().GoToUrl("https://http.cat/200");
		}
	}
}
