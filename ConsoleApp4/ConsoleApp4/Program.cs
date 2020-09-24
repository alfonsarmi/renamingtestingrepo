using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

			var a = 1;
			var b = 1;
			while (a == 2)
			{
				if (a == 2)
				{
					//this is a test 1
					var v = 1;
					
					if (a == 2)
					{
						//this is a test 2
						var v = 1;
					}
				}
				
				if (a == 2)
				{
					//this is a test 3
					var v = 1;
				}
			}

			if (a == 1) 
			{
				if (a == 1 && b == 2 || b == 1) 
				{
					if (b == 2)  
					{
						var p = 1;
						switch (b) 
						{
							case 1: var z = 1;
							break;
				
							case 2: var w = 2;
							break;

							default: var o = 3;
							break;

						}

					}
				}

			}
		}
    }
}
