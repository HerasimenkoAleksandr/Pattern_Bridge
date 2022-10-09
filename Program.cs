using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Bridge
{

    class Program
    {
        class Abstraction
        {
            protected IImplementation A;

            public Abstraction(IImplementation _A)
            {
                this.A = _A;
            }

            public virtual string Operation()
            {
                return "Абстракция управляет: \n" +
                    A.OperationImplementation();
            }
        }

      
        class ExtendedAbstraction : Abstraction
        {
            public ExtendedAbstraction(IImplementation B) : base(B)
            {
            }

            public override string Operation()
            {
                return "Абстракция с расширением свойств управляет:\n" +
                    base.A.OperationImplementation();
            }
        }

       
        public interface IImplementation
        {
            string OperationImplementation();
        }

     
        class ConcreteImplementationA : IImplementation
        {
            public string OperationImplementation()
            {
                return "Элементом - A.\n";
            }
        }

        class ConcreteImplementationB : IImplementation
        {
            public string OperationImplementation()
            {
                return "Элементом - B.\n";
            }
        }

        class Client
        {
           
            public void ClientCode(Abstraction abstraction)
            {
                Console.Write(abstraction.Operation());
            }
        }

       
            static void Main(string[] args)
            {
                Client client = new Client();

                Abstraction T;
         
               T = new Abstraction(new ConcreteImplementationA());
                client.ClientCode(T);

                Console.WriteLine();

              T = new ExtendedAbstraction(new ConcreteImplementationB());
                client.ClientCode(T);
            }
       
 
    }
}
