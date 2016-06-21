namespace TestAutofac.Models
{
	public static class RepositoryHelper
	{
		public static IUnitOfWork GetUnitOfWork()
		{
			return new EFUnitOfWork();
		}
		
		public static IPersonsRepository GetPersonsRepository()
		{
			var repository = new PersonsRepository();
			repository.UnitOfWork = GetUnitOfWork();
			return repository;
		}

		public static IPersonsRepository GetPersonsRepository(IUnitOfWork unitOfWork)
		{
			var repository = new PersonsRepository();
			repository.UnitOfWork = unitOfWork;
			return repository;
		}		
	}
}