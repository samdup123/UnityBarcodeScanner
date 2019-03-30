using BarcodeScanner.Parser;
using System.Collections.Generic;
using UnityEngine;

namespace BarcodeScanner
{
	public interface IParser
	{
		List<ParserResult> Decode(Color32[] colors, int width, int height);
	}
}
