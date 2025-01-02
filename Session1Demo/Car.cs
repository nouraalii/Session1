using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1Demo
{
    internal class Car
    {
		#region Attribute
		private int id;
		private int speed;
		private string model;
		#endregion

		#region Property
		public string Model
		{
			get { return model; }
			set { model = value; }
		}



		public int Speed
		{
			get { return speed; }
			set { speed = value; }
		}



		public int Id
		{
			get { return id; }
			set { id = value; }
		}
        #endregion
        //public string Address { get; set; }//prop

        //CLR will generate parameterless constructor
        //This constructor do nothing



        //CTOR
        //public Car()
        //{

        //} // Do Nothing

        public Car(int id , int speed , string model):this(id ,speed)
        {
            //Id = id;
			//Speed = speed;
			Model = model;
        }


        public Car(int id, int speed):this(id)
        {
            //Id = id;
            Speed = speed;
        }


        public Car(int id)
        {
            Id = id;
        }

        public override string ToString()
        {
			return $"Id:{Id} :: Speed:{Speed} :: Model:{Model}";
        }
    }
}
