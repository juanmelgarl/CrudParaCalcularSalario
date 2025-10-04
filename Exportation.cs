using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsApps
{
    public static class Exportation
    {
        public static void ExportarJson(List<Persona> prs)
        {
            string json = JsonSerializer.Serialize(prs,new JsonSerializerOptions
                {
                WriteIndented = true
            });
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string ruta = Path.Combine(escritorio, "clientes.json");

            File.WriteAllText(ruta, json);
            MessageBox.Show("datos exportados correctamene a un json");
        }
    }
}

