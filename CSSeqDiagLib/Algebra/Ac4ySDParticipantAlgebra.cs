using System;
using System.Collections.Generic;
using System.Text;
using d7p4n4Namespace.PreProcessed.Class;
using d7p4n4Namespace.Final.Class;

namespace d7p4n4Namespace.Algebra.Class
{
	public class Ac4ySDParticipantAlgebra : Ac4ySDParticipantPreProcessed
	{

		public Int32 getId() {
        		return id;
        }

		public String getName() {
        		return Name;
        }


    		public void setId(Int32 newValue) {
        		id = newValue;
        }

    		public void setName(String newValue) {
        		Name = newValue;
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

		public Boolean hasName(){
			if(this.getName() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

    


	}
}
