
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
	public class Ac4ySDMessagePreProcessed : Ac4y

	{
    		public Int32 id { get; set; }
    		public String Message { get; set; }
    		public String MessageFromSenderAspect { get; set; }
    		public String MessageFromReceiverSenderAspect { get; set; }
    		public string GUID { get; set; }
		
		public Ac4ySDMessagePreProcessed()
		{
			GUID = "";
		}
	}
}