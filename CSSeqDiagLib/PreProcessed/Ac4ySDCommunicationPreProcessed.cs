
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
	public class Ac4ySDCommunicationPreProcessed : Ac4y

	{
    		public Int32 id { get; set; }
    		public Ac4ySDParticipant Sender { get; set; }
    		public Ac4ySDParticipant Receiver { get; set; }
    		public Ac4ySDMessage Message { get; set; }
    		public string GUID { get; set; }
		
		public Ac4ySDCommunicationPreProcessed()
		{
			GUID = "";
		}
	}
}