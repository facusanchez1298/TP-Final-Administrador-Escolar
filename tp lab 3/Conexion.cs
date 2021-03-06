﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_lab_3
{
    public class Conexion
    {
        /// orden
        /// alu_asig
        /// prof_asig
        /// curso_asig
        /// examenes
        /// recuperatorio
        /// correlatividad
        /// profesor
        /// asignatura
        /// aula
        /// alumno
        /// curso

        #region tablas

        string crearTablaAlu_Asig = "create table if not exists alumno_asignatura(" +
                                            "dni_alumno int not null," +
                                            "id_asignatura int not null," +
                                            "aprobada boolean defaul false," +
                                            "cursando boolean defaul true," +
                                            "primary key(dni_alumno, id_asignatura)," +
                                            "FOREIGN KEY(dni_alumno) REFERENCES Alumno(dni_alumno)," +
                                            "FOREIGN KEY(id_asignatura) REFERENCES Asignatura(id_asignatura));";

       

        string creatTablaProf_Asig = "create table if not exists Profesor_Asignatura(" +
                                            "dni_profesor int not null," +
                                            "id_asignatura int not null," +
                                            "primary key(dni_profesor, id_asignatura)," +
                                            "FOREIGN KEY(dni_profesor) REFERENCES Profesor(dni)," +
                                            "FOREIGN KEY(id_asignatura) REFERENCES Asignatura(id_asignatura));";

       

        string crearTablaCurso_Asig = "create table if not exists Curso_Asignatura(" +
                                            "año varchar not null," +
                                            "division varchar not null," +
                                            "id_asignatura int not null," +
                                            "primary key(año, division, id_asignatura)," +
                                            "FOREIGN KEY(año) REFERENCES Curso(año)," +
                                            "FOREIGN KEY(division) REFERENCES Curso(division)," +
                                            "FOREIGN KEY(id_asignatura) REFERENCES Asignatura(id_asignatura));";


        string crearTablaExamenes = "create table if not exists Examen(" +
                                            "id_asignatura int not null," +
                                            "dni_Alumno int not null," +
                                            "primerParcial int default null," +
                                            "segundoParcial int default null," +
                                            "tercerParcial int default null," +
                                            "primerRecuperatorio int default null," +
                                            "segundoRecuperatorio int default null," +
                                            "primary key(id_asignatura, dni_Alumno));";

        string crearTablaCorrelatividad = "create table if not exists Correlatividad(" +
                                            "regular int," +
                                            "aprobada int," +
                                            "para_cursar int);";

        string crearTablaProfesor = "create table if not exists Profesor(" +
                                            "dni int primary key not null," +
                                            "Nombre varchar not null," +
                                            "apellido varchar," +
                                            "direccion varchar," +
                                            "telefono varchar," +
                                            "delCentro boolean);";

        string crearTablaAsignatura = "create table if not exists asignatura(" +
                                            "id_asignatura int primary key," +
                                            "nombre varchar not null);";


        string crearTablaAula = "create table if not exists aula(" +
                                            "numero int PRIMARY KEY," +
                                            "capacidad int not null," +
                                            "internet boolean not null," +
                                            "proyector boolean not null);";

        string crearTablaAlumno = "create table if not exists alumno(" +
                                            "dni int primary key," +
                                            "matricula int," +
                                            "nombre varchar not null," +
                                            "apellido varchar not null," +
                                            "direccion varchar," +
                                            "telefono varchar," +
                                            "año varchar," +
                                            "division varchar," +
                                            "foreign key(division) references Curso(division)," +
                                            "FOREIGN KEY(año) REFERENCES Curso(año));";

        string crearTablaCurso = "create table if not exists Curso(" +
                                            "año varchar," +
                                            "division varchar," +
                                            "aulas int," +
                                            "primary key(año, division));";

        /// <summary>
        /// los tipos que deberian ir son alumno, profesor o bedel
        /// </summary>
        string crearTablaUsuario = "create table if not exists usuario(" +
                                            "usuario int," +
                                            "contraseña varchar not null," +
                                            "tipo varchar not null," +
                                            "primary key(usuario, tipo));"; 
        #endregion



        //
        //
        //
        //      atributos de la clase
        //
        //
        //
        /// <summary>
        /// el objeto que se encarga de manejar la conexion con la base de datos
        /// </summary>
        SQLiteConnection connection;

        /// <summary>
        /// el objeto que se encarga de ejecutar los comandos que le pasemos
        /// </summary>
        SQLiteCommand command;

        /// <summary>
        /// lo utilizamos para adapatar contenido a la tabla
        /// </summary>
        SQLiteDataAdapter dataAdapter;

        DataSet dataSet;
        //
        //
        //
        //      conexion, desconexion y creacion de la base de datos
        //
        //
        //
        /// <summary>
        /// conectamos al objeto connection, ahora ya estamos conectados a la base de datos
        /// </summary>
        public void conectar()
        {

            try
            {
                this.connection = new SQLiteConnection("Data Source = datos.grupoDeTrabajo");
                this.connection.Open();
                this.connection.DefaultTimeout = 1;
                dataSet = new DataSet();
            }
            catch (Exception ex)
            {
                throw new Exception("no pudo realizarse la conexion" + ex);
            }
        }

        /// <summary>
        /// desconectamos al objeto connection, cerramos comunicacion con la base de datos
        /// </summary>
        public void desconectar()
        {
            try
            {
                this.connection.Close();
            }
            catch (Exception)
            {
                throw new Exception("no puso realizarse la desconexion");
            }
        }

        /// <summary>
        /// crea el archivo que va a ser la base de datos y todas las tablas
        /// </summary>
        /// <param name="nombre">nombre del archico. por defecto esta datos.grupoDeTrabajo</param>
        public void crearBaseDeDatos(string nombre = "datos.grupoDeTrabajo")
        {
            if (!File.Exists(nombre))
            {
                SQLiteConnection.CreateFile("datos.grupoDeTrabajo");
            }

            try
            {

                //abrimos coneccion
                conectar();

                //preparamos un objeto que va a ejecutar todo el comando
                command = new SQLiteCommand(crearTablaAlu_Asig + crearTablaCurso_Asig + creatTablaProf_Asig + crearTablaProfesor + crearTablaAula + crearTablaAlumno
                   + crearTablaCurso + crearTablaExamenes + crearTablaCorrelatividad + crearTablaAsignatura + crearTablaUsuario, this.connection);

                //ejecutamos el comando
                command.ExecuteNonQuery();

                //desconectamos el objeto
                command.Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                //cerramos la coneccion
                desconectar();
            }

        }

        /// <summary>
        /// borra la base de datos anterior y la reinstala
        /// </summary>
        /// <param name="nombre">nombre de la base de datos</param>
        public void reinstalarBaseDeDatos(string nombre = "datos.grupoDeTrabajo")
        {
            try
            {
                if (!File.Exists(nombre))
                {
                    File.Delete("datos.grupoDeTrabajo");
                }
                crearBaseDeDatos(nombre);
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
        }
        //
        //
        //
        //      registro e inicio de sesion 
        //
        //
        //
        /// <summary>
        /// crea un usuario
        /// </summary>
        /// <param name="usuario">nombre de usuario</param>
        /// <param name="contraseña">contraseña</param>
        /// <param name="tipo">alumno, profesor o bedel</param>
        public void crearUsuario(int usuario, string contraseña, string tipo)
        {
            try
            {
                conectar();
                string sql = "insert into usuario(usuario, contraseña, tipo) values (" + usuario + ",'" + contraseña + "','" + tipo + "');";
                command = new SQLiteCommand(sql, connection);

                command.ExecuteNonQuery();
                command.Connection.Close();

            }
            catch (Exception )
            {

                mostrarMensaje("el usuario: " + usuario + " ya existe, intente con otro");
            }
            finally
            {
                desconectar();
            }
        }

        public bool iniciarSesion(int usuario, string contraseña, string tipo)
        {
            bool existe = false;
            try
            {
                conectar();
                string sql = "select * from Usuario where usuario = " + usuario + " and contraseña = '" + contraseña + "' and tipo = '" + tipo + "'";
                command = new SQLiteCommand(sql, connection);

                SQLiteDataReader lector = command.ExecuteReader();



                if (lector.Read())
                {

                    existe = true;
                }

                lector.Close();
                command.Connection.Close();
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
            return existe;
        }

        public void borrarUsuario(int usuario, string contraseña, string tipo)
        {
            try
            {
                conectar();
                string sql = "delete from usuario where usuario = " + usuario + " and contraseña = " + contraseña + " and tipo = " + tipo;

                command = new SQLiteCommand(sql, connection);

                command.ExecuteNonQuery();
                command.Connection.Close();
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        public void cambiarContraseña(string usuario, string vieja, string nueva)
        {
            try
            {
                conectar();
                string sql = "update usuario" +
                             " set contraseña = '" + nueva + "'" +
                             " where usuario = '" + usuario +
                             "' and contraseña = '" + vieja + "'";

                command = new SQLiteCommand(sql, connection);

                command.ExecuteNonQuery();
                command.Connection.Close();
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }
        //
        //
        //
        //      eliminar elementos
        //
        //
        //
        public void removerAlumno_asignatura(int dni, int id_asignatura)
        {
            try
            {
                conectar();
                string sql =    "delete from alumno_asignatura " +
                                "where id_asignatura =" + id_asignatura +
                                " and dni_alumno = " + dni;
                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();

               
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        public void removerProfesor(int dni)
        {
            try
            {
                conectar();
                string sql = "delete from profesor " +
                             "where dni = " + dni;

                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        public void removerAlumno(int dni)
        {
            try
            {
                conectar();
                string sql = "delete from alumno " +
                             "where dni = " + dni;

                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        public void removerCurso(string año, string division)
        {
            try
            {
                conectar();
                string sql = "delete from curso " +
                             "where año = " + año +
                             " and division = '" + division + "'";


                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        public void removerAula(int numero)
        {
            try
            {
                conectar();
                string sql = "delete from aula " +
                             "where numero = " + numero;


                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        public void removerAsignatura(int id_asignatura)
        {
            try
            {
                conectar();
                string sql = "delete from asignatura " +
                             "where id_asignatura = " + id_asignatura;


                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        public void removerCurso_asignatura(string año, string division, int id_asignatura)
        {
            try
            {
                conectar();
                string sql = "delete from curso_asignatura" +
                             " where id_asignatura = " + id_asignatura +
                             " and curso_asignatura.año = " + año +
                             " and curso_asignatura.division = '" + division + "'";


                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        public void removerExamenes(int dni, int id_asignatura)
        {
            try
            {
                conectar();
                string sql = "delete from examen" +
                             " where id_asignatura = " + id_asignatura +
                             " and dni_alumno = "+ dni;


                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }
        //
        //
        //
        //      elementos de guardado
        //
        //
        //
        #region elementos de guardado

        /// <summary>
        /// guarda un registro en la tabla asignatura_alumno y un examen para el alumno en esa materia
        /// </summary>
        /// <param name="alumno"></param>
        /// <param name="asignatura"></param>
        public void guardarAlu_Asig(Alumno alumno, Asignatura asignatura)
        {
            try
            {
                conectar();
                string sql = "insert into alumno_asignatura(dni_alumnos, id_asignatura) values (" + alumno.dni + "," + asignatura.id + ");" +
                    "insert into Examenes(dni_alumno, id_asignatura) values (" + alumno.dni + "," + asignatura.id + ")";
                command = new SQLiteCommand(sql, this.connection);


                command.ExecuteNonQuery();
                command.Connection.Close();



            }
            catch (Exception e)
            {

                throw new Exception("Error guardando el registro: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// guarda un registro en la tabla asignatura_alumno
        /// </summary>
        /// <param name="dni">dni del alumno</param>
        /// <param name="id">id de la materia</param>
        public void guardarAlu_Asig(int dni, int id)
        {
            try
            {
                conectar();
                string sql = "insert into alumno_asignatura(dni_alumno, id_asignatura, aprobada, cursando) values (" + dni + "," + id + ",'false', 'true')";
                command = new SQLiteCommand(sql, this.connection);

                
                command.ExecuteNonQuery();
                command.Connection.Close();
             
            }
            catch (SQLiteException e)
            {
                mostrarMensaje("Error guardando el registro: " + e.Message);
            }
            finally
            {
                desconectar();
            }
        }

        public void guardarExamen(int dni, int id_asignatura)
        {
            try
            {
                conectar();
                string sql = "insert into Examen(dni_alumno, id_asignatura) " +
                             "values (" + dni + "," + id_asignatura + ")";
                command = new SQLiteCommand(sql, this.connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
            catch (SQLiteException e)
            {
                mostrarMensaje("Error guardando el registro: " + e.Message);
            }
            finally
            {
                desconectar();
            }
        }

        public void guardarNotaExamen(int dni, string parcial, int id_asignatura, int nota )
        {
            try
            {
                conectar();
                string sql = " update Examen set " + parcial + " = " + nota +
                             " where examen.dni_alumno = " + dni +
                             " and examen.id_asignatura = " + id_asignatura;

                //agregar un examen, como se para que materia es la nota?????


                command = new SQLiteCommand(sql, this.connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
            catch (SQLiteException e)
            {
                mostrarMensaje("Error guardando el registro: " + e.Message);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// guarda un registro en la tabla profesor_asignatura
        /// </summary>
        /// <param name="id_asignatura">id de la asignatura que vamos a guardar</param>
        /// <param name="profesores">lista de profesores que van a dar esa clase</param>
        public void guardarProf_Asig(int id_asignatura, List<Profesor> profesores)
        {
            try
            {
                conectar();

                for (int i = 0; i < profesores.Count; i++)
                {
                    string sql = "insert into Profesor_Asignatura(id_asignatura, dni_profesor) values (" + id_asignatura + "," + profesores.ElementAt(i).dni + ") ";
                    command = new SQLiteCommand(sql, connection);

                    command.ExecuteNonQuery();
                }

                command.Connection.Close();
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// guarda un registro en la tabla profesor asignatura
        /// </summary>
        /// <param name="id_asignatura"></param>
        /// <param name="profesor"></param>
        public void guardarProfesor_asignatura(int id_asignatura, int dni_profesor)
        {
            try
            {
                conectar();

                string sql = "insert into Profesor_Asignatura(id_asignatura, dni_profesor) values (" + id_asignatura + "," + dni_profesor + ") ";
                command = new SQLiteCommand(sql, connection);

                command.ExecuteNonQuery();


                command.Connection.Close();
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// guarda un registro en la tabla curso asignatura
        /// </summary>
        /// <param name="año"> año del curso </param>
        /// <param name="division"> division del curso </param>
        /// <param name="id_asignatura"> numero identificador de la asignatura</param>
        public void guardarCurso_asig(string año, string division, int id_asignatura)
        {
            try
            {
                conectar();
                string sql = "insert into Curso_Asignatura values ('" + año + "','" + division + "', " + id_asignatura + ")";

                command = new SQLiteCommand(sql, connection);

                command.ExecuteNonQuery();

                command.Connection.Close();

            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }

        }

        /// <summary>
        /// guarda notas del examen 
        /// </summary>
        /// <param name="examen">examen que vamos a guardar</param>
        public void guardarExamen(Examen examen)
        {
            try
            {
                conectar();
                string sql = "insert into examen(primerParcial, segundoParcial, tercerParcial, primerRecuperatorio, segundoRecuperatorio) values" +
                    "(" + examen.primerParcial + "," + examen.segundoParcial + "," + examen.tercerParcial + ","
                    + examen.primerRecuperatorio + "," + examen.segundoRecuperatorio + ")";
                command = new SQLiteCommand(sql, connection);

                command.ExecuteNonQuery();
                command.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                desconectar();
            }

        }

        /// <summary>
        /// guarda en la tabla correlatividad las correlativas de una asignatura
        /// </summary>
        /// <param name="id">id de la asignatura</param>
        /// <param name="correlativas">correlativas de la asignatura</param>
        public void guardarCorrelativas(int id, Correlativas correlativas)
        {
            try
            {
                conectar();
                string sql = "";
                int count = correlativas.aprobadas.Count > correlativas.regulares.Count ? correlativas.aprobadas.Count : correlativas.regulares.Count;

                for (int i = 0; i < count; i++)
                {
                    int id_regular = correlativas.regulares.ElementAt(i) == null ? -1 : correlativas.regulares.ElementAt(i).id;
                    int id_aprobada = correlativas.aprobadas.ElementAt(i) == null ? -1 : correlativas.aprobadas.ElementAt(i).id;

                    if ((id_aprobada != -1) && (id_regular != -1))
                    {
                        sql = "insert into corrilatividad(regular, aprobada, para_cursar) values " +
                                                    "(" + id_regular + ", " + id_aprobada + "," + id + ");";
                    }
                    else if (id_aprobada == -1)
                    {
                        sql = "insert into corrilatividad(regular, para_cursar) values (" + id_regular + ", " + id + ");";
                    }
                    else
                    {
                        sql = "insert into corrilatividad( aprobada, para_cursar) values (" + id_aprobada + "," + id + ");";
                    }

                    //ejecutamos el guardado
                    command = new SQLiteCommand(sql, connection);
                    command.ExecuteNonQuery();
                }

                command.Connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// guarda un registro en la tabla profesores
        /// </summary>
        /// <param name="profesores">Lista de profesores que vamos a guardar</param>
        private void guardarProfesores(List<Profesor> profesores)
        {
            try
            {
                conectar();

                for (int i = 0; i < profesores.Count; i++)
                {
                    Profesor profesor = profesores.ElementAt(i);

                    string sql = "insert into Profesor(dni, nombre, apellido, direccion, telefono, delCentro) values" +
                        " (" + profesor.dni + ",'" + profesor.nombre + "','" + profesor.apellido + "','" + profesor.direccion + "'," + profesor.telefono + ",'" + profesor.delCentro + "');";

                    command = new SQLiteCommand(sql, connection);
                    command.ExecuteNonQuery();
                }

                command.Connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// guarda un registro en la tabla asignatura
        /// </summary>
        /// <param name="id">id identificador de la asignatura</param>
        /// <param name="nombre">nombre de la asignatura</param>
        /// <param name="correlativas">correlativas que pueda tener la asignatura</param>
        /// <param name="profesor">profesores de la asignatura</param>
        public void guardarAsignatura(int id, string nombre, Correlativas correlativas, List<Profesor> profesor)
        {
            try
            {
                conectar();
                string sql = "insert into asignatura(id_asignatura, nombre) values (" + id + "," + nombre + ");";
                command = new SQLiteCommand(sql, connection);//le pasamos la consulta que vamos a realizar

                command.ExecuteNonQuery(); //ejecutamos la consulta
                command.Connection.Clone(); //cerramos la conexion

                guardarCorrelativas(id, correlativas);
                guardarProf_Asig(id, profesor);

            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// guarda un registro en la tabla asignatura
        /// </summary>
        /// <param name="id">id identificador de la asignatura</param>
        /// <param name="nombre">nombre de la asignatura</param>        
        /// <param name="profesor">profesores de la asignatura</param>
        public void guardarAsignatura(int id, string nombre, List<Profesor> profesor)
        {
            try
            {
                conectar();
                string sql = "insert into asignatura(id_asignatura, nombre) values (" + id + "," + nombre + ");";
                command = new SQLiteCommand(sql, connection);//le pasamos la consulta que vamos a realizar

                command.ExecuteNonQuery(); //ejecutamos la consulta
                command.Connection.Clone(); //cerramos la conexion

                guardarProfesores(profesor);

            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
            //                                "regular int," +
            //                                "aprobada int," +
            //                                "para_cursar int);";


            //"id_asignatura int primary key," +
            //"nombre varchar,"


        }

        /// <summary>
        /// guarda un registro en la tabla asignatura
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="profesor"></param>
        public void guardarAsignatura(int id, string nombre, int dni_Profesor)
        {
            try
            {
                conectar();
                string sql = "insert into asignatura(id_asignatura, nombre) values (" + id + ",'" + nombre + "');";
                command = new SQLiteCommand(sql, connection);//le pasamos la consulta que vamos a realizar

                command.ExecuteNonQuery(); //ejecutamos la consulta
                command.Connection.Clone(); //cerramos la conexion

                guardarProfesor_asignatura(id, dni_Profesor);

            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
            //                                "regular int," +
            //                                "aprobada int," +
            //                                "para_cursar int);";


            //"id_asignatura int primary key," +
            //"nombre varchar,"


        }

        /// <summary>
        /// guarda un registro en la tabla aula
        /// </summary>
        /// <param name="numero">numero del aula</param>
        /// <param name="capacidad">capacidad del aula</param>
        /// <param name="tieneInternet">true si tiene internet, false en caso contrario</param>
        /// <param name="tieneProyector">true si tiene proyector, false en caso contrario</param>
        public void guardarAula(int numero, int capacidad, bool tieneInternet, bool tieneProyector)
        {
            try
            {
                conectar();
                string sql = "insert into aula values (" + numero + "," + capacidad + ",'" + tieneInternet + "','" + tieneProyector + "')";
                command = new SQLiteCommand(sql, connection);

                command.ExecuteNonQuery();

                command.Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }

        }

        /// <summary>
        /// guarda un registro en la tabla alumno
        /// </summary>
        /// <param name="alumno"></param>
        public void guardarAlumno(Alumno alumno)
        {
            try
            {
                conectar();
                string sql = "insert into alumno(dni, matricula, nombre, apellido, direccion, telefono, año, division) values " +
                        "(" + alumno.dni + "," + alumno.matricula + ",'" + alumno.nombre + "','" + alumno.apellido + "','" + alumno.direccion +
                        "'," + alumno.telefono + ",'" + alumno.año + "', '" + alumno.division + "')";



                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// guarda un profesor en la tabla profesor
        /// </summary>
        /// <param name="profesor"></param>
        public void guardarProfesor(Profesor profesor)
        {
            try
            {

                conectar();
                string sql = "insert into Profesor(dni, nombre, apellido, direccion, telefono, delCentro) values " +
                        "(" + profesor.dni + ",'" + profesor.nombre + "','" + profesor.apellido + "','" + profesor.direccion +
                        "'," + profesor.telefono + ",'" + profesor.delCentro + "')";




                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// guarda un curso en la tabla curso
        /// </summary>
        /// <param name="año"></param>
        /// <param name="division"></param>
        /// <param name="aula"></param>
        public void guardarCurso(string año, string division, int aula)
        {
            try
            {

                conectar();
                string sql = "insert into curso values ('" + año + "','" + division + "'," + aula + " );";

                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }
        #endregion
        //
        //
        //
        //      cargar elementos
        //
        //
        //
        /// <summary>
        /// carga todos los cursos guardados
        /// </summary>
        /// <param name="cursos"></param>
        public void cargarCursos(List<Curso> cursos)
        {
            try
            {

                conectar();
                string sql = "select * from curso";
                command = new SQLiteCommand(sql, connection);

                SQLiteDataReader lector = command.ExecuteReader();

                while (lector.NextResult())
                {

                    int año = int.Parse(lector.GetString(0));
                    string division = lector.GetString(1);
                    Aula aula = buscarAula(lector.GetInt32(2));

                    Curso curso = new Curso(año, char.Parse(division), aula);

                    curso.agregarAlumnos(buscarAlumnos("where año = " + año + "and division = " + division));
                    curso.agregarAsignaturas(buscarAsignatura_curso(año.ToString(), division));

                }

            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
        }
        //
        //
        //
        //      Editar elementos
        //
        //
        //
        public void editarAula(int numero, int capacidad, bool internet, bool proyector)
        {
            try
            {
                conectar();
                string sql = " update  aula set capacidad = "+ capacidad+ ", internet = " + internet +
                             ", proyector = " + proyector +
                             " where numero = " + numero;

                command = new SQLiteCommand(sql, this.connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
            catch (SQLiteException e)
            {
                mostrarMensaje("Error guardando el registro: " + e.Message);
            }
            finally
            {
                desconectar();
            }
        }

        public void editarCurso(string año, string division, string aula)
        {
            try
            {
                conectar();
                string sql = " update curso set aulas = " + aula +
                             " where año = '" + año + "' and division = '" + division + "'";

                command = new SQLiteCommand(sql, this.connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
            catch (SQLiteException e)
            {
                mostrarMensaje("Error guardando el registro: " + e.Message);
            }
            finally
            {
                desconectar();
            }
        }

        public void editarMateria(string id_asignatura, string materia, string profesor)
        {
            try
            {
                conectar();
                string sql = "update asignatura " +
                             "set nombre = '" + materia +
                             "' where asignatura.id_asignatura = " + id_asignatura + ";" +
                             " update profesor_asignatura " +
                             " set dni_profesor = " + profesor + 
                             " where id_asignatura = " + id_asignatura + ";";

                command = new SQLiteCommand(sql, this.connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
            catch (SQLiteException e)
            {
                mostrarMensaje("Error guardando el registro: " + e.Message);
            }
            finally
            {
                desconectar();
            }
        }

        //
        //
        //
        //       elementos de busqueda
        //
        //
        //
        #region elementos de busqueda

        /// <summary>
        /// devuelve una lista de asignaturas que cumplan con el requisito que le pasas
        /// </summary>
        /// <param name="requisitos">requisito que debe cumplor la asignatura ej 'where id_asignatura = 12
        /// en caso de no pasar requisitos trae todas las asignaturas cargadas</param>
        /// <returns></returns>
        private List<Asignatura> buscarAsignatura(string requisitos = "")
        {
            try
            {

                List<Asignatura> asignaturas = new List<Asignatura>();
                conectar();
                string sql = "select * from asignatura " + requisitos;
                command = new SQLiteCommand(sql, connection);

                try
                {
                    SQLiteDataReader lector = command.ExecuteReader();

                    while (lector.NextResult())
                    {
                        int id = lector.GetInt32(0);
                        string nombre = lector.GetString(1);
                        List<Examen> examenes = buscarExamenes(id);
                        Correlativas correlativas = buscarCorrelativas(id);
                        List<Profesor> profesores = buscarProfesores(id);

                        Asignatura asignatura = new Asignatura(id, nombre, correlativas, profesores);
                        asignatura.agregarExamenes(examenes);

                        asignaturas.Add(asignatura);
                    }

                    lector.Close();
                    command.Connection.Close();

                    return asignaturas;
                }
                catch (Exception e)
                {

                    throw new Exception("Error: " + e);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
        }

        /// <summary>
        /// busca todas las asignaturas que correspondan a este curso
        /// </summary>
        /// <param name="año_Division">el curso que queremos buscar</param>
        /// <returns></returns>
        private List<Asignatura> buscarAsignatura_curso(string año, string division)
        {
            try
            {

                List<Asignatura> asignaturas = new List<Asignatura>();
                conectar();
                string sql = "select asignatura.id_asignatura, nombre from curso_asignatura" +
                    " inner join asignatura on curso_asignatura.año = " + año + " and division = " + division;

                command = new SQLiteCommand(sql, connection);

                try
                {
                    SQLiteDataReader lector = command.ExecuteReader();

                    while (lector.NextResult())
                    {
                        int id = lector.GetInt32(0);
                        string nombre = lector.GetString(1);
                        List<Examen> examenes = buscarExamenes(id);
                        Correlativas correlativas = buscarCorrelativas(id);
                        List<Profesor> profesores = buscarProfesores(id);

                        Asignatura asignatura = new Asignatura(id, nombre, correlativas, profesores);
                        asignatura.agregarExamenes(examenes);

                        asignaturas.Add(asignatura);
                    }

                    lector.Close();
                    command.Connection.Close();

                    return asignaturas;
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
        }

        /// <summary>
        /// busca los profesores que dan clases en esa asignatura
        /// </summary>
        /// <param name="id">id de la asignatura</param>
        /// <returns>una lista de profesores</returns>
        private List<Profesor> buscarProfesores(int id)
        {
            try
            {
                List<Profesor> profesores = new List<Profesor>();
                conectar();
                string sql = "select * from Profesor_asignatura inner join profesor on  Profesor_asignatura.id_asignatura =" + id;
                command = new SQLiteCommand(sql, connection);


                ////estoy viendo por que no anda esto
                try
                {
                    SQLiteDataReader lector = command.ExecuteReader();

                    while (lector.NextResult())
                    {
                        int dni = lector.GetInt32(2);
                        string nombre = lector.GetString(3);
                        string apellido = lector.GetString(4);
                        string direccion = lector.GetString(5);
                        string telefono = lector.GetString(6);
                        bool delCentro = lector.GetBoolean(7);

                        Profesor profesor = new Profesor(nombre, apellido, dni, direccion, telefono, delCentro);

                        profesores.Add(profesor);
                    }

                    command.Connection.Close();
                    lector.Close();

                    return profesores;
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error " + e);
            }
        }

        /// <summary>
        /// busca las correlativas de la asignatura que le pasamos 
        /// </summary>
        /// <param name="id">id de la asignatura de la cual necesitamos saber sus correlativas</param>
        /// <returns></returns>
        private Correlativas buscarCorrelativas(int id)
        {
            try
            {
                Correlativas correlativa = new Correlativas();
                conectar();
                string sql = "select * from Correlatividad where para_cursar = " + id;
                command = new SQLiteCommand(sql, connection);

                try
                {
                    SQLiteDataReader lector = command.ExecuteReader();

                    while (lector.NextResult())
                    {

                        Asignatura regular = buscarAsignatura("id_asignatura = " + lector.GetInt32(0)).ElementAt(0);
                        Asignatura aprobada = buscarAsignatura("id_asignatura = " + lector.GetInt32(1)).ElementAt(0);

                        correlativa.agregarAprobada(aprobada);
                        correlativa.agregarRegular(regular);
                    }

                    command.Connection.Close();
                    lector.Close();

                    return correlativa;

                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error " + e);
            }

        }

        /// <summary>
        /// busca los examenes que sean de esa asignatura
        /// </summary>
        /// <param name="id">id de la asignatura</param>
        /// <returns>todos los examenes que se hayan hecho en esa asignatura</returns>
        private List<Examen> buscarExamenes(int id)
        {
            try
            {
                List<Examen> examenes = new List<Examen>();
                conectar();
                string sql = "select * from Examenes where id_asigantura = " + id;
                command = new SQLiteCommand(sql, connection);

                try
                {
                    SQLiteDataReader lector = command.ExecuteReader();

                    while (lector.NextResult())
                    {
                        int id_asignatura = lector.GetInt32(0);
                        int dni = lector.GetInt32(1);

                        Examen examen = new Examen(dni, id_asignatura);

                        examen.agregarNotaExamen(lector.GetInt32(2));
                        examen.agregarNotaExamen(lector.GetInt32(3));
                        examen.agregarNotaExamen(lector.GetInt32(4));
                        examen.agregarNotaRecuperatorio(lector.GetInt32(5));
                        examen.agregarNotaRecuperatorio(lector.GetInt32(6));

                        examenes.Add(examen);
                    }

                    command.Connection.Close();
                    lector.Close();


                    return examenes;

                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error " + e);
            }

        }

        /// <summary>
        /// busca un aula en la base de datos. 
        /// </summary>
        /// <param name="numero">numero identificador del aula</param>
        /// <returns> retorna el aula que tenga el numero identificador que pasamos por parametro.
        /// en caso de no encontrarla devuelve null</returns>
        private Aula buscarAula(int numero)
        {
            try
            {
                conectar();
                string sql = "select * from aula where numero = " + numero;
                command = new SQLiteCommand(sql, connection);
                Aula aula = null;

                SQLiteDataReader lector = command.ExecuteReader();

                while (lector.NextResult())
                {
                    int capacidad = lector.GetInt32(1);
                    bool internet = lector.GetBoolean(2);
                    bool proyector = lector.GetBoolean(3);

                    aula = new Aula(capacidad, numero, proyector, internet);
                }

                command.Connection.Close();
                lector.Close();

                return aula;
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// busca alumnos que cumplan con determinada condicion
        /// </summary>
        /// <param name="sentencia"></param>
        /// <returns></returns>
        private List<Alumno> buscarAlumnos(string sentencia = "")
        {
            try
            {
                List<Alumno> alumnos = new List<Alumno>();
                conectar();
                string sql = "select * from alumno" + sentencia;
                command = new SQLiteCommand(sql, connection);

                SQLiteDataReader lector = command.ExecuteReader();

                while (lector.NextResult())
                {
                    int dni = lector.GetInt32(0);
                    int matricula = lector.GetInt32(1);
                    string nombre = lector.GetString(2);
                    string apellido = lector.GetString(3);
                    string direccion = lector.GetString(4);
                    string telefono = lector.GetString(5);
                    string año = lector.GetString(6);
                    string division = lector.GetString(7);

                    Alumno alumno = new Alumno(nombre, apellido, dni, direccion, telefono, año, division, matricula);

                    alumnos.Add(alumno);
                }

                return alumnos;
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
        }

        #endregion
        //
        //
        //
        //      cargarTabla
        // 
        //
        //

        #region cargar tablas

        public void tablaAlumnos(DataGridView dataGridView, string sentencia = "")
        {
            try
            {
                conectar();
                string sql = "select * from alumno" + sentencia;
                dataAdapter = new SQLiteDataAdapter(sql, connection);

                DataSet ds = new DataSet();
                ds.Reset();

                DataTable dt = new DataTable();
                dataAdapter.Fill(ds);

                dt = ds.Tables[0];

                dataGridView.DataSource = dt;
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        public void tablaAulas(DataGridView dataGridView, string sentencia = "")
        {
            try
            {
                conectar();
                string sql = "select * from aula" + sentencia;
                dataAdapter = new SQLiteDataAdapter(sql, connection);
                
                dataSet.Reset();

                DataTable dt = new DataTable();
                dataAdapter.Fill(dataSet);

                dt = dataSet.Tables[0];

                dataGridView.DataSource = dt;

                dataAdapter.Update(dataSet);
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        public void tablaProfesor(DataGridView dataGridView, string sentencia = "")
        {
            try
            {
                conectar();
                string sql = "select * from profesor" + sentencia;
                dataAdapter = new SQLiteDataAdapter(sql, connection);

                DataSet ds = new DataSet();
                ds.Reset();

                DataTable dt = new DataTable();
                dataAdapter.Fill(ds);

                dt = ds.Tables[0];

                dataGridView.DataSource = dt;                
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        public DataTable tablaAlumnos(DataGridView dataGridView, int id_asignatura)
        {
            try
            {
                conectar();
                string sql = "select * from alumno_asignatura inner join alumno on  alumno_asignatura.id_asignatura =" + id_asignatura;
                dataAdapter = new SQLiteDataAdapter(sql, connection);

                DataSet ds = new DataSet();
                ds.Reset();

                DataTable dt = new DataTable();
                dataAdapter.Fill(ds);

                dt = ds.Tables[0];

                dataGridView.DataSource = dt;

                return dt;
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        public void tablaCursos(DataGridView dataGridView)
        {
            try
            {
                conectar();
                string sql = "select * from curso";
                dataAdapter = new SQLiteDataAdapter(sql, connection);

                DataSet ds = new DataSet();
                ds.Reset();

                DataTable dt = new DataTable();
                dataAdapter.Fill(ds);

                dt = ds.Tables[0];

                dataGridView.DataSource = dt;
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        public DataTable tablaMaterias(DataGridView dataGridView)
        {
            try
            {
                conectar();
                string sql = "select asignatura.nombre, asignatura.id_asignatura as 'Identificador', profesor.Nombre || ' ' || profesor.apellido as Profesor " +
                            "from asignatura inner join profesor, profesor_asignatura " +
                            "where asignatura.id_asignatura = profesor_asignatura.id_asignatura and profesor.dni = profesor_asignatura.dni_profesor";
                dataAdapter = new SQLiteDataAdapter(sql, connection);

                DataSet ds = new DataSet();
                ds.Reset();

                DataTable dt = new DataTable();
                dataAdapter.Fill(ds);

                dt = ds.Tables[0];
                dt.Columns[0].ColumnName = "Asignatura";

                dataGridView.DataSource = dt;

                return dt;
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
                
            }
        }

        public void tablaMateriasProfesor(string dni_profesor, DataGridView dataGridView)
        {
            try
            {
                conectar();

                
                string sql ="select  aula.numero as 'aula', asignatura.nombre as 'materia', asignatura.id_asignatura as 'id' " +
                            " from profesor_asignatura, aula, asignatura, curso, curso_asignatura where" +
                            " curso_asignatura.id_asignatura = asignatura.id_asignatura and" +
                            " curso.aulas = aula.numero and '" +
                              dni_profesor + "' = profesor_asignatura.dni_profesor and" +
                            " asignatura.id_asignatura = profesor_asignatura.id_asignatura;";

                dataAdapter = new SQLiteDataAdapter(sql, connection);
                dataSet.Reset();

                DataTable dt = new DataTable();
                dataAdapter.Fill(dataSet);

                dt = dataSet.Tables[0];

                dataGridView.DataSource = dt;
                
                
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        public void tablaMateriasAlumno(string dni_alumno, DataGridView dataGridView)
        {
            try
            {
                conectar();
                string sql = "select  aula.numero as 'aula', asignatura.nombre as 'materia', curso.año || ' - ' || curso.division as 'curso' " +
                             "from aula, asignatura, curso, alumno_asignatura, alumno, curso_asignatura" +
                             " where Curso_Asignatura.id_asignatura = Asignatura.id_asignatura and " +
                             " curso.aulas = aula.numero and '" +
                             dni_alumno + "' = alumno_asignatura.dni_alumno and " +
                             "alumno_asignatura.id_asignatura = asignatura.id_asignatura;";
                dataAdapter = new SQLiteDataAdapter(sql, connection);

                dataSet.Reset();

                DataTable dt = new DataTable();
                dataAdapter.Fill(dataSet);

                dt = dataSet.Tables[0];

                dataGridView.DataSource = dt;
               
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        public void tablaExamenesAlumno(string dni,  DataGridView dataGridView)
        {
            try
            {
                conectar();
                string sql = "select asignatura.nombre as 'materia',  primerParcial as 'Parcial 1', segundoParcial as 'Parcial 2', tercerParcial as 'Parcial 3', " +
                                " PrimerRecuperatorio as  'Recu. 1', segundoRecuperatorio as  'Recu. 2' " +
                                " from examen, asignatura " +
                                " where '" + dni + "' = examen.dni_alumno and" +
                                " asignatura.id_asignatura = examen.id_asignatura;";

                dataAdapter = new SQLiteDataAdapter(sql, connection);

                dataSet.Reset();

                DataTable dt = new DataTable();
                dataAdapter.Fill(dataSet);

                dt = dataSet.Tables[0];

                dataGridView.DataSource = dt;
               
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }
        
        public void tablaExamenesProfesor(string dni, int id_asignatura, DataGridView dataGridView)
        {
            try
            {
                conectar();
                string sql = "select alumno.apellido || ' ' || alumno.nombre as 'alumno', alumno.dni, primerParcial as 'Parcial 1', segundoParcial as 'Parcial 2', tercerParcial as 'Parcial 3', " +
                "PrimerRecuperatorio as  'Recu 1', segundoRecuperatorio as  'Recu 2' " +
                "from examen inner join profesor_asignatura, alumno " +
                "where examen.id_asignatura = " + id_asignatura + " and " + 
                "examen.id_asignatura = profesor_asignatura.id_asignatura and '" +
                 dni + "' = profesor_asignatura.dni_profesor; ";

                dataAdapter = new SQLiteDataAdapter(sql, connection);

                dataSet.Reset();

                DataTable dt = new DataTable();
                dataAdapter.Fill(dataSet);

                dt = dataSet.Tables[0];

                dataGridView.DataSource = dt;

            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// carga los alumnos que cursen esa materia
        /// </summary>
        /// <param name="id_asignatura"></param>
        /// <param name="dataGridView1"></param>
        public void tablaAlumnoMaterias(int id_asignatura, DataGridView dataGridView)
        {
            try
            {
                conectar();
                string sql = "select  alumno.nombre, alumno.apellido, alumno.dni, alumno.año || ' - '  || alumno.division as 'Curso' " +
                             "from alumno_asignatura, alumno " +
                             "where  alumno_asignatura.id_asignatura = "+ id_asignatura +" and " +
                             "alumno.dni = alumno_asignatura.dni_alumno";
                dataAdapter = new SQLiteDataAdapter(sql, connection);

                dataSet.Reset();

                DataTable dt = new DataTable();

                dataAdapter.Fill(dataSet);

                dt = dataSet.Tables[0];

                dataGridView.DataSource = dt;
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        public void tablaMateriasCurso(string año, string division, DataGridView dataGridView)
        {
            try
            {
                conectar();
                string sql = "select asignatura.nombre, asignatura.id_asignatura as  'numero identificador', profesor.nombre || ' ' || profesor.apellido as 'Profesor' " +
                             " from asignatura, profesor inner join curso_asignatura, profesor_asignatura " +
                             " where '" + año + "' = curso_asignatura.año and " +
                             "'" + division + "' = curso_asignatura.division and " +
                             "asignatura.id_asignatura = curso_asignatura.id_asignatura and" +
                             " profesor.dni = profesor_asignatura.dni_profesor and " +
                             " asignatura.id_asignatura = profesor_asignatura.id_asignatura;";

                dataAdapter = new SQLiteDataAdapter(sql, connection);

                DataSet ds = new DataSet();
                ds.Reset();

                DataTable dt = new DataTable();
                dataAdapter.Fill(ds);

                dt = ds.Tables[0];

                dataGridView.DataSource = dt;
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }


        #endregion

        #region cargar comboboxs

        public void comboboxAulas(ComboBox comboBox)
        {
            try
            {
                conectar();
                string sql = "select * from aula";
                dataAdapter = new SQLiteDataAdapter(sql, connection);

                DataSet ds = new DataSet();
                ds.Reset();

                DataTable dt = new DataTable();
                dataAdapter.Fill(ds);

                dt = ds.Tables[0];

                comboBox.DataSource = dt;


                comboBox.DisplayMember = "numero"; //Campo de la db que deseamos mostrar
                comboBox.ValueMember = "numero";
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        public void comboboxCursos(ComboBox comboBox)
        {
            try
            {
                conectar();
                string sql = "select (año || ' ' || division) as muestra, (año || division) as curso from curso";
                dataAdapter = new SQLiteDataAdapter(sql, connection);

                DataSet ds = new DataSet();
                ds.Reset();

                DataTable dt = new DataTable();
                dataAdapter.Fill(ds);

                dt = ds.Tables[0];

                comboBox.DataSource = dt;


                comboBox.DisplayMember = "muestra"; //Campo de la db que deseamos mostrar
                comboBox.ValueMember = "curso";
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        public void comboBoxProfesores(ComboBox comboBox)
        {
            try
            {
                conectar();
                string sql = "select dni, nombre || ' ' || apellido as nombre " + /*AS nombre  */ "from profesor;";

                dataAdapter = new SQLiteDataAdapter(sql, connection);

                DataSet ds = new DataSet();
                ds.Reset();

                dataAdapter.Fill(ds);

                comboBox.DataSource = ds.Tables[0];//dt;


                comboBox.DisplayMember = "nombre"; //Campo de la db que deseamos mostrar
                comboBox.ValueMember = "dni";
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        public void comboboxAlumnos(ComboBox comboBox)
        {
            try
            {
                conectar();
                string sql = "select dni,  dni || '  ' ||  nombre || ' ' || apellido as nombre from alumno;";

                dataAdapter = new SQLiteDataAdapter(sql, connection);

                DataSet ds = new DataSet();
                ds.Reset();

                dataAdapter.Fill(ds);

                comboBox.DataSource = ds.Tables[0];//dt;


                comboBox.DisplayMember = "nombre"; //Campo de la db que deseamos mostrar
                comboBox.ValueMember = "dni";
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        public void comboboxAsignaturas(string año, string division, ComboBox comboBox)
        {
            try
            {
                conectar();
                string sql = "select asignatura.id_asignatura, asignatura.nombre || ' ' || asignatura.id_asignatura as 'identificador'" +
                             " from asignatura;";

                dataAdapter = new SQLiteDataAdapter(sql, connection);

                DataSet ds = new DataSet();
                ds.Reset();

                dataAdapter.Fill(ds);

                comboBox.DataSource = ds.Tables[0];//dt;


                comboBox.DisplayMember = "identificador"; //Campo de la db que deseamos mostrar
                comboBox.ValueMember = "id_asignatura";
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        #endregion
        //
        //
        //
        //      cosas aparte
        //
        //
        //
        public void dividirCursoDivision(string añoDivision, out int año, out char division)
        {

            año = 0;
            division = '1';

            for (int i = 0; i < añoDivision.Length; i++)
            {
                if (!int.TryParse(añoDivision.ElementAt(i).ToString(), out año))
                {
                    division = añoDivision.ElementAt(i);
                }
            }
        }
        
        public void mostrarMensaje(string mensaje)
        {
            const string caption = "Datos Erroneos";
            var result = MessageBox.Show(mensaje, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
        }

        public void mostrarMensajeGuardado(string mensaje)
        {
            const string titulo = "Datos Guardados";
            var result = MessageBox.Show(mensaje, titulo,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
        }

        public void SaveDatabase(DataSet cambios)
        {

            conectar();            
            

            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM alumno_asignatura, profesor_asignatura, curso_asignatura, alumno, asignatura, curso" +
                "profesor, examen, correlatividad, aula", connection);

            SQLiteCommandBuilder cb = new SQLiteCommandBuilder(dataAdapter);

            dataAdapter.Update(cambios);
            dataSet.AcceptChanges();
            desconectar();            

        }
    }
}
