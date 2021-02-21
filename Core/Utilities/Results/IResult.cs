using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        //Operasyonlardan sonra kullanıcıya dönülecek sonuçları düzenlemeye başlıyoruz.
        bool Success { get; }
        string Message { get; }
    }
}
