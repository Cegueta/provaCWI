using Humanizer.Bytes;
using Microsoft.AspNetCore.Mvc;
using Portal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Portal.Controllers
{
  public class HomeController : Controller
  {
    public static int _requestsCounter = 0;

    public async Task<IActionResult> Index()
    {
      // Incrementa o contador de requisições
      _requestsCounter++;

      // Busca as informações de data da API TimeAPI
      HttpClient httpClient = new HttpClient();
      string result = await httpClient.GetStringAsync(Program.API_ADDRESS);

      // Extrai o dia da data
      int day = int.Parse(result.Split(",")[1].Split(" ")[1]);

      // Calcula e gera a chave
      string key = "";
      for (int i = 0; i < 4096; i++)
      {
        var random = new Random();
        key = string.Concat(key, day * i * random.Next(100, 9999));
      }

      // Obtem os números ímpares gerados na chave
      var oddNumbers = new List<int>();
      foreach (var c in key.ToArray())
        if (int.Parse(c.ToString()) % 2 != 0)
          oddNumbers.Add(int.Parse(c.ToString()));

      InformationsViewModel Informations = new InformationsViewModel();
      Informations.Date = result;
      Informations.Key = key;
      Informations.Sum = oddNumbers.Sum(x => x);
      Informations.VirtualMachines = Program.NUMBER_OF_VIRTUAL_MACHINES;
      Informations.RequestsCounter = _requestsCounter;

      // Aplica informações de memória para View
      Informations.GC0 = GC.CollectionCount(0);
      Informations.GC1 = GC.CollectionCount(1);
      Informations.GC2 = GC.CollectionCount(2);
      Informations.CurrentMemory = ByteSize.FromBytes(GC.GetTotalMemory(false)).ToString();
      Informations.PrivateBytes = ByteSize.FromBytes(Process.GetCurrentProcess().WorkingSet64).ToString();

      // Retorna View
      return View("Index", Informations);
    }

    public IActionResult Information()
    {
      return View();
    }

  }
}