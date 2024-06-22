﻿using Acceso_Datos;
using Entidades;


namespace Logica_Negocio
{
    public class ReportesBL
    {
        // Objeto De La DB:
        private readonly ReportesDAL _ReportesDAL;

        // Constructor:
        public ReportesBL(ReportesDAL reportesDAL)
        {
            _ReportesDAL = reportesDAL;
        }



        // ******* METODOS QUE MANDARAN OBJETOS A LAS VISTAS ********
        // **********************************************************

        // Lista De La Tabla Empleados Para ViewData:
        public async Task<List<Empleado>> Lista_Empleados()
        {
            return await _ReportesDAL.Lista_Empleados();
        }


        // Encuentra y Manda Los Objetos Con Ese Id:
        public async Task<List<Factura>> Obtener_Facturas_Registradas()
        {
            return await _ReportesDAL.Obtener_Facturas_Registradas();
        }
    }
}
