using System;
using System.Collections.Generic;
using System.Text;
using d7p4n4Namespace.PreProcessed.Class;
using d7p4n4Namespace.Final.Class;

namespace d7p4n4Namespace.Algebra.Class
{
	public class Ac4ySDSequenceAlgebra : Ac4ySDSequencePreProcessed
	{

		public Int32 getId() {
        		return id;
        }

		public List<Ac4ySDCommunication> getCommunication() {
        		return Communication;
        }


    		public void setId(Int32 newValue) {
        		id = newValue;
        }

    		public void setCommunication(List<Ac4ySDCommunication> newValue) {
        		Communication = newValue;
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

    

    		public int countCommunication()
        	{
        	        int i = this.getCommunication().Count;

            		return i;
        	}



    		public Boolean hasCommunicationMember()
        	{
        	        int i = this.getCommunication().Count;

			if(i > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
        	}

	}
}
