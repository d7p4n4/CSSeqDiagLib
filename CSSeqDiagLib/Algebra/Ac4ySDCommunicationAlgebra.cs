using System;
using System.Collections.Generic;
using System.Text;
using d7p4n4Namespace.PreProcessed.Class;
using d7p4n4Namespace.Final.Class;

namespace d7p4n4Namespace.Algebra.Class
{
	public class Ac4ySDCommunicationAlgebra : Ac4ySDCommunicationPreProcessed
	{

		public Int32 getId() {
        		return id;
        }

		public Ac4ySDParticipant getSender() {
        		return Sender;
        }

		public Ac4ySDParticipant getReceiver() {
        		return Receiver;
        }

		public Ac4ySDMessage getMessage() {
        		return Message;
        }


    		public void setId(Int32 newValue) {
        		id = newValue;
        }

    		public void setSender(Ac4ySDParticipant newValue) {
        		Sender = newValue;
        }

    		public void setReceiver(Ac4ySDParticipant newValue) {
        		Receiver = newValue;
        }

    		public void setMessage(Ac4ySDMessage newValue) {
        		Message = newValue;
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

		public Boolean hasSender(){
			if(this.getSender() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasReceiver(){
			if(this.getReceiver() != null){

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

    


	}
}
