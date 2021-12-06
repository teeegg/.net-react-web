using EBAUExercise.Repository;

namespace EBAUExercise.Services
{
    public class DoWorkService
    {
        private readonly MockDataRepository _mockDataRepository;

        public DoWorkService(MockDataRepository mockDataRepository)
        {
            _mockDataRepository = mockDataRepository;
        }

        public bool DoWork()
        {
            CountingService.Increment();
            return _mockDataRepository.Save();
        }
    }
}