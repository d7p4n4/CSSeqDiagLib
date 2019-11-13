using System;
using System.Collections.Generic;
using System.Text;
using d7p4n4Namespace.PreProcessed.Class;
using d7p4n4Namespace.Final.Class;

namespace d7p4n4Namespace.Algebra.Class
{
	public class Ac4ySDMessageAlgebra : Ac4ySDMessagePreProcessed
	{

		public Int32 getId() {
        		return id;
        }

		public String getMessage() {
        		return Message;
        }

		public String getMessageFromSenderAspect() {
        		return MessageFromSenderAspect;
        }

		public String getMessageFromReceiverSenderAspect() {
        		return MessageFromReceiverSenderAspect;
        }


    		public void setId(Int32 newValue) {
        		id = newValue;
        }

    		public void setMessage(String newValue) {
        		Message = newValue;
        }

    		public void setMessageFromSenderAspect(String newValue) {
        		MessageFromSenderAspect = newValue;
        }

    		public void setMessageFromReceiverSenderAspect(String newValue) {
        		MessageFromReceiverSenderAspect = newValue;
        }
	
		public Boolean hasId(){
			if(this.getId() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasMessage(){
			if(this.getMessage() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasMessageFromSenderAspect(){
			if(this.getMessageFromSenderAspect() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasMessageFromReceiverSenderAspect(){
			if(this.getMessageFromReceiverSenderAspect() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

    


	}
}
