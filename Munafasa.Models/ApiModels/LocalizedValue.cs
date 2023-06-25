using System;
namespace Munafasa.Models.ApiModels
{
	public class LocalizedValue
	{
		public LocalizedValue(string ar, string en)
		{
			this.ar = ar;
			this.en = en;
		}
		public string ar { get; set; }
		public string en { get; set; }
	}
}

