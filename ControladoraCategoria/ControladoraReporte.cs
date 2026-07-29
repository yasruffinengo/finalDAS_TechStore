using Entidades.Dtos;
using Entidades.DTOs;
using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraReporte
    {
        private RepositorioReporte repositorio = new RepositorioReporte();

        private static ControladoraReporte instancia;

        private ControladoraReporte()
        {

        }
        public static ControladoraReporte Instancia
        {
            get
            {
                //si no esta creada la creo
                if (instancia == null)
                {
                    instancia = new ControladoraReporte();
                }
                //si ya existe, devuelve esa
                return instancia;
            }
        }
        public List<ReporteVentaDTO> ReporteObtenerVentas(DateTime fechaDesde, DateTime fechaHasta, int? productoId, int? sucursalId, int? vendedorId)
        {
            try
            {
                if (fechaDesde > fechaHasta)
                {
                    throw new ArgumentException("La fecha desde no puede ser mayor que la fecha hasta.");
                }
                if (fechaDesde == null || fechaHasta == null)
                {
                    throw new ArgumentNullException("Las fechas no pueden ser nulas.");
                }
                if (fechaDesde > DateTime.Now || fechaHasta > DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException("Las fechas no pueden ser mayores a la fecha actual.");
                }

                return repositorio.ReporteObtenerVentas(fechaDesde, fechaHasta, productoId, sucursalId, vendedorId).ToList();
             
            }
            catch (Exception ex)
            {
                throw new Exception("error al obtener ventas con filtros" + ex.Message);
            }
        }


        public List<ProductoMasVendidoDTO> ObtenerProductosMasVendidos(DateTime fechaDesde, DateTime fechaHasta, int? sucursalId)
        {

            try
            {
                //validaciones de fechas
                if (fechaDesde > fechaHasta)
                {
                    throw new ArgumentException("La fecha desde no puede ser mayor que la fecha hasta.");
                }
                if (fechaDesde == null || fechaHasta == null)
                {
                    throw new ArgumentNullException("Las fechas no pueden ser nulas.");
                }
                if (fechaDesde > DateTime.Now || fechaHasta > DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException("Las fechas no pueden ser mayores a la fecha actual.");
                }
                return repositorio.ObtenerProductosMasVendidos(fechaDesde, fechaHasta, sucursalId).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("error al listar productos mas vendidos" + ex.Message);
            }
        }

        public List<EstadoCuentaClienteDTO> ObtenerEstadoCuentasCorrientes(
            int? clienteId)
        {
            try
            {
                if (clienteId.HasValue && clienteId.Value <= 0)
                    throw new ArgumentException("El cliente seleccionado no es válido.");

                return repositorio.ObtenerEstadoCuentasCorrientes(clienteId);
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al obtener estados de cuenta corriente: " + ex.Message
                );
            }
        }

        public List<DetalleCuentaCorrienteDTO> ObtenerDetalleCuentaCorriente(
            int clienteId)
        {
            try
            {
                if (clienteId <= 0)
                    throw new ArgumentException("El cliente seleccionado no es válido.");

                return repositorio.ObtenerDetalleCuentaCorriente(clienteId);
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al obtener el detalle de cuenta corriente: " + ex.Message
                );
            }
        }
    }

}

