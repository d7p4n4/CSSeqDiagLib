
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using d7p4n4Namespace.Final.Class;
using d7p4n4.Final.Class;
using CSGUIDLib;

namespace d7p4n4Namespace.PreProcessed.Class
{
	            [GUID("")]
	public class Ac4ySDParticipantPreProcessed : Ac4y

	{
    		public Int32 id { get; set; }
    		public String Name { get; set; }
    		public string GUID { get; set; }
		
		public Ac4ySDParticipantPreProcessed()
		{
			GUID = "";
		}
	}
}