using System;
using System.Linq;
using System.Collections.Generic;
	
namespace TestAutofac.Models
{   
	public  class PersonsRepository : EFRepository<Persons>, IPersonsRepository
	{

	}

	public  interface IPersonsRepository : IRepository<Persons>
	{

	}
}