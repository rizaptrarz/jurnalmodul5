using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace jurnalmodul5_103022300104
{
    internal class PemrosesData
    {


        public T DapatkanNilaiTerbesar<T>(T data1, T data2, T data3)
        {
            dynamic Max = data1;

            if (Max < data2) Max = data2;


            if (Max < data3) Max = data3;

            return Max;

        
        }

    }
}
