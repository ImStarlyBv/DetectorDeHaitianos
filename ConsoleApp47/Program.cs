namespace DetectorDeHaitianos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            bool EsHaitiano=false;
            foreach (string apex in DetectorDeHaitiano.listaApellidos) {

               EsHaitiano = DetectorDeHaitiano.EsHaitiano("Samuel", apex);
                if (EsHaitiano) break;
                
               

            }

            if (EsHaitiano)
                Console.WriteLine("es haitiano");
            else Console.WriteLine("Felicidades! no eres haitiano!");

        }
    }



    public static class DetectorDeHaitiano {

       public static string[] listaApellidos { get; set; } = {
  "Ababa",
    "Abbey",
    "Abebe",
    "Abimbola",
    "Abiodun",
    "Acheampong",
    "Achebe",
    "Adebayo",
    "Adebisi",
    "Adebowale",
    "Adeleke",
    "Adegoke",
    "Adekunle",
    "Adelakun",
    "Ademola",
    "Adesina",
    "Adesiyan",
    "Adeyemi",
    "Adisa",
    "Afia",
    "Afolabi",
    "Afolayan",
    "Agrinya",
    "Ahamad",
    "Akonnor",
    "Alaba",
    "Ali",
    "Ama",
    "Amadou",
    "Amaury",
    "AmaZulu",
    "Antwi",
    "Anyanwu",
    "Balogun",
    "Bamigboye",
    "Baraka",
    "Bassey",
    "Beatrice",
    "Benin",
    "Bello",
    "Biko",
    "Busia",
};



        public static bool EsHaitiano(string Apellido, string Basededatos)
        {
            int coincidencias=0;
            for (int index = 0; ; index++)
            {
                if (index == Descomponer(Apellido).Length - 1 || index == Descomponer(Basededatos).Length - 1) break;


                if (Descomponer(Apellido)[index] == Descomponer(Basededatos)[index]) coincidencias++;


            }
            if (coincidencias >= Descomponer(Basededatos).Length-1) return true;
            else return false;              


        }
        

        public static char[] Descomponer(string Name)
        {

            char[] descompuesto= new char[Name.Length];
            
            foreach(char c in Name) {

                int index = 0;
                descompuesto[index] = (char)c;
            
            
            
            }
            return descompuesto;
        }

    }

}