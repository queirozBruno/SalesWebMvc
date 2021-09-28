using System;

namespace SalesWebMvc.Models.ViewModels
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; } //id interno da requuisi��o
        public string Message { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId); //Vai retornar se n�o for nulo ou vazio
    }
}