namespace RestSharpAPI.Tests;

public class HttpClientTest
{
    [Test]
    public async Task TaskSimpleHttpClientTest()
    {
        const string restUrl = "https://reqres.in/";

        // Экземпляр клиента
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Настраиваем  и выполняем GET запрос к URL
                HttpResponseMessage response = await client.GetAsync(restUrl);

                // Проверяем успешность запроса
                if (response.IsSuccessStatusCode)
                {
                    // Читаем содержимое ответа
                    string responseContent = await response.Content.ReadAsStringAsync();

                    // Выводим результат
                    Console.WriteLine(responseContent);
                }
                else
                    Console.WriteLine("Ошибка: " + response.StatusCode);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}