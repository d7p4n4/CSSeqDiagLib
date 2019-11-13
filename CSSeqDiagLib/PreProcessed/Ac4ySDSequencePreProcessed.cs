
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CSGUIDLib;
using d7p4n4Namespace.Final.Class;
using d7p4n4.Final.Class;

namespace d7p4n4Namespace.PreProcessed.Class
{
	            [GUID("")]
	public class Ac4ySDSequencePreProcessed : Ac4y

	{
    		public Int32 id { get; set; }
    		public List<Ac4ySDCommunication> Communication { get; set; }
    		public string GUID { get; set; }
		
		public Ac4ySDSequencePreProcessed()
		{
			GUID = "";
		}
	}
}