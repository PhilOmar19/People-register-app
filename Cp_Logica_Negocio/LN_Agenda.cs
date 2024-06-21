using Cp_Datos;
using Cp_Entidad;
using System.Data;

namespace Cp_Logica_Negocio
{
    public class LN_Agenda
    {
        D_Agenda datos = new D_Agenda();

        public DataTable LN_ShowRecord()
        {
            return datos.D_ShowRecord();
        }
        public void LN_DeleteRecord(int id)
        {
            datos.D_DeleteRecord(id);
        }
        public void LN_AddRecord(string Nombre, string Apellido, string Dirección, DateTime Fecha_nacimiento, string Celular)
        {
            datos.D_AddRecord(Nombre,Apellido,Dirección,Fecha_nacimiento,Celular);
        }
        public DataTable LN_GetRecord(int id)
        {
            return datos.D_GetRecord(id);
        }
        public void LN_UpdateRecord(int id, string Nombre, string Apellido, string Dirección, DateTime Fecha_nacimiento, string Celular)
        {
            datos.D_UpdateRecord(id,Nombre, Apellido, Dirección, Fecha_nacimiento, Celular);
        }
    }
}