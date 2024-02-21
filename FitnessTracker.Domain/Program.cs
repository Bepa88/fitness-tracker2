using FitnessTracker.Domain.Models;
using FitnessTracker.Domain.Repository;
using FitnessTracker.Domain.DataAccess;

public class Program
{
    private static SportClubDbContext context = new SportClubDbContext();

    private static IBaseRepository<User> userRepository = new BaseRepository<User>(context);
    public static void Main()
    {
        User olga = new User { FirstName = "Olga", LastName = "Grab", UsersIdInBot = "124234"};
        userRepository.AddAsync(olga);
    }
    

}


