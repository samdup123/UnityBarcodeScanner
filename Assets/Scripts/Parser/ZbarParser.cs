using System;
using UnityEngine;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using ZBar;
namespace BarcodeScanner.Parser
{
	public class ZbarParser : IParser
	{
		public ImageScanner Scanner { get; private set; }

		public ZbarParser()
		{
			Scanner = new ImageScanner();
			Scanner.Cache = false;
		}

		public List<ParserResult> Decode (Color32[] colors, int width, int height)
		{
			GCHandle handle1 = GCHandle.Alloc(colors);
			System.Drawing.Image img = System.Drawing.Image.FromHbitmap((IntPtr)handle1);
			List<Symbol> symbols = Scanner.Scan(img);
			List<ParserResult> returnValue = new List<ParserResult>();
			handle1.Free();

			foreach(Symbol s in symbols)
			{
				Console.WriteLine("\t" + s.ToString());
			}

			return returnValue;
		}
	}

}
