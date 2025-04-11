using System;
namespace StudentPortal.Web.Models.Entities
{
	public class Student
	{
        
        //Add Required details to be perform in CRUD operation
		public int Id { get; set; }

		public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool Subscribed { get; set; }

    }
}

