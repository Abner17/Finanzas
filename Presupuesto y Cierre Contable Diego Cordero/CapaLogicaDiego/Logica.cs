using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatosDiego;


namespace CapaLogicaDiego
{
    public class Logica
    {
        private Sentencias sentencias = new Sentencias();

        public void MostrarCuentas(ListBox listBox)
        {
            sentencias.llenarListaCuentas(listBox);
        }

        public void LLenarDepartamentosYEjercicio(DomainUpDown ejercicioPresupuesto, ListBox lst_departamento)
        {
            sentencias.llenarAuxilires(ejercicioPresupuesto, lst_departamento);
        }

    }
}
