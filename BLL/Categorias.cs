﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Categorias : ClaseMaestra

    {
        ConexionDb conexion = new ConexionDb();

        public int CategoriaId { get; set; }
        public string Descripcion { get; set; }

        public Categorias(int Id, string DescripcionCategoria)
        {
            this.CategoriaId = Id;
            this.Descripcion = DescripcionCategoria;
        }

        public Categorias()
        {
            this.CategoriaId = 0;
            this.Descripcion = "";
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                if (conexion.Ejecutar(string.Format("Insert Into Categorias(Descripcion) values('{0}')", this.Descripcion)))
                {
                    retorno = true;
                }
                
                
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return retorno;

        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                
                retorno = conexion.Ejecutar(String.Format(" Update Categorias set Descripcion = '{0}' where CategoriaId = {1} ",  this.Descripcion, this.CategoriaId));
               
            }
            catch (Exception exc)
            {
                throw exc;
            }
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            try
            {
                
                retorno = conexion.Ejecutar(String.Format(" delete from Categorias where CategoriaId = {0}  ", this.CategoriaId));
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable datatable = new DataTable();
            try
            {
                datatable = conexion.ObtenerDatos(string.Format("select * from Categorias where CategoriaId=" + IdBuscado));
                if (datatable.Rows.Count > 0)
                {
                    this.CategoriaId = (int)datatable.Rows[0]["CategoriaId"];
                    this.Descripcion = datatable.Rows[0]["Descripcion"].ToString();
                }

            }
            catch (Exception exc)
            {

                throw exc;
            }
            return datatable.Rows.Count > 0;

        }
        public  bool BuscarDescripcion(string DescripcionBuscada)
        {
            DataTable datatable = new DataTable();
            try
            {
                datatable = conexion.ObtenerDatos(string.Format("select * from Categorias where Descripcion= '" + DescripcionBuscada+"'"));
                if (datatable.Rows.Count > 0)
                {
                    this.CategoriaId = (int)datatable.Rows[0]["CategoriaId"];
                    this.Descripcion = datatable.Rows[0]["Descripcion"].ToString();
                }

            }
            catch (Exception exc)
            {

                throw exc;
            }
            return datatable.Rows.Count > 0;

        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {

            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " Orden by  " + Orden;

            return conexion.ObtenerDatos("Select " + Campos + " From Categorias Where " + Condicion + Orden);
        }
    }
}

