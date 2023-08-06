using MySqlTest;
using MySqlTest.Library;
using Polly;

int batchSize = 10000;
int totalUsers = 40000000;

var dataGenerator = new DataGenerator();
using var userRepository = new UserRepository("Server=localhost;Database=users_db;Uid=root;Pwd=example;");
userRepository.OpenConnection();

var policy = Policy.Handle<Exception>().RetryForever();

for (int i = 0; i < totalUsers; i += batchSize)
{
    var batch = dataGenerator.GenerateUserBatch(i, batchSize);
    Console.WriteLine($"Generated batch #{i}");
    policy.Execute(() => userRepository.InsertBatch(batch));
    Console.WriteLine($"Inserted batch #{i}");
}
