using EBAUExercise.Services;

namespace EBAUExercise.Repository
{
    public class MockDataRepository
    {
        public bool Save()
        {
            CountingService.Increment();
            return true;
        }
    }
}