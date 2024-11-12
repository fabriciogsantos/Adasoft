using System.Data;
using System.Diagnostics;
using ParseContabil.Domain.Entities;

namespace ParseContabil.Infrastructure.Seeds
{
    public static class SeedParse
    {
        static readonly Guid id0 = Guid.NewGuid();
        static readonly Guid id1 = Guid.NewGuid();
        static readonly Guid id9 = Guid.NewGuid();
        static readonly Guid idc = Guid.NewGuid();
        public static (List<RecordType> recordTypes, List<Template> templates) Seeds()
        {
        
            var recordTypes = new List<RecordType>
            {
                new()
                {
                    Id = id0, Type = '0', Description = "Alta de Apuntes sin IVA", FileOutPutName = "AltaApuntesIva"
                },
                new()
                {
                    Id = id1, Type = '1', Description = "Alta Cabecera de apuntes con IVA (Formato para Facturas)",
                    FileOutPutName = "AltaCabeceraApuntesConIva"
                },
                new()
                {
                    Id = id9, Type = '9', Description = "Detalle de apuntes con IVA (Facturas y rectificativas)",
                    FileOutPutName = "DetalleApuntesConIva"
                },
                new()
                {
                    Id = idc, Type = 'C', Description = "Alta y modificación de cuentas y/o clientes o proveedores",
                    FileOutPutName = "AltaModificacionCuentas"
                }
            };

            var templates = new List<Template>();
            templates.AddRange(SeedRecordTypeZero(id0));
            templates.AddRange(SeedRecordTypeOne(id1));
            templates.AddRange(SeedRecordTypeNine(id9));
            templates.AddRange(SeedRecordTypeC(idc));

            return (recordTypes, templates);
        }

        private static List<Template> SeedRecordTypeZero(Guid id)
        {
            return new List<Template>
               {
                   new (){RecordTypeId = id, Order = 1, Size = 1, Head = "Tipo de formato", TypeData = "int"},
                   new (){RecordTypeId = id, Order = 2, Size = 5, Head = "Codigo de empresa", TypeData = "string"},
                   new (){RecordTypeId = id, Order = 3, Size = 8, Head = "Fecha del apunte", TypeData = "date"},
                   new (){RecordTypeId = id, Order = 4, Size = 1, Head = "Tipo de Registro", TypeData = "string"},
                   new (){RecordTypeId = id, Order = 5, Size = 12,Head = "Cuenta" ,TypeData = "string"},
                   new (){RecordTypeId = id, Order = 6, Size = 30,Head = "Descripcion de la cuenta" ,TypeData = "string"},
                   new (){RecordTypeId = id, Order = 7, Size = 1,Head = "Tipo de importe" ,TypeData = "string"},
                   new (){RecordTypeId = id, Order = 8, Size = 10,Head = "Referencia del documento" ,TypeData = "string"},
                   new (){RecordTypeId = id, Order = 9, Size = 1,Head = "Linea de apunte" ,TypeData = "string"},
                   new (){RecordTypeId = id, Order = 10, Size = 30,Head = "Descripcion del apunte" ,TypeData = "string"},
                   new (){RecordTypeId = id, Order = 11, Size = 14,Head = "Importe" ,TypeData = "string"},
                   new (){RecordTypeId = id, Order = 12, Size = 137,Head = "Reserva" ,TypeData = "string"},
                   new (){RecordTypeId = id, Order = 13, Size = 1,Head = "Indicador de Asiento de nomina" ,TypeData = "string"},
                   new (){RecordTypeId = id, Order = 14, Size = 1,Head = "Tiene Registro Analitico" ,TypeData = "string"},
                   new (){RecordTypeId = id, Order = 15, Size = 256,Head = "Reserva" ,TypeData = "string"},
                   new (){RecordTypeId = id, Order = 16, Size = 1,Head = "Moneda enlace" ,TypeData = "string"},
                   new (){RecordTypeId = id, Order = 17, Size = 1,Head = "Indicador de generado" ,TypeData = "string"}
              };
        }

        public static List<Template> SeedRecordTypeOne(Guid id)
        {
           
            return  new List<Template>
                {
                    new (){RecordTypeId = id, Order = 1, Size = 1, Head = "Tipo de formato", TypeData = "int"},
                    new (){RecordTypeId = id, Order = 2, Size = 5, Head = "Codigo de empresa", TypeData = "string"},
                    new (){RecordTypeId = id, Order = 3, Size = 8, Head = "Fecha del apunte", TypeData = "date"},
                    new (){RecordTypeId = id, Order = 4, Size = 1, Head = "Tipo de Registro", TypeData = "string"},
                    new (){RecordTypeId = id, Order = 5, Size = 12,Head = "Cuenta" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 6, Size = 30,Head = "Descripcion de la cuenta" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 7, Size = 1,Head = "Tipo de factura" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 8, Size = 10,Head = "Numero de factura o documento" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 9, Size = 1,Head = "Linea de apunte" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 10, Size = 30,Head = "Descripcion del apunte" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 11, Size = 14,Head = "Importe" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 12, Size = 62,Head = "Reserva" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 13, Size = 14,Head = "NIF cliente o proveedor" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 14, Size = 40,Head = "Nombre cliente o proveedor" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 15, Size = 5,Head = "Codigo postal" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 16, Size = 2,Head = "Reserva" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 17, Size = 8,Head = "Fecha de operacion" ,TypeData = "date"},
                    new (){RecordTypeId = id, Order = 18, Size = 8,Head = "Fecha de factura" ,TypeData = "date"},
                    new (){RecordTypeId = id, Order = 19, Size = 60,Head = "Numero factura ampliado para el SII" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 20, Size = 196,Head = "reserva" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 21, Size = 1,Head = "Moneda enlace" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 22, Size = 1,Head = "Indicador de generado" ,TypeData = "string"},
            };
        }

        public static List<Template> SeedRecordTypeNine(Guid id)
        {
            return  new List<Template>
                {
                    new (){RecordTypeId = id, Order = 1, Size = 1, Head = "Tipo de formato", TypeData = "int"},
                    new (){RecordTypeId = id, Order = 2, Size = 5, Head = "Codigo de empresa", TypeData = "string"},
                    new (){RecordTypeId = id, Order = 3, Size = 8, Head = "Fecha del apunte", TypeData = "date"},
                    new (){RecordTypeId = id, Order = 4, Size = 1, Head = "Tipo de Registro", TypeData = "string"},
                    new (){RecordTypeId = id, Order = 5, Size = 12,Head = "Cuenta" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 6, Size = 30,Head = "Descripcion de la cuenta" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 7, Size = 1,Head = "Tipo de importe" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 8, Size = 10,Head = "Número de factura o documento" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 9, Size = 1,Head = "Linea de apunte" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 10, Size = 30,Head = "Descripcion del apunte" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 11, Size = 2,Head = "Subtipo de factura" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 12, Size = 14,Head = "Base imponible" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 13, Size = 5,Head = "Porcentaje de IVA" ,TypeData = "decimal"},
                    new (){RecordTypeId = id, Order = 14, Size = 14,Head = "Cuota de IVA" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 15, Size = 5,Head = "Porcentaje de Recargo" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 16, Size = 14,Head = "Cuota de Recargo" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 17, Size = 5,Head = "Porcentaje de Retencion" ,TypeData = "decimal"},
                    new (){RecordTypeId = id, Order = 18, Size = 14,Head = "Cuota de Retencion" ,TypeData = "date"},
                    new (){RecordTypeId = id, Order = 19, Size = 1,Head = "Operacion sujeta a IVA" ,TypeData = "date"},
                    new (){RecordTypeId = id, Order = 20, Size = 1,Head = "Marca afecta 415" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 21, Size = 1,Head = "Marca factura en criterio de caja" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 22, Size = 14,Head = "reserva" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 23, Size = 12,Head = "Cuenta de IVA Soportado" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 24, Size = 12,Head = "Cuenta de recargo Soportado" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 25, Size = 12,Head = "Cuenta de retencion" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 26, Size = 12,Head = "Cuenta de IVA 2 Repercutido" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 27, Size = 12,Head = "Cuenta de recargo 2 Repercutid" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 28, Size = 1,Head = "Tiene Registro Analitico" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 29, Size = 256,Head = "reserva" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 30, Size = 1,Head = "Moneda enlace" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 31, Size = 1,Head = "Indicador de generado" ,TypeData = "string"},
            };
        }

        public static List<Template> SeedRecordTypeC(Guid id)
        {
            return  new List<Template>
                {
                    new (){RecordTypeId = id, Order = 1, Size = 1, Head = "Tipo de formato", TypeData = "int"},
                    new (){RecordTypeId = id, Order = 2, Size = 5, Head = "Codigo de empresa", TypeData = "string"},
                    new (){RecordTypeId = id, Order = 3, Size = 8, Head = "Fecha del alta", TypeData = "date"},
                    new (){RecordTypeId = id, Order = 4, Size = 1, Head = "Tipo de Registro", TypeData = "string"},
                    new (){RecordTypeId = id, Order = 5, Size = 12,Head = "Cuenta" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 6, Size = 30,Head = "Actualizar Saldo Inicial" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 7, Size = 1,Head = "Actualizar Saldo Inicial" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 8, Size = 14,Head = "Saldo Inicial" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 9, Size = 1,Head = "Ampliacion" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 10, Size = 4,Head = "reserva" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 11, Size = 14,Head = "NIF" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 12, Size = 2,Head = "Siglas Vía Publica" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 13, Size = 30,Head = "Via Publica" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 14, Size = 5,Head = "Numero" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 15, Size = 2,Head = "Escalera" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 16, Size = 2,Head = "Piso" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 17, Size = 2,Head = "Puerta" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 18, Size = 20,Head = "Municipio" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 19, Size = 5,Head = "Codigo Postal" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 20, Size = 15,Head = "Provincia" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 21, Size = 3,Head = "Pais" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 22, Size = 12,Head = "Telefono" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 23, Size = 4,Head = "Extension" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 24, Size = 12,Head = "Fax" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 25, Size = 30,Head = "E-mail" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 26, Size = 2,Head = "Reservado" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 27, Size = 1,Head = "Criterio de caja" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 28, Size = 2,Head = "Reservado" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 29, Size = 12,Head = "Cuenta contrapartida" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 30, Size = 2,Head = "Codigo de pais" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 31, Size = 254,Head = "reserva" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 32, Size = 1,Head = "Moneda enlace" ,TypeData = "string"},
                    new (){RecordTypeId = id, Order = 33, Size = 1,Head = "Indicador de generado" ,TypeData = "string"},
            };
        }
    }
}
