using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANDBAN2122
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno miAlumno = new Alumno();
            String miAlumnoStr, miAlumnoNotaTexto;
            miAlumno.Nombre = aluNombre.Text;
            miAlumno.Nota = Convert.ToInt32(aluNota.Text);
            if (miAlumno.Nota<5) {
                miAlumnoNotaTexto = "Suspenso";
            }
            else if (miAlumno.Nota<7) {
                miAlumnoNotaTexto = "Aprobado";
            }
            else if (miAlumno.Nota<9) {
                miAlumnoNotaTexto = "Notable";
            }
            else
                miAlumnoNotaTexto = "Sobresaliente";
                miAlumnoStr = aluNombre.Text + " " + aluNota.Text + " " +
                miAlumnoNotaTexto +"\n";
                listaAlumnos.AppendText(miAlumnoStr);
                misAlumnos.Agregar(miAlumno);
            }
        }

    }
}
