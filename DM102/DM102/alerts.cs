using System;

namespace DM102
{

	public class Alerts
	{

		private string alertType;
		private string dateTime;
		private string problemDes;


		public Alerts(string alertType, string dateTime, string problemDes) {

			this.alertType = alertType;
			this.dateTime = dateTime;
			this.problemDes = problemDes;
		
		}			
			

		public string SendNotification(){

			return $"{alertType} - {dateTime} - {problemDes}";
		}




	}
}
