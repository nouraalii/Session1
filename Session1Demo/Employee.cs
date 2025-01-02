using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1Demo
{
    internal struct Employee
    {
        private int id;
        private string name;
        private double salary;

        #region Apply Encapsulation using Setter Getter Method
        ////Apply Encapsulation using Setter Getter Method

        ////Setter
        ////public void SetId(int id)
        ////{
        ////    this.id = id;
        ////}

        ////Getter
        //public int getId() 
        //{
        //    return id;
        //}

        ////setter Name

        //public void setName(string name) 
        //{
        //    if (name.Length>8 && name.Length<20)
        //    {
        //        this.name = name;
        //    }

        //}

        //public string getName()
        //{
        //    return name;
        //}

        //public void setSalary(double salary)
        //{
        //    if (salary>0)
        //        this.salary = salary;

        //}

        //public double getSalary() 
        //{
        //    return salary;
        //}

        //public Employee(int id , string name , double salary)
        //{
        //    //SetId(id);
        //    setName(name);
        //    setSalary(salary);
        //}

        //public override string ToString()
        //{
        //    return $"Id:{id} :: Name:{name} :: Salary:{salary}";
        //} 
        #endregion


        //Apply Encapsulation using Properites[Recommended]:
        //1.Full property
        public int Id
        {
            //set
            //get
            set
            {
                this.id = value;
            }
            get 
            {
                return id; 
            }
        }


        public string Name
        {
            set 
            {
                if (value.Length>8 && value.Length<20)
                {
                    this.name = value;
                }
            }
            get 
            {
                return name;
            }
        }

        public double Salary
        {
            set 
            {
                if (value>0)
                {
                    this.salary = value;
                }
            }
            get 
            {
                return salary;
            }
        }

        //2.Automatic property
        public string Address { set; get; }



        //3.special property [Indexer]
        
        

    }
}
