#pragma checksum "C:\Users\Pichau\Downloads\provacsharpdotnet\Portal\Views\Home\Information.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6af16b88862f16a78c8ac69e92ae2baed246ca7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Information), @"mvc.1.0.view", @"/Views/Home/Information.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Information.cshtml", typeof(AspNetCore.Views_Home_Information))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Pichau\Downloads\provacsharpdotnet\Portal\Views\_ViewImports.cshtml"
using Portal;

#line default
#line hidden
#line 2 "C:\Users\Pichau\Downloads\provacsharpdotnet\Portal\Views\_ViewImports.cshtml"
using Portal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6af16b88862f16a78c8ac69e92ae2baed246ca7e", @"/Views/Home/Information.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea73c18953461b2da0883cbece56eb399a5ce162", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Information : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Pichau\Downloads\provacsharpdotnet\Portal\Views\Home\Information.cshtml"
  
    ViewData["Title"] = "Objetivo do Teste";

#line default
#line hidden
            BeginContext(53, 4409, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""jumbotron"">
        <h3>Informações sobre o teste</h3>
    </div>
    <div class=""panel panel-info"">
        <div class=""panel-heading"">
            <h3 class=""panel-title"">Geral</h3>
        </div>
        <div class=""panel-body"">
            <div class=""well"">
                O objetivo do teste é testar os conhecimentos do candidato no framework .NET e linguagem C#.
                <br />
                Será analisado a sintaxe C#, legibilidade de código, concorrência, alocação de memória, sincronização, problemas aparentes de layout, performance, uso de recursos e solução de problemas de negócio.
            </div>
        </div>
        <div class=""panel-heading"">
            <h3 class=""panel-title"">Contexto</h3>
        </div>
        <div class=""panel-body"">
            <div class=""well"">
                O teste é composto de três aplicações, sendo:
                <ul>
                    <li>
                        <b>TimeApi:</b> O TimerAp");
            WriteLiteral(@"i é uma API Rest em .NET Core que possui um método GET que retorna um DateTime atual. Antes de retornar o DateTime, ele usa um delay aleatório de 1s até 10s a fim de simular uma API com problemas de performance.
                    </li>
                    <li>
                        <b>Portal:</b> O Portal é uma aplicação ASPNET Core que possui 1 action, Index, que é responsável por gerar uma chave aleatória, usando as informações obtidas da TimeApi.
                        A aplicação Portal possui uma restrição de threads disponíveis para simular um servidor com alta carga de trabalho.<br />
                        No projeto Portal, há uma propriedade estática na classe <b>Program</b>, a <b>NUMBER_OF_VIRTUAL_MACHINES</b>, que simula a quantidade de máquinas utilizadas para atender as requisições.<br />
                        A simulação utiliza a fórmula (Número de Cores * NUMBER_OF_VIRTUAL_MACHINES) para restringir o número de threads da aplicação Portal, ou seja, 1 máquina da simulação é igual ");
            WriteLiteral(@"a 8 threads.<br />
                        Ex.: Se a máquina possui 8 cores e NUMBER_OF_VIRTUAL_MACHINES = 10, então a aplicação Portal simula a utilização de 10 máquinas e poderá utilizar até 80 threads.
                    </li>
                    <li>
                        <b>Requester:</b> O Requester é uma aplicação console em .NET Core que faz chamadas paralelas para o Portal.
                    </li>
                </ul>
                <b>O seu objetivo é refatorar a aplicação, que é funcional, para utilizar o <b>MENOR</b> número possível em <b>NUMBER_OF_VIRTUAL_MACHINES</b> para atender no mínimo 50 requisições simultaneas sem receber BadRequest.</b>
            </div>
        </div>
        <div class=""panel-heading"">
            <h3 class=""panel-title"">Regras</h3>
        </div>
        <div class=""panel-body"">
            <div class=""well"">
                <ul>
                    <li>
                        A aplicação está funcional. Quando voce acessar http://localhost:50");
            WriteLiteral(@"00/Home será calculado uma chave e retornará as informações do processo.
                    </li>
                    <li>
                        NUMBER_OF_VIRTUAL_MACHINES deve ser no mínimo 1, ou seja, simular a utilização de no mínimo um servidor.
                    </li>
                    <li>
                        A configuração default de NUMBER_OF_VIRTUAL_MACHINES é 50, o que garante o funcionamento da aplicação e simula uma estrutura de infraestrutura superdimensionada.
                    </li>
                    <li>
                        Você não possui gestão sobre a TimeAPI, então, não poderá alterar o seu código fonte.
                    </li>
                    <li>
                        Seu objetivo é refatorar a aplicação Portal.
                    </li>
                    <li>
                        Você pode refatorar a aplicação Requester, caso julgue necessário.
                    </li>
                    <li>
                        Use o tempo que ac");
            WriteLiteral(@"har necessário.
                    </li>
                    <li>
                        Ao finalizar o teste, envie o link de um repositório Git, onde todo o testes e suas alterações deverão estar comitados.
                    </li>
                </ul>
            </div>
        </div>
    </div>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
