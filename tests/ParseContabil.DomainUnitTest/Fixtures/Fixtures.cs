using ParseContabil.Domain.Entities;

namespace ParseContabil.DomainUnitTest.Fixtures
{
    public static class Fixtures
    {
        public static List<RecordType> GetRecordType()
        {
            return new List<RecordType>
            {
                new()
                {
                    Type = '0',
                    Description = "Alta de Apuntes sin IVA",
                    FileOutPutName = "AltaApuntesIva",
                    Templates = new List<Template>
                    {
                            new (){Order = 1, Size = 1, Head = "Tipo de formato", TypeData = "int"},
                            new (){Order = 2, Size = 5, Head = "Código de empresa", TypeData = "string"},
                            new (){Order = 3, Size = 8, Head = "Fecha del apunte", TypeData = "date"},
                            new (){Order = 4, Size = 1, Head = "Tipo de Registro", TypeData = "string"},
                            new (){Order = 5, Size = 12,Head = "Cuenta" ,TypeData = "string"},
                            new (){Order = 6, Size = 30,Head = "Descripción de la cuenta" ,TypeData = "string"},
                            new (){Order = 7, Size = 1,Head = "Tipo de importe" ,TypeData = "string"},
                            new (){Order = 8, Size = 10,Head = "Referencia del documento" ,TypeData = "string"},
                            new (){Order = 9, Size = 1,Head = "Línea de apunte" ,TypeData = "string"},
                            new (){Order = 10, Size = 30,Head = "Descripción del apunte" ,TypeData = "string"},
                            new (){Order = 11, Size = 14,Head = "Importe" ,TypeData = "string"},
                            new (){Order = 12, Size = 137,Head = "Reserva" ,TypeData = "string"},
                            new (){Order = 13, Size = 1,Head = "Indicador de Asiento de nómina" ,TypeData = "string"},
                            new (){Order = 14, Size = 1,Head = "Tiene Registro Analítico" ,TypeData = "string"},
                            new (){Order = 15, Size = 256,Head = "Reserva" ,TypeData = "string"},
                            new (){Order = 16, Size = 1,Head = "Moneda enlace" ,TypeData = "string"},
                            new (){Order = 17, Size = 1,Head = "Indicador de generado" ,TypeData = "string"}
                    }
                }
            };
        }

        public static Dictionary<string, string[]> GetFile()
            => new Dictionary<string, string[]>{{ "file", new List<string>() { "400041202001010410000023070MICROSOFT ESPAÑAX OPERATION LTD          UFACTURACION TARJETA CREDITO 07+0000000105.6000                                                                                                                                                                                                                                                                                                                                                                                                        NNEN" }.ToArray() }};
    }
}
