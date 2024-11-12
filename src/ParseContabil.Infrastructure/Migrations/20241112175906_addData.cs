using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParseContabil.Infrastructure.Migrations
{
    public partial class addData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Head",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "RecordTypes",
                columns: new[] { "Id", "Description", "FileOutPutName", "PositionType", "Type" },
                values: new object[,]
                {
                    { new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), "Alta y modificación de cuentas y/o clientes o proveedores", "AltaModificacionCuentas", 0, "C" },
                    { new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"), "Alta Cabecera de apuntes con IVA (Formato para Facturas)", "AltaCabeceraApuntesConIva", 0, "1" },
                    { new Guid("afd79133-a547-476b-bf1c-8fff019d8b65"), "Alta de Apuntes sin IVA", "AltaApuntesIva", 0, "0" },
                    { new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), "Detalle de apuntes con IVA (Facturas y rectificativas)", "DetalleApuntesConIva", 0, "9" }
                });

            migrationBuilder.InsertData(
                table: "Templates",
                columns: new[] { "Id", "Head", "Order", "RecordTypeId", "Size", "TypeData" },
                values: new object[,]
                {
                    { new Guid("06ffbc85-859d-4c0f-8b3f-dd4cf646a915"), "Línea de apunte", 9, new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"), 1, "string" },
                    { new Guid("093680aa-5822-45c2-994b-9e4cf2571df7"), "Fecha del apunte", 3, new Guid("afd79133-a547-476b-bf1c-8fff019d8b65"), 8, "date" },
                    { new Guid("0a6bef3a-74aa-48d2-ab5d-c2e3d1094f4b"), "Saldo Inicial", 8, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 14, "string" },
                    { new Guid("0c63e5c8-d56f-486d-ab1a-4c253a053546"), "Cuenta de recargo Soportado", 24, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 12, "string" },
                    { new Guid("0c66bd42-650b-426e-b652-7f64d874d612"), "Reservado", 28, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 2, "string" },
                    { new Guid("1062f629-2663-434f-8ff6-5308fd1e2a93"), "Vía Publica", 13, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 30, "string" },
                    { new Guid("11198688-30d8-4743-bce0-0c3a36164748"), "Descripción de la cuenta", 6, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 30, "string" },
                    { new Guid("111bc89a-feae-47c8-a2e1-d2a5a9f69abc"), "Tipo de formato", 1, new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"), 1, "int" },
                    { new Guid("1154b4f8-a91b-42f0-8d1f-52dccd3e6cd9"), "Cuota de Retención", 18, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 14, "date" },
                    { new Guid("16d1c217-0bd4-4be7-be34-1b2e38a999b0"), "Reserva", 12, new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"), 62, "string" },
                    { new Guid("1943dc4e-d469-488a-a803-3c433b2f4ec7"), "Actualizar Saldo Inicial", 6, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 30, "string" },
                    { new Guid("1d02a8c2-b6a6-4633-b405-902a1d256d9b"), "Cuenta de IVA Soportado", 23, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 12, "string" },
                    { new Guid("1d0d3356-b08e-42b9-b84c-2d7e66f4f181"), "reserva", 29, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 256, "string" },
                    { new Guid("1e05744b-77d3-4a84-8421-18a0306c49dd"), "Indicador de Asiento de nómina", 13, new Guid("afd79133-a547-476b-bf1c-8fff019d8b65"), 1, "string" },
                    { new Guid("2125d18a-9cb2-4c12-bbf9-7d24fb313d81"), "Provincia", 20, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 15, "string" },
                    { new Guid("214a16b3-ac6f-4cbf-b68a-6660fc9959d2"), "Cuota de Recargo", 16, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 14, "string" },
                    { new Guid("226385e5-ce7f-434f-910f-063a49a2966d"), "NIF cliente o proveedor", 13, new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"), 14, "string" },
                    { new Guid("234fe866-ab03-4062-808f-c5bc785d8a20"), "Indicador de generado", 31, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 1, "string" },
                    { new Guid("23b2ac03-5e63-4dae-8945-5033d9e648b5"), "Código de empresa", 2, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 5, "string" },
                    { new Guid("273f5b40-9313-4fec-b6eb-55d46e6f4a15"), "Escalera", 15, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 2, "string" },
                    { new Guid("27ab0b48-f3f5-4401-bc8f-bcae769c0901"), "Cuenta", 5, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 12, "string" },
                    { new Guid("27d00eab-d448-42ba-842c-92d0e062bfe7"), "Cuenta", 5, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 12, "string" },
                    { new Guid("27d58ad7-bbb5-4f8b-8417-77f857550a8c"), "NIF", 11, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 14, "string" },
                    { new Guid("2bfcbf81-a8c7-4360-9d08-6890ad885b87"), "Base imponible", 12, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 14, "string" },
                    { new Guid("2ce012c3-dde9-49c2-9535-113eeeec32d4"), "reserva", 10, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 4, "string" },
                    { new Guid("31c30e03-6a9c-4bda-8216-bbf46551df4a"), "Código postal", 15, new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"), 5, "string" },
                    { new Guid("36e1c68b-1120-44c7-8809-e62dc19a9e9d"), "Pais", 21, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 3, "string" },
                    { new Guid("37e94c41-4275-4423-89db-5a0e7e68cd02"), "Criterio de caja", 27, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 1, "string" },
                    { new Guid("383aec0b-86af-4df2-b68f-400661e0cfca"), "Cuenta contrapartida", 29, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 12, "string" },
                    { new Guid("3b1b3199-e970-4cfb-a8e1-eb55de28b166"), "Código de empresa", 2, new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"), 5, "string" },
                    { new Guid("3dd6e9fe-b0ce-406b-8c67-1f85d2c8b737"), "Municipio", 18, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 20, "string" },
                    { new Guid("3fa7dea9-3523-48a9-b9e6-dc3a379ea9ce"), "Tipo de factura", 7, new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"), 1, "string" },
                    { new Guid("3fe5907a-79b0-49fe-b20f-7c4cad3f7ce2"), "Porcentaje de IVA", 13, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 5, "decimal" },
                    { new Guid("4087f9ab-ff5f-461e-a3a3-7733bd2656a2"), "Descripción del apunte", 10, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 30, "string" },
                    { new Guid("4269296d-dc98-4cfc-b2f6-eab257e045d6"), "Piso", 16, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 2, "string" },
                    { new Guid("45951ac1-e766-452d-80d3-8f645328d4a9"), "Fecha de operación", 17, new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"), 8, "date" },
                    { new Guid("47cbcf0f-443d-4b42-9c87-aa8ef58b24ac"), "Marca factura en criterio de caja", 21, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 1, "string" },
                    { new Guid("47d393f1-db68-424f-ba30-3594ea66cac4"), "Descripción del apunte", 10, new Guid("afd79133-a547-476b-bf1c-8fff019d8b65"), 30, "string" },
                    { new Guid("4e0f481c-048c-49e7-b370-bcd1dbba2490"), "Tipo de Registro", 4, new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"), 1, "string" },
                    { new Guid("597ea89e-15fa-4d2d-ad91-2245e3c3b3aa"), "Tipo de importe", 7, new Guid("afd79133-a547-476b-bf1c-8fff019d8b65"), 1, "string" },
                    { new Guid("6124f8c3-b010-4c5b-aea2-8b7ee64ed808"), "Indicador de generado", 33, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 1, "string" },
                    { new Guid("61813cf5-4425-40ac-8114-f386aba4b27d"), "Cuenta de recargo 2 Repercutid", 27, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 12, "string" }
                });

            migrationBuilder.InsertData(
                table: "Templates",
                columns: new[] { "Id", "Head", "Order", "RecordTypeId", "Size", "TypeData" },
                values: new object[,]
                {
                    { new Guid("63929899-e3e6-45af-bf9e-3896fd0a05cf"), "Cuenta", 5, new Guid("afd79133-a547-476b-bf1c-8fff019d8b65"), 12, "string" },
                    { new Guid("65c7dbd7-28c6-4cbb-8f3c-1d6b384479b2"), "Reservado", 26, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 2, "string" },
                    { new Guid("67cb94a5-9533-4515-8ebe-f3bf12c77c9a"), "Cuenta de retención", 25, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 12, "string" },
                    { new Guid("68a28b6f-4268-444d-b848-4b7ca3d269b0"), "Tipo de formato", 1, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 1, "int" },
                    { new Guid("6b629ef4-565b-4130-888d-dcd787d473f6"), "Ampliación", 9, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 1, "string" },
                    { new Guid("6e37a529-f21a-4ccd-8aaa-aef92e028537"), "Código de empresa", 2, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 5, "string" },
                    { new Guid("6fe8e3f1-e02d-41e6-aa0d-901834ccbd22"), "Cuota de IVA", 14, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 14, "string" },
                    { new Guid("73423762-8759-40e1-bb26-efb0d64a6b3c"), "Fecha del alta", 3, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 8, "date" },
                    { new Guid("760046b5-af4f-480d-8048-d599d21dbe7f"), "Nombre cliente o proveedor", 14, new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"), 40, "string" },
                    { new Guid("77567665-6f1f-4c43-9f0f-c8219a18a20b"), "reserva", 22, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 14, "string" },
                    { new Guid("77716f25-17ae-4fb4-8f3e-54b6c5624af9"), "Tiene Registro Analítico", 28, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 1, "string" },
                    { new Guid("7985a466-15ef-406d-a5b5-ddab6c946e88"), "Reserva", 16, new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"), 2, "string" },
                    { new Guid("7ac39cc8-c92e-4830-8c11-28e6c782f2d8"), "Porcentaje de Retención", 17, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 5, "decimal" },
                    { new Guid("7ceaa780-2299-4129-93c5-db2d97665acf"), "Tipo de Registro", 4, new Guid("afd79133-a547-476b-bf1c-8fff019d8b65"), 1, "string" },
                    { new Guid("7cf3dcba-9f34-4e76-a527-3ac9fb4eebfd"), "Número de factura o documento", 8, new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"), 10, "string" },
                    { new Guid("7eca47e0-50c1-4d18-b3c2-eef4e839a910"), "reserva", 20, new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"), 196, "string" },
                    { new Guid("7f673eb7-3ae0-43ae-9b84-5427b6e6d839"), "Descripción de la cuenta", 6, new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"), 30, "string" },
                    { new Guid("80f3dce8-c22f-4dc1-a06c-e265324740dd"), "Tipo de Registro", 4, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 1, "string" },
                    { new Guid("81259e98-64fc-480c-98f9-0195c06da237"), "Puerta", 17, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 2, "string" },
                    { new Guid("819331de-ea9b-4fb1-8dcf-1e8d37458423"), "reserva", 31, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 254, "string" },
                    { new Guid("85a7a435-9274-458c-81c4-a89cdb0d107c"), "Fecha del apunte", 3, new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"), 8, "date" },
                    { new Guid("8647a5f7-2a69-4de7-b0d9-965b4dae4fb2"), "Marca afecta 415", 20, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 1, "string" },
                    { new Guid("8ad94da2-502c-457e-8d3d-0b185c8476a7"), "Tipo de formato", 1, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 1, "int" },
                    { new Guid("8af0dd84-c114-4c95-a55d-7071e15894d8"), "Moneda enlace", 16, new Guid("afd79133-a547-476b-bf1c-8fff019d8b65"), 1, "string" },
                    { new Guid("8b0147ff-da57-494d-93af-961e30cfc087"), "Fecha del apunte", 3, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 8, "date" },
                    { new Guid("8e265aab-3db4-4ffb-a2f7-283a1565959b"), "Tipo de importe", 7, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 1, "string" },
                    { new Guid("91c985ab-96d2-463d-a093-32d7116bffba"), "Actualizar Saldo Inicial", 7, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 1, "string" },
                    { new Guid("921637b8-9505-495d-bfa9-cb1850d4e393"), "Línea de apunte", 9, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 1, "string" },
                    { new Guid("927eaad1-39f2-4971-81c8-32c075f7a3e4"), "Operación sujeta a IVA", 19, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 1, "date" },
                    { new Guid("9708fdfb-c217-46ee-97c4-70cdb8e5b7e1"), "Subtipo de factura", 11, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 2, "string" },
                    { new Guid("9726e40f-db46-4c98-ab8d-cdcdb09aef45"), "Tipo de formato", 1, new Guid("afd79133-a547-476b-bf1c-8fff019d8b65"), 1, "int" },
                    { new Guid("9c06d2fb-4bf4-47c6-a883-0db5664bc63a"), "Tipo de Registro", 4, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 1, "string" },
                    { new Guid("a765b7fb-1229-496e-8f55-a20d9bfe2645"), "Número factura ampliado para el SII", 19, new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"), 60, "string" },
                    { new Guid("ab78558e-5dae-4edb-ad0b-ab71ef503dde"), "Fax", 24, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 12, "string" },
                    { new Guid("ad960616-866a-44eb-9d21-4df78dfd8d84"), "Moneda enlace", 30, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 1, "string" },
                    { new Guid("b1d41dcf-444f-41eb-9032-a62ba25e02bc"), "Código Postal", 19, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 5, "string" },
                    { new Guid("b35195ac-5d6c-429e-819c-5a620a24e9ba"), "Código de empresa", 2, new Guid("afd79133-a547-476b-bf1c-8fff019d8b65"), 5, "string" },
                    { new Guid("b4172b43-c8b1-4a9d-bef8-d3f634d958b5"), "Tiene Registro Analítico", 14, new Guid("afd79133-a547-476b-bf1c-8fff019d8b65"), 1, "string" },
                    { new Guid("b6e4b283-a8ff-4e3e-8b57-5697ad1dfac8"), "Siglas Vía Publica", 12, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 2, "string" },
                    { new Guid("bb5b9d81-2c3c-4a65-a838-58616ae61212"), "Reserva", 12, new Guid("afd79133-a547-476b-bf1c-8fff019d8b65"), 137, "string" },
                    { new Guid("bdb53b41-7a53-4cd7-82e3-a2cec8a1fae8"), "Referencia del documento", 8, new Guid("afd79133-a547-476b-bf1c-8fff019d8b65"), 10, "string" },
                    { new Guid("bfe95d9d-c926-49c2-9c4a-1a438093af44"), "Indicador de generado", 22, new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"), 1, "string" }
                });

            migrationBuilder.InsertData(
                table: "Templates",
                columns: new[] { "Id", "Head", "Order", "RecordTypeId", "Size", "TypeData" },
                values: new object[,]
                {
                    { new Guid("c90b0ee6-a783-4359-aa84-cbd7340de0ec"), "Número de factura o documento", 8, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 10, "string" },
                    { new Guid("cb2aa014-1ad8-4f9b-b9ad-bf1a85738f31"), "Descripción de la cuenta", 6, new Guid("afd79133-a547-476b-bf1c-8fff019d8b65"), 30, "string" },
                    { new Guid("d01fa2f7-4e5c-49c6-a25f-acab62a4f27e"), "Indicador de generado", 17, new Guid("afd79133-a547-476b-bf1c-8fff019d8b65"), 1, "string" },
                    { new Guid("d7a09426-45e8-4c33-9251-fc5a82658a39"), "Importe", 11, new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"), 14, "string" },
                    { new Guid("db536ac7-3aa7-47a0-bff2-3912ab11e63e"), "Importe", 11, new Guid("afd79133-a547-476b-bf1c-8fff019d8b65"), 14, "string" },
                    { new Guid("dc0dba32-cf83-47be-9666-25ea55bc45fd"), "Porcentaje de Recargo", 15, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 5, "string" },
                    { new Guid("dd479f65-4ce4-4420-9d55-6ad2acdb053f"), "Fecha de factura", 18, new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"), 8, "date" },
                    { new Guid("de3f8b2e-827b-476d-b3f5-bd1584c661d5"), "Numero", 14, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 5, "string" },
                    { new Guid("dee8df34-1949-4b03-b778-15394acc3545"), "Cuenta", 5, new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"), 12, "string" },
                    { new Guid("eab77874-1336-494b-a4bb-9eace0a656c6"), "Código de país", 30, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 2, "string" },
                    { new Guid("ed5cbb21-9fd1-444f-bebd-652ee4b04391"), "Moneda enlace", 32, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 1, "string" },
                    { new Guid("ed81a2ae-e886-4ed5-b1b3-ad4952e1dd49"), "Moneda enlace", 21, new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"), 1, "string" },
                    { new Guid("edf1f8e9-6c3a-4a73-bb98-9fb702d406a6"), "Reserva", 15, new Guid("afd79133-a547-476b-bf1c-8fff019d8b65"), 256, "string" },
                    { new Guid("f4010a54-e895-4672-9306-e45c1272a8d2"), "Cuenta de IVA 2 Repercutido", 26, new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"), 12, "string" },
                    { new Guid("f41d24ff-b96b-406b-9fc1-cb5e8eb7397a"), "Línea de apunte", 9, new Guid("afd79133-a547-476b-bf1c-8fff019d8b65"), 1, "string" },
                    { new Guid("f5ff3240-4dc4-471e-957d-6c1c7323adcf"), "Extensión", 23, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 4, "string" },
                    { new Guid("f9d771fb-cb55-4017-a8b1-339a7b426245"), "Teléfono", 22, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 12, "string" },
                    { new Guid("fc22808f-ff74-44e9-96b9-da6e3ef4087e"), "Descripción del apunte", 10, new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"), 30, "string" },
                    { new Guid("febccc16-04c5-40cb-bbfd-0a58b8220756"), "E-mail", 25, new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"), 30, "string" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("06ffbc85-859d-4c0f-8b3f-dd4cf646a915"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("093680aa-5822-45c2-994b-9e4cf2571df7"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("0a6bef3a-74aa-48d2-ab5d-c2e3d1094f4b"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("0c63e5c8-d56f-486d-ab1a-4c253a053546"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("0c66bd42-650b-426e-b652-7f64d874d612"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("1062f629-2663-434f-8ff6-5308fd1e2a93"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("11198688-30d8-4743-bce0-0c3a36164748"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("111bc89a-feae-47c8-a2e1-d2a5a9f69abc"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("1154b4f8-a91b-42f0-8d1f-52dccd3e6cd9"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("16d1c217-0bd4-4be7-be34-1b2e38a999b0"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("1943dc4e-d469-488a-a803-3c433b2f4ec7"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("1d02a8c2-b6a6-4633-b405-902a1d256d9b"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("1d0d3356-b08e-42b9-b84c-2d7e66f4f181"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("1e05744b-77d3-4a84-8421-18a0306c49dd"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("2125d18a-9cb2-4c12-bbf9-7d24fb313d81"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("214a16b3-ac6f-4cbf-b68a-6660fc9959d2"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("226385e5-ce7f-434f-910f-063a49a2966d"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("234fe866-ab03-4062-808f-c5bc785d8a20"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("23b2ac03-5e63-4dae-8945-5033d9e648b5"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("273f5b40-9313-4fec-b6eb-55d46e6f4a15"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("27ab0b48-f3f5-4401-bc8f-bcae769c0901"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("27d00eab-d448-42ba-842c-92d0e062bfe7"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("27d58ad7-bbb5-4f8b-8417-77f857550a8c"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("2bfcbf81-a8c7-4360-9d08-6890ad885b87"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("2ce012c3-dde9-49c2-9535-113eeeec32d4"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("31c30e03-6a9c-4bda-8216-bbf46551df4a"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("36e1c68b-1120-44c7-8809-e62dc19a9e9d"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("37e94c41-4275-4423-89db-5a0e7e68cd02"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("383aec0b-86af-4df2-b68f-400661e0cfca"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("3b1b3199-e970-4cfb-a8e1-eb55de28b166"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("3dd6e9fe-b0ce-406b-8c67-1f85d2c8b737"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("3fa7dea9-3523-48a9-b9e6-dc3a379ea9ce"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("3fe5907a-79b0-49fe-b20f-7c4cad3f7ce2"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("4087f9ab-ff5f-461e-a3a3-7733bd2656a2"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("4269296d-dc98-4cfc-b2f6-eab257e045d6"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("45951ac1-e766-452d-80d3-8f645328d4a9"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("47cbcf0f-443d-4b42-9c87-aa8ef58b24ac"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("47d393f1-db68-424f-ba30-3594ea66cac4"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("4e0f481c-048c-49e7-b370-bcd1dbba2490"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("597ea89e-15fa-4d2d-ad91-2245e3c3b3aa"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("6124f8c3-b010-4c5b-aea2-8b7ee64ed808"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("61813cf5-4425-40ac-8114-f386aba4b27d"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("63929899-e3e6-45af-bf9e-3896fd0a05cf"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("65c7dbd7-28c6-4cbb-8f3c-1d6b384479b2"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("67cb94a5-9533-4515-8ebe-f3bf12c77c9a"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("68a28b6f-4268-444d-b848-4b7ca3d269b0"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("6b629ef4-565b-4130-888d-dcd787d473f6"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("6e37a529-f21a-4ccd-8aaa-aef92e028537"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("6fe8e3f1-e02d-41e6-aa0d-901834ccbd22"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("73423762-8759-40e1-bb26-efb0d64a6b3c"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("760046b5-af4f-480d-8048-d599d21dbe7f"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("77567665-6f1f-4c43-9f0f-c8219a18a20b"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("77716f25-17ae-4fb4-8f3e-54b6c5624af9"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("7985a466-15ef-406d-a5b5-ddab6c946e88"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("7ac39cc8-c92e-4830-8c11-28e6c782f2d8"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("7ceaa780-2299-4129-93c5-db2d97665acf"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("7cf3dcba-9f34-4e76-a527-3ac9fb4eebfd"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("7eca47e0-50c1-4d18-b3c2-eef4e839a910"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("7f673eb7-3ae0-43ae-9b84-5427b6e6d839"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("80f3dce8-c22f-4dc1-a06c-e265324740dd"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("81259e98-64fc-480c-98f9-0195c06da237"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("819331de-ea9b-4fb1-8dcf-1e8d37458423"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("85a7a435-9274-458c-81c4-a89cdb0d107c"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("8647a5f7-2a69-4de7-b0d9-965b4dae4fb2"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("8ad94da2-502c-457e-8d3d-0b185c8476a7"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("8af0dd84-c114-4c95-a55d-7071e15894d8"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("8b0147ff-da57-494d-93af-961e30cfc087"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("8e265aab-3db4-4ffb-a2f7-283a1565959b"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("91c985ab-96d2-463d-a093-32d7116bffba"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("921637b8-9505-495d-bfa9-cb1850d4e393"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("927eaad1-39f2-4971-81c8-32c075f7a3e4"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("9708fdfb-c217-46ee-97c4-70cdb8e5b7e1"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("9726e40f-db46-4c98-ab8d-cdcdb09aef45"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("9c06d2fb-4bf4-47c6-a883-0db5664bc63a"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("a765b7fb-1229-496e-8f55-a20d9bfe2645"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("ab78558e-5dae-4edb-ad0b-ab71ef503dde"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("ad960616-866a-44eb-9d21-4df78dfd8d84"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("b1d41dcf-444f-41eb-9032-a62ba25e02bc"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("b35195ac-5d6c-429e-819c-5a620a24e9ba"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("b4172b43-c8b1-4a9d-bef8-d3f634d958b5"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("b6e4b283-a8ff-4e3e-8b57-5697ad1dfac8"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("bb5b9d81-2c3c-4a65-a838-58616ae61212"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("bdb53b41-7a53-4cd7-82e3-a2cec8a1fae8"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("bfe95d9d-c926-49c2-9c4a-1a438093af44"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("c90b0ee6-a783-4359-aa84-cbd7340de0ec"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("cb2aa014-1ad8-4f9b-b9ad-bf1a85738f31"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("d01fa2f7-4e5c-49c6-a25f-acab62a4f27e"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("d7a09426-45e8-4c33-9251-fc5a82658a39"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("db536ac7-3aa7-47a0-bff2-3912ab11e63e"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("dc0dba32-cf83-47be-9666-25ea55bc45fd"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("dd479f65-4ce4-4420-9d55-6ad2acdb053f"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("de3f8b2e-827b-476d-b3f5-bd1584c661d5"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("dee8df34-1949-4b03-b778-15394acc3545"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("eab77874-1336-494b-a4bb-9eace0a656c6"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("ed5cbb21-9fd1-444f-bebd-652ee4b04391"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("ed81a2ae-e886-4ed5-b1b3-ad4952e1dd49"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("edf1f8e9-6c3a-4a73-bb98-9fb702d406a6"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("f4010a54-e895-4672-9306-e45c1272a8d2"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("f41d24ff-b96b-406b-9fc1-cb5e8eb7397a"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("f5ff3240-4dc4-471e-957d-6c1c7323adcf"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("f9d771fb-cb55-4017-a8b1-339a7b426245"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("fc22808f-ff74-44e9-96b9-da6e3ef4087e"));

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: new Guid("febccc16-04c5-40cb-bbfd-0a58b8220756"));

            migrationBuilder.DeleteData(
                table: "RecordTypes",
                keyColumn: "Id",
                keyValue: new Guid("333bac9c-af5b-44d0-9678-7f54bf78eeb9"));

            migrationBuilder.DeleteData(
                table: "RecordTypes",
                keyColumn: "Id",
                keyValue: new Guid("821719bb-85c9-4d2b-91a8-aa9be9aad582"));

            migrationBuilder.DeleteData(
                table: "RecordTypes",
                keyColumn: "Id",
                keyValue: new Guid("afd79133-a547-476b-bf1c-8fff019d8b65"));

            migrationBuilder.DeleteData(
                table: "RecordTypes",
                keyColumn: "Id",
                keyValue: new Guid("f4dc644c-681a-4ff2-900a-4c0c033b8030"));

            migrationBuilder.DropColumn(
                name: "Head",
                table: "Templates");
        }
    }
}
