﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto_V.Models;

namespace Proyecto_V.Clases
{
    public class Cls_Jugador:Cls_Equipo
    {
        //INSTANCIA DE CLASE
        #region INSTANCIA
        programacion5Entities ModeloDB = new programacion5Entities();
        #endregion

        //ATRIBUTOS DE CLASE
        #region ATRIBUTOS DE CLASE
        public int idConsecutivo_jugador { get; set; }
        public string NumeroCedula { get; set; }
        public string Genero { get; set; }
        public string FechaNacimiento { get; set; }
        public string NumeroTelefono { get; set; }
        public string Correo { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string DireccionCasa { get; set; }
        public string Activo { get; set; }

        static List<Cls_Jugador> datos_jugador = new List<Cls_Jugador>();
        #endregion

        //CONSTRUCTORES DE CLASE
        #region CONSTRUCTORES DE CLASE
        public Cls_Jugador()
        {

        }
        public Cls_Jugador(int id_provincia, int id_canton,int id_distrito):base(id_provincia, id_canton,id_distrito)
        {

        }
        #endregion

        //METODOS
        #region METODOS DE LA CLASES
        //METODO QUE HACE EL INSERT DE LOS JUGADORES
        public int pc_registrar_jugador()
        {
            int filas = 0;
            try
            {
                filas = this.ModeloDB.SP_REGISTRAR_JUGADOR(NumeroCedula,Genero,Convert.ToDateTime(FechaNacimiento), Nombre, Apellido1, Apellido2, NumeroTelefono,
                    Correo, IdProvincia, IdCanton, IdDistrito, DireccionCasa);
            }
            catch (Exception)
            {

                filas = -100;
            }
            return filas;
        }

        ////METODO CONSULTA LOS JUGADORES
        public List<SP_CONSULTAR_LISTA_JUGADORES_Result> pc_consultar_jugadores()
        {
            List<SP_CONSULTAR_LISTA_JUGADORES_Result> lista_jugadores = this.ModeloDB.SP_CONSULTAR_LISTA_JUGADORES().ToList();
            return lista_jugadores;
        }

        ////METODO CONSULTA LOS JUGADORES
        public List<SP_CONSULTAR_LISTA_JUGADORES_ACTIVOS_Result> pc_consultar_jugadores_activos()
        {
            List<SP_CONSULTAR_LISTA_JUGADORES_ACTIVOS_Result> lista_jugadores = this.ModeloDB.SP_CONSULTAR_LISTA_JUGADORES_ACTIVOS().ToList();
            return lista_jugadores;
        }

        //METODO PARA ELIMINAR UN JUGADOR
        public int pc_eliminar_jugador()
        {
            int filas = 0;
            try
            {
                filas = this.ModeloDB.SP_ELIMINAR_JUGADOR(NumeroCedula);
            }
            catch (Exception)
            {

            }

            return filas;
        }

        //METODO QUE CAPUTA LOS DATOS DEL JUGADOR
        //PARA ACTUALZIARLO
        public void pc_captura_datos()
        {
            pc_limpiar_datos_jugador();
            //CAPTURAMOS LOS DATOS DEL JUGADOR
            Cls_Jugador datos = new Cls_Jugador();
            datos.NumeroCedula = this.NumeroCedula;
            datos.Nombre = this.Nombre;
            datos.Apellido1 = this.Apellido1;
            datos.Apellido2 = this.Apellido2;
            datos.NumeroTelefono = this.NumeroTelefono;
            datos.Correo = this.Correo;
            datos.DireccionCasa = this.DireccionCasa;
            //AGREGAMOS LOS DATOS A UNA LISTA STATICA PARA RETORNALOS
            datos_jugador.Add(datos);
        }

        //METODO QUE ME RETORNA LA LISTA CON LOS DATOS DEL JUGADOR A ACTUALIZAR
        public List<Cls_Jugador> pc_retornar_lista_jugador()
        {
            return datos_jugador;
        }
        //METDO PARA LIMPIAR LA TABLA
        public void pc_limpiar_datos_jugador()
        {
            datos_jugador.Clear();
        }

        //METODO PARA ACTUALZIAR EL JUGADOR
        public int pc_actualizar_jugador()
        {
            int filas = 0;
            try
            {
                filas = this.ModeloDB.SP_ACTUALIZAR_JUGADOR(this.NumeroCedula, this.Nombre, this.Apellido1, this.Apellido2, this.NumeroTelefono,
                    this.Correo, this.DireccionCasa);
            }
            catch (Exception)
            {

                throw;
            }

            return filas;
        }

        //METODO REGISTRA JUGADORES POR EQUIPO

        public int pc_jug_x_equipo(List<Cls_Jugador> datos)
        {
            int filas = 0;
            foreach (var item in datos)
            {
                filas = this.ModeloDB.SP_AGREGAR_JUGADOR_X_EQUIPO(item.NumeroCedula,item.idConsecutivo);
            }
            return filas;
        }
        #endregion
    }
}