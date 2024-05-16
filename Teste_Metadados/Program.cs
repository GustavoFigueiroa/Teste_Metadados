using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Teste_Metadados.DTO;

string? apiUrl = "https://apimetadadosback-dev.metadados.com.br/";
string? cpf = "48638064004";

HttpClient client = new HttpClient();


try
{
    var loginBody = new { 
        email = "avaliacao.api@metadados.com.br",
        senha = "Aval@123"
    };

    StringContent loginPost = new StringContent(JsonConvert.SerializeObject(loginBody), System.Text.Encoding.UTF8, "application/json");
    HttpResponseMessage loginResponse = await client.PostAsync($"{apiUrl}login", loginPost);
    loginResponse.EnsureSuccessStatusCode();
    string loginResponseString = await loginResponse.Content.ReadAsStringAsync();
    JObject loginResponseData = JObject.Parse(loginResponseString);

    var accessToken = loginResponseData != null && loginResponseData.ContainsKey("accessToken") ? loginResponseData["accessToken"].ToString() : "";

    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");
    HttpResponseMessage responseGet = await client.GetAsync($"{apiUrl}cadastro/preAdmissao?cpf={cpf}");
    responseGet.EnsureSuccessStatusCode();
    string responseBodyGet = await responseGet.Content.ReadAsStringAsync();
    List<PreAdmissao> preAdmissaoList = JsonConvert.DeserializeObject<List<PreAdmissao>>(responseBodyGet) ?? [];
    var preAdmissao = preAdmissaoList.FirstOrDefault();


    if (preAdmissao == null || preAdmissao.Pessoa == null)
    {
        throw new Exception("Pessoa não encontrada");
    }

    preAdmissao.Pessoa.Id = null;
    preAdmissao.Pessoa.Nome = "Gustavo";
    preAdmissao.Pessoa.NomeCompleto = "Gustavo Figueiroa";
    preAdmissao.Pessoa.Cpf = "36757245574";

    string modifiedBody = JsonConvert.SerializeObject(preAdmissao);

    StringContent contentPost = new StringContent(modifiedBody, System.Text.Encoding.UTF8, "application/json");
    HttpResponseMessage responsePost = await client.PostAsync($"{apiUrl}cadastro/preAdmissao", contentPost);
    responsePost.EnsureSuccessStatusCode();
    string responseBodyPost = await responsePost.Content.ReadAsStringAsync();
    JObject responsePostData = JObject.Parse(responseBodyPost);

    var id = responsePostData != null && responsePostData.ContainsKey("id") ? responsePostData["id"].ToString() : "";
    Console.WriteLine($"Novo ID criado: {id}");
}
catch (HttpRequestException e)
{
    Console.WriteLine($"Erro na requisição: {e.Message}");
}