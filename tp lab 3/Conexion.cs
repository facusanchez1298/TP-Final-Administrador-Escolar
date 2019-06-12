using System;
using System.Collections.Generic;
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

        string crearTablaAlu_Asig =     "create table if not exists alumno_asignatura(" +
                                            "dni_alumno int not null," +
                                            "id_asignatura int not null," +
                                            "aprobada boolean defaul false," +
                                            "cursando boolean defaul true," +
                                            "primary key(dni_alumno, id_asignatura)," +
                                            "FOREIGN KEY(dni_alumno) REFERENCES Alumno(dni_alumno)," +
                                            "FOREIGN KEY(id_asignatura) REFERENCES Asignatura(id_asignatura));";

        string creatTablaProf_Asig =     "create table if not exists Profesor_Asignatura(" +
                                            "dni_profesor int not null," +
                                            "id_asignatura int not null," +
                                            "primary key(dni_profesor, id_asignatura)," +
                                            "FOREIGN KEY(dni_profesor) REFERENCES Profesor(dni)," +
                                            "FOREIGN KEY(id_asignatura) REFERENCES Asignatura(id_asignatura));";

        string crearTablaCurso_Asig =    "create table if not exists Curso_Asignatura(" +
                                            "año_division varchar not null," +
                                            "id_asignatura int not null," +
                                            "primary key(año_division, id_asignatura)," +
                                            "FOREIGN KEY(año_division) REFERENCES Curso(año_division)," +
                                            "FOREIGN KEY(id_asignatura) REFERENCES Asignatura(id_asignatura));";

        string crearTablaExamenes =      "create table if not exists Examen(" +
                                            "id_asignatura int not null," +
                                            "dni_Alumno int not null," +
                                            "primerParcial int default -1," +
                                            "segundoParcial int default -1," +
                                            "tercerParcial int default -1," +
                                            "primerRecuperatorio int default -1," +
                                            "segundoRecuperatorio int default -1," +
                                            "primary key(id_asignatura, dni_Alumno));";

        string crearTablaCorrelatividad ="create table if not exists Correlatividad(" +
                                            "regular int," +
                                            "aprobada int," +
                                            "para_cursar int);";

        string crearTablaProfesor =     "create table if not exists Profesor(" +
                                            "dni int primary key not null," +
                                            "nombre varchar not null," +
                                            "apellido varchar," +
                                            "direccion varchar," +
                                            "telefono int," +
                                            "delCentro boolean);";

        string crearTablaAsignatura =   "create table if not exists asignatura(" +
                                            "id_asignatura int primary key," +
                                            "nombre varchar not null);";


        string crearTablaAula =         "create table if not exists aula(" +
                                            "numero int PRIMARY KEY," +
                                            "capacidad int not null," +
                                            "internet boolean not null," +
                                            "proyector boolean not null);";

        string crearTablaAlumno =       "create table if not exists alumno(" +
                                            "dni int primary key," +
                                            "matricula int," +
                                            "nombre varchar not null," +
                                            "apellido varchar not null," +
                                            "direccion varchar," +
                                            "telefono int," +
                                            "año_division varchar," +
                                            "foreign key(año_division) references Curso(año_division));";

        string crearTablaCurso =         "create table if not exists Curso(" +
                                            "año_division varchar primary key," +
                                            "aulas int);";

        /// <summary>
        /// los tipos que deberian ir son alumno, profesor o bedel
        /// </summary>
        string crearTablaUsuario =       "create table if not exists usuario(" +
                                            "usuario int not null," +
                                            "contraseña varchar not null," +
                                            "tipo varchar not null);";

        

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
                command = new SQLiteCommand(crearTablaAlu_Asig +crearTablaCurso_Asig + creatTablaProf_Asig + crearTablaProfesor + crearTablaAula + crearTablaAlumno
                   + crearTablaCurso + crearTablaExamenes + crearTablaCorrelatividad + crearTablaAsignatura + crearTablaUsuario, connection);


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
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
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

                

                if(lector.Read())
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
        //
        //
        //
        //      elementos de guardado
        //
        //
        //
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
                string sql = "insert into alumno_asignatura(dni_alumno, id_asignatura) values (" + dni + "," + id + ")";
                command = new SQLiteCommand(sql, this.connection);

                try
                {
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                }
                catch (Exception e)
                {

                    throw new Exception("Error guardando el registro: " + e);
                }


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
        /// guarda un registro en la tabla curso asignatura
        /// </summary>
        /// <param name="curso_año"> año y division convinados en un string </param>
        /// <param name="id_asignatura"> numero identificador de la asignatura</param>
        public void guardarCurso_asig(string curso_año, int id_asignatura)
        {
            try
            {
                conectar();
                string sql = "insert into Curso_Asignatura values ('" + curso_año + "', " + id_asignatura + ")";

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

                throw new Exception("Error: " + e) ;
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
                string sql = "insert int alumnos(dni, matricula, nombre, apellido, direccion, telefono, año_division) values " +
                        "(" + alumno.dni + "," + alumno.matricula + ",'" + alumno.nombre + "','" + alumno.apellido + "','" + alumno.direccion +
                        "'," + alumno.telefono + ",'" + alumno.curso + "')";

                

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
                    int año;
                    char division;
                    string año_Div = lector.GetString(0);


                    dividirCursoDivision(año_Div, out año, out division);
                    Aula aula = buscarAula(lector.GetInt32(1));
                    Curso curso = new Curso(año, division, aula);

                    curso.agregarAlumnos(buscarAlumnos("where año_division = " + año_Div));
                    curso.agregarAsignaturas(buscarAsignatura_curso(año_Div));
                                                                          
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
        //       elementos de busqueda
        //
        //
        //
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
        private List<Asignatura> buscarAsignatura_curso(string año_Division)
        {
            try
            {

                List<Asignatura> asignaturas = new List<Asignatura>();
                conectar();
                string sql = "select asignatura.id_asignatura, nombre from curso_asignatura" +
                    " inner join asignatura on curso_asignatura.año_division = " + año_Division;
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
                        int telefono = lector.GetInt32(6);
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

                SQLiteDataReader letor = command.ExecuteReader();

                while (letor.NextResult())
                {
                    int dni = letor.GetInt32(0);
                    int matricula = letor.GetInt32(1);
                    string nombre = letor.GetString(2);
                    string apellido = letor.GetString(3);
                    string direccion = letor.GetString(4);
                    int telefono = letor.GetInt32(5);
                    string curso = letor.GetString(6);

                    Alumno alumno = new Alumno(nombre, apellido, dni, direccion, telefono, curso, matricula);

                    alumnos.Add(alumno);
                }

                return alumnos;
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
        }        
        //
        //
        //
        //      cosas aparte
        //
        //
        //
        public void dividirCursoDivision(string añoDivision ,out int año, out char division)
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
    }
}
