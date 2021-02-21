using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult
    {
        //IResult mirasını alır (success, message).  Buna ek olarak data döndürecek bir yapı kuruyoruz.
        // T türünde Data alan bir yapı kurduk.
        T Data { get; }
    }
}
