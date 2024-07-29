using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace Aplicatie_educationala_pentru_invatarea_geografiei
{
    class DataBase
    {
        const string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Cosmin\OneDrive\Documente\GeoLearn.mdf;Integrated Security=True;Connect Timeout=30";

        public static List<Intrebari> ExtractIntrebari(int Unitate_id)
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Unitate_id", Unitate_id);

                var listaIntrebari = conn.Query<Intrebari>("SELECT I.Intrebare_text, I.Intrebare_id FROM Intrebari as I Join Unitate as U ON I.Unitate_id = U.Unitate_id WHERE U.Unitate_id = @Unitate_id ORDER BY NEWID()", parameters).ToList();
                return listaIntrebari;
            }
        }
        public static List<Raspunsuri> ExtractRaspunsuriPeUnitate(int Unitate_id, List<int> ListaIntrebare_id)
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Unitate_id", Unitate_id);
                parameters.Add("@ListaIntrebare_id", ListaIntrebare_id);

                var listaRaspunsuri = conn.Query<Raspunsuri>("SELECT R.Raspuns_text, R.Raspuns_Intrebare_id, R.Raspuns_status FROM Raspunsuri as R JOIN Intrebari as I ON R.Raspuns_Intrebare_id = I.Intrebare_id WHERE I.Unitate_id = @Unitate_id AND R.Raspuns_Intrebare_id IN @ListaIntrebare_id ORDER BY NEWID()",parameters).ToList();
                return listaRaspunsuri;
            }
        }
        public static int ExtractUnitate_id(string Unitate_denumire)
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Unitate_denumire", Unitate_denumire);

                int Unitate_id = Convert.ToInt32(conn.QuerySingleOrDefault<int>("SELECT U.Unitate_id FROM Unitate as U WHERE Unitate_denumire = @Unitate_denumire", parameters));
                return Unitate_id;
            }
        }
        public static int ExtractIntrebare_id(string Intrebare_text)
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Intrebare_text", Intrebare_text);

                int Intrebare_id = Convert.ToInt32(conn.QuerySingleOrDefault<int>("SELECT I.Intrebare_id FROM Intrebari as I WHERE Intrebare_text = @Intrebare_text", parameters));
                return Intrebare_id;
            }
        }
        public static List<Unitate> ExtractUnitatiId()
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                var listaUnitate_id = conn.Query<Unitate>("SELECT Unitate_id FROM Unitate").ToList();
                return listaUnitate_id;
            }
        }
        public static List<Intrebari> ExtractIntrebari(List<Unitate> Unitati_id)
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                var listaIntrebari = new List<Intrebari>();
                foreach (var Unitate_id in Unitati_id)
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Unitate_id", Unitate_id.Unitate_id);

                    // Obține întrebările pentru unitatea de id-ul curent
                    var intrebariUnitateCurenta = conn.Query<Intrebari>("SELECT TOP 5 I.Intrebare_text, I.Intrebare_id, I.Unitate_id FROM Intrebari AS I WHERE I.Unitate_id = @Unitate_id", parameters).ToList();

                    // Adaugă întrebările obținute la lista existentă
                    listaIntrebari.AddRange(intrebariUnitateCurenta);
                }
                return listaIntrebari;
            }
        }
        public static List<Raspunsuri> ExtractRaspunsuri(List<int> ListaIntrebari_id)
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ListaIntrebari_id", ListaIntrebari_id);

                var listaRaspunsuri = conn.Query<Raspunsuri>("SELECT R.Raspuns_text, R.Raspuns_Intrebare_id, R.Raspuns_status FROM Raspunsuri as R JOIN Intrebari as I ON R.Raspuns_Intrebare_id = I.Intrebare_id WHERE R.Raspuns_Intrebare_id IN @ListaIntrebari_id ORDER BY NEWID()", parameters).ToList();

                return listaRaspunsuri;
            }
        }
        public static string ExtractUnitate(int Unitate_id)
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Unitate_id", Unitate_id);
               
                string unitate = conn.QuerySingleOrDefault<string>("SELECT U.Unitate_denumire FROM Unitate as U WHERE U.Unitate_id = @Unitate_id", parameters);
                return unitate;
            }
        }

    }
}
